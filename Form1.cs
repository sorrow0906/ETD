using System;
using System.Windows.Forms;
using NAudio.Wave;
using System.Windows.Media;
using System.Text;
using System.Drawing;

//musicPlayer.Position = new TimeSpan(0, 1, 30); // 재생할위치 설정 가능 (시 분 초)

namespace Interface
{
    public partial class Form1 : Form
    {
        const int ERROR_CONST_NUM = 15; // default error number
        const int BUFFER_SIZE = 16384; // default buffer size
        const int RATE = 5000; // default rate
        const int DTW_SIZE = 500; // default dtw devide size 
        string arName = "ar.wav", mrName = "mr.wav", recordName = "record.wav"; // basic file name

        MediaPlayer musicPlayer = new MediaPlayer(); // music player
        Recorder micRecord = new Recorder(); // voice recorder

        int errorFactor = 5; // 오차율 (%)
        int sessionRepeat = 0; // 구간반복 시간
        bool isPlaying = false; // 현재 play 여부
        int timerHandle = 0, minute = 0, sec = 0; // time control
        double [] musicVoice = null, recordVoice = null; // wav to double data
        double[] dtwResult = null;

        public Form1()
        {
            InitializeComponent();

            musicChart.Series.Add("wave");
            musicChart.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            musicChart.Series["wave"].ChartArea = "ChartArea1";

            VoiceChart.Series.Add("wave");
            VoiceChart.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            VoiceChart.Series["wave"].ChartArea = "ChartArea1";

            musicPlayer.MediaEnded += media_ended; // 이벤트 핸들러 추가
            lyricsTextBox.ScrollBars = ScrollBars.Vertical;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Space))
                this.playPauseButton_Click(sender, e);
        }

        private void 프로그램닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 곡열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicPlayer.Close();

            // ar file mp3 to wav
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "MP3 File(*.mp3)|*.mp3";
            open.InitialDirectory = @"C:\";

            if (open.ShowDialog() != DialogResult.OK)
                return;

            using (Mp3FileReader mp3 = new Mp3FileReader(open.FileName))
            using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                WaveFileWriter.CreateWaveFile(arName, pcm);
            // ar file mp3 to wav end

            // basic setting
            getLyrics(open.FileName);

            string tempName = open.FileName;
            tempName = tempName.Substring(tempName.LastIndexOf('\\') + 1);
            musicInfo.Text = tempName;
            // basic setting end

            // mr file mp3 to wav
            if (open.ShowDialog() != DialogResult.OK)
                return;

            using (Mp3FileReader mp3 = new Mp3FileReader(open.FileName))
            using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                WaveFileWriter.CreateWaveFile(mrName, pcm);
            // mr file mp3 to wav end

            drawGraph(); // draw vr graph
        }

        private void 일치율설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorFactorForm errorForm = new ErrorFactorForm(this);
            errorForm.ShowDialog();
        }

        private void 반복구간설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionRepeatForm sessionForm = new SessionRepeatForm(this);
            sessionForm.ShowDialog();
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        

        public void setErrorFactor(int num) // 오차율 설정
        {
            errorFactor = num;
            errorFactorLabel.Text = num + " %";

            if (dtwResult != null)
                setErrorArea(dtwResult);

            this.Invalidate();
        }

        public void setSessionRepeat(int num) // 반복 설정
        {
            sessionRepeat = num;

            if (sessionRepeat != 0)
                sessionLabel.Text = num + " 초";

            this.Invalidate();
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                timer1.Start();
                musicPlayer.Play();
                isPlaying = true;
                //micRecord.saveWavFile(recordName); /**********************/

                VoiceChart.Series["wave"].Points.Clear();
            }

            else
            {
                timer1.Stop();
                musicPlayer.Pause();
                isPlaying = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // basic setting initialization
            musicPlayer.Stop();
            timer1.Stop();
            isPlaying = false;
            minute = 0; sec = 0; timerHandle = 0;
            textBox2.Text = "00:00";

            //micRecord.stopMic(); /**********************/
            // basic setting initialization end

            drawVoiceGraph();
            
            // call dtw algorithm
            dtwResult = graphDTW();
            setErrorArea(dtwResult); // 오차 검출 함수
            // call dtw algorithm end

            this.Invalidate();
        }

        private void setErrorArea(double [] dtwResult) // 그래프 오차율 검출 및 표시
        {
            int num;
            double sum = 0;

            for(int i = 0; i < dtwResult.Length ; i++)
            {
                num = i * DTW_SIZE;

                if ((double)(errorFactor*ERROR_CONST_NUM) <= dtwResult[i])
                {
                    if (i == dtwResult.Length)
                    {
                        for (int k = num; k < recordVoice.Length; k++)
                        {
                            VoiceChart.Series["wave"].Points[num].Color = System.Drawing.Color.Orange;
                            num++;
                        }
                    }

                    else
                    {
                        for (int j = 0; j < DTW_SIZE; j++)
                        {
                            VoiceChart.Series["wave"].Points[num].Color = System.Drawing.Color.Orange;
                            num++;
                        }
                    }
                }

                sum += dtwResult[i] / (double)ERROR_CONST_NUM;
            }
            double avg = Math.Round(sum / (double)dtwResult.Length, 2);
            MessageBox.Show("평균 오차율은 " + avg + "% 입니다.", "분석 완료");
        }

        private double [] graphDTW() // graph to dtw
        {
            DTW dtw;
            int pointer = 0;
            
            double [] result = new double[(musicVoice.Length / DTW_SIZE) + 1];
            int resultIndex = 0;
            int musicFlag = 0, recordFlag = 0;

            while (pointer < musicVoice.Length && pointer < recordVoice.Length)
            {
                double[] tempMusic = new double[DTW_SIZE];
                double[] tempRecord = new double[DTW_SIZE];
                int musicIndex = 0, recordIndex = 0;

                while (musicIndex < DTW_SIZE && musicFlag < musicVoice.Length && recordIndex < DTW_SIZE && recordFlag < recordVoice.Length)
                {
                    tempMusic[musicIndex++] = musicVoice[pointer];
                    tempRecord[recordIndex++] = recordVoice[pointer++];
                    ++musicFlag; ++recordFlag;
                }

                dtw = new DTW(tempMusic, tempRecord);
                dtw.computeDTW();

                result[resultIndex++] = dtw.getSum();
            }

            return result;
        }

        private void VoiceChart_MouseUp(object sender, MouseEventArgs e) // 특정 부분 분석 결과 출력
        {
            if (dtwResult == null)
                return;

            int xValue = (int)VoiceChart.ChartAreas[0].AxisX2.PixelPositionToValue(e.X);
            double error = Math.Round(dtwResult[xValue / DTW_SIZE] / (double)ERROR_CONST_NUM, 2);

            MessageBox.Show("분석 범위는 " + (xValue/DTW_SIZE) * DTW_SIZE + "~" + (((xValue/DTW_SIZE) * DTW_SIZE) + DTW_SIZE) + "이며 결과는 " + error + "% 입니다.", "일부 분석 결과");
        }

        private void timer1_Tick(object sender, EventArgs e) // 타이머
        {
            if (isPlaying)
            {
                ++timerHandle;

                if (timerHandle >= 5)
                {
                    ++sec;
                    if (sec >= 60)
                    {
                        ++minute;
                        sec = 0;
                    }
                    timerHandle = 0;

                    textBox2.Text = minute.ToString("D2") + ":" + sec.ToString("D2");
                }
            }
            this.Invalidate();
        }

        private void media_ended(object sender, EventArgs e) // event handler
        {
            stopButton_Click(sender, e);
        }

        private void getLyrics(string fileName) // 가사 가져오기
        {
            lyricsTextBox.Clear();
            musicPlayer.Open(new Uri(fileName));
            Mp3Lib.Mp3File lyricsFile = new Mp3Lib.Mp3File(fileName);
            lyricsTextBox.Text = lyricsFile.TagHandler.Lyrics;
        }

        private void drawGraph() // vr graph draw 함수
        {
            WaveChannel32 arWaveChannel = new WaveChannel32(new WaveFileReader(arName));
            WaveChannel32 mrWaveChannel = new WaveChannel32(new WaveFileReader(mrName));
            byte[] arBuffer = new byte[BUFFER_SIZE];
            int arRead = 0;
            byte[] mrBuffer = new byte[BUFFER_SIZE];
            int mrRead = 0;
            byte[] resBuffer = new byte[BUFFER_SIZE];

            musicChart.Series["wave"].Points.Clear();
            VoiceChart.Series["wave"].Points.Clear();

            int musicVoiceIndex = 0;
            musicVoice = new double[arWaveChannel.Length / RATE];

            while (arWaveChannel.Position < arWaveChannel.Length)
            {
                arRead = arWaveChannel.Read(arBuffer, 0, BUFFER_SIZE);
                mrRead = mrWaveChannel.Read(mrBuffer, 0, BUFFER_SIZE);

                for (int j = 0; j < BUFFER_SIZE / 4; j++)
                {
                    float arTemp = BitConverter.ToSingle(arBuffer, j * 4);
                    float mrTemp = BitConverter.ToSingle(mrBuffer, j * 4);

                    float temp = arTemp - mrTemp;
                    byte[] tempBuffer = BitConverter.GetBytes(temp);
                    int index = 0;

                    for (int k = j * 4; k < (j * 4) + 4; k++)
                    {
                        resBuffer[k] = tempBuffer[index++];
                    }
                }

                for (int i = 0; i < arRead / RATE; i++)
                {
                    float temp = BitConverter.ToSingle(resBuffer, i * RATE);

                    if (!float.IsNaN(temp))
                    {
                        musicChart.Series["wave"].Points.Add(temp);
                        musicVoice[musicVoiceIndex++] = temp;
                    }
                }
            }
        }

        private void drawVoiceGraph() // draw voice graph
        {
            WaveChannel32 recordChannel = new WaveChannel32(new WaveFileReader(recordName));
            byte[] recordBuffer = new byte[BUFFER_SIZE];
            int recRead = 0;
            int recordVoiceIndex = 0;
            recordVoice = new double[recordChannel.Length / RATE];

            while (recordChannel.Position < recordChannel.Length)
            {
                recRead = recordChannel.Read(recordBuffer, 0, BUFFER_SIZE);

                for (int i = 0; i < recRead / RATE; i++)
                {
                    float temp = BitConverter.ToSingle(recordBuffer, i * RATE);

                    if (!float.IsNaN(temp))
                    {
                        VoiceChart.Series["wave"].Points.Add(temp);
                        recordVoice[recordVoiceIndex++] = temp;
                    }
                }
            }
        }
    }

    class NullWaveStream : WaveStream
    {
        private readonly WaveFormat format;
        private readonly long length;
        private long position;

        public NullWaveStream(WaveFormat format, long length)
        {
            this.format = format;
            this.length = length;
        }

        public override WaveFormat WaveFormat
        {
            get { return format; }
        }

        public override long Length
        {
            get { return length; }
        }

        public override long Position
        {
            get { return position; }
            set { position = value; }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (position > length)
            {
                return 0;
            }
            count = (int)Math.Min(count, length - position);
            Array.Clear(buffer, offset, count);
            position += count;
            return count;
        }
    }
}
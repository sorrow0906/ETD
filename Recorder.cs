using System;
using System.Text;
using System.Runtime.InteropServices;
using NAudio;

namespace Interface
{
    class Recorder
    {
        private NAudio.Wave.WaveIn sourceStream = null;
        private NAudio.Wave.WaveFileWriter waveWriter = null;

        public Recorder() { }
        
        private void recordMic()
        {
            int deviceNumber = 0;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);
            
            sourceStream.StartRecording();
        }

        public void saveWavFile(string fileName)
        {
            int deviceNumber = 0;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new NAudio.Wave.WaveFileWriter(fileName, sourceStream.WaveFormat);

            sourceStream.StartRecording();
            recordMic();
        }

        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }
        
        public void stopMic()
        {
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }
        }
    }
}
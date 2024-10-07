namespace Interface
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.곡열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.반복구간설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일치율설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lyricsTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorFactorLabel = new System.Windows.Forms.Label();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.musicChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VoiceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.musicInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoiceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2553, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.곡열기ToolStripMenuItem,
            this.프로그램닫기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(90, 45);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 곡열기ToolStripMenuItem
            // 
            this.곡열기ToolStripMenuItem.Name = "곡열기ToolStripMenuItem";
            this.곡열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.곡열기ToolStripMenuItem.Size = new System.Drawing.Size(335, 46);
            this.곡열기ToolStripMenuItem.Text = "곡 열기";
            this.곡열기ToolStripMenuItem.Click += new System.EventHandler(this.곡열기ToolStripMenuItem_Click);
            // 
            // 프로그램닫기ToolStripMenuItem
            // 
            this.프로그램닫기ToolStripMenuItem.Name = "프로그램닫기ToolStripMenuItem";
            this.프로그램닫기ToolStripMenuItem.Size = new System.Drawing.Size(335, 46);
            this.프로그램닫기ToolStripMenuItem.Text = "프로그램 닫기";
            this.프로그램닫기ToolStripMenuItem.Click += new System.EventHandler(this.프로그램닫기ToolStripMenuItem_Click);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.반복구간설정ToolStripMenuItem,
            this.일치율설정ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(90, 45);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 반복구간설정ToolStripMenuItem
            // 
            this.반복구간설정ToolStripMenuItem.Name = "반복구간설정ToolStripMenuItem";
            this.반복구간설정ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.반복구간설정ToolStripMenuItem.Size = new System.Drawing.Size(440, 46);
            this.반복구간설정ToolStripMenuItem.Text = "반복 구간 설정";
            this.반복구간설정ToolStripMenuItem.Click += new System.EventHandler(this.반복구간설정ToolStripMenuItem_Click);
            // 
            // 일치율설정ToolStripMenuItem
            // 
            this.일치율설정ToolStripMenuItem.Name = "일치율설정ToolStripMenuItem";
            this.일치율설정ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.일치율설정ToolStripMenuItem.Size = new System.Drawing.Size(440, 46);
            this.일치율설정ToolStripMenuItem.Text = "오차율 설정";
            this.일치율설정ToolStripMenuItem.Click += new System.EventHandler(this.일치율설정ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(120, 45);
            this.도움말ToolStripMenuItem.Text = "도움말";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.도움말ToolStripMenuItem_Click);
            // 
            // lyricsTextBox
            // 
            this.lyricsTextBox.BackColor = System.Drawing.Color.White;
            this.lyricsTextBox.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lyricsTextBox.Location = new System.Drawing.Point(1905, 75);
            this.lyricsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lyricsTextBox.Multiline = true;
            this.lyricsTextBox.Name = "lyricsTextBox";
            this.lyricsTextBox.ReadOnly = true;
            this.lyricsTextBox.ShortcutsEnabled = false;
            this.lyricsTextBox.Size = new System.Drawing.Size(624, 1312);
            this.lyricsTextBox.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(332, 1260);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(219, 88);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "00:00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "설정된 오차율 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 54);
            this.label2.TabIndex = 12;
            this.label2.Text = "구간반복 시간 : ";
            // 
            // errorFactorLabel
            // 
            this.errorFactorLabel.AutoSize = true;
            this.errorFactorLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorFactorLabel.ForeColor = System.Drawing.Color.White;
            this.errorFactorLabel.Location = new System.Drawing.Point(450, 22);
            this.errorFactorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.errorFactorLabel.Name = "errorFactorLabel";
            this.errorFactorLabel.Size = new System.Drawing.Size(92, 54);
            this.errorFactorLabel.TabIndex = 13;
            this.errorFactorLabel.Text = "5 %";
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sessionLabel.ForeColor = System.Drawing.Color.White;
            this.sessionLabel.Location = new System.Drawing.Point(393, 92);
            this.sessionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(143, 54);
            this.sessionLabel.TabIndex = 14;
            this.sessionLabel.Text = "미설정";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.sessionLabel);
            this.panel1.Controls.Add(this.errorFactorLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1263, 1218);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 168);
            this.panel1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // musicChart
            // 
            chartArea1.Name = "ChartArea1";
            this.musicChart.ChartAreas.Add(chartArea1);
            this.musicChart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.musicChart.Location = new System.Drawing.Point(249, 188);
            this.musicChart.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.musicChart.Name = "musicChart";
            this.musicChart.Size = new System.Drawing.Size(1646, 482);
            this.musicChart.TabIndex = 20;
            this.musicChart.Text = "chart1";
            // 
            // VoiceChart
            // 
            chartArea2.BorderWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.VoiceChart.ChartAreas.Add(chartArea2);
            this.VoiceChart.Location = new System.Drawing.Point(249, 710);
            this.VoiceChart.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.VoiceChart.Name = "VoiceChart";
            this.VoiceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.VoiceChart.Size = new System.Drawing.Size(1646, 482);
            this.VoiceChart.TabIndex = 21;
            this.VoiceChart.Text = "chart1";
            this.VoiceChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VoiceChart_MouseUp);
            // 
            // musicInfo
            // 
            this.musicInfo.BackColor = System.Drawing.Color.Transparent;
            this.musicInfo.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.musicInfo.ForeColor = System.Drawing.Color.White;
            this.musicInfo.Location = new System.Drawing.Point(249, 75);
            this.musicInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.musicInfo.Name = "musicInfo";
            this.musicInfo.Size = new System.Drawing.Size(1646, 88);
            this.musicInfo.TabIndex = 24;
            this.musicInfo.Text = "파일명";
            this.musicInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(23, 710);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 482);
            this.label4.TabIndex = 23;
            this.label4.Text = " 사용자  음성";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(18, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 482);
            this.label3.TabIndex = 22;
            this.label3.Text = "원곡";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(993, 1218);
            this.stopButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(180, 168);
            this.stopButton.TabIndex = 18;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playPauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playPauseButton.BackgroundImage")));
            this.playPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playPauseButton.FlatAppearance.BorderSize = 0;
            this.playPauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPauseButton.Location = new System.Drawing.Point(687, 1218);
            this.playPauseButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(180, 168);
            this.playPauseButton.TabIndex = 17;
            this.playPauseButton.UseVisualStyleBackColor = false;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2553, 1408);
            this.Controls.Add(this.musicInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.VoiceChart);
            this.Controls.Add(this.musicChart);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lyricsTextBox);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "음이탈";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoiceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 곡열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일치율설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 반복구간설정ToolStripMenuItem;
        private System.Windows.Forms.TextBox lyricsTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorFactorLabel;
        private System.Windows.Forms.Label sessionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart musicChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoiceChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label musicInfo;
    }
}


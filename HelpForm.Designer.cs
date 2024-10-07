namespace Interface
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.helpTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // helpListBox
            // 
            this.helpListBox.FormattingEnabled = true;
            this.helpListBox.ItemHeight = 18;
            this.helpListBox.Items.AddRange(new object[] {
            "사용법",
            "오차율 설정",
            "구간반복 설정"});
            this.helpListBox.Location = new System.Drawing.Point(12, 12);
            this.helpListBox.Name = "helpListBox";
            this.helpListBox.Size = new System.Drawing.Size(173, 346);
            this.helpListBox.TabIndex = 0;
            this.helpListBox.SelectedIndexChanged += new System.EventHandler(this.helpListBox_SelectedIndexChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(444, 383);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 47);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "닫기";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // helpTextBox
            // 
            this.helpTextBox.BackColor = System.Drawing.Color.White;
            this.helpTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.helpTextBox.Location = new System.Drawing.Point(206, 12);
            this.helpTextBox.Multiline = true;
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.ReadOnly = true;
            this.helpTextBox.Size = new System.Drawing.Size(348, 346);
            this.helpTextBox.TabIndex = 2;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 442);
            this.Controls.Add(this.helpTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.helpListBox);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox helpListBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox helpTextBox;
    }
}
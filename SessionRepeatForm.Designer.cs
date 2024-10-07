namespace Interface
{
    partial class SessionRepeatForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sessionRepeatTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "구간 반복 시간 :";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(183, 90);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 35);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(26, 90);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(89, 35);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "확인";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "(5초~60초)";
            // 
            // sessionRepeatTextBox
            // 
            this.sessionRepeatTextBox.Location = new System.Drawing.Point(172, 25);
            this.sessionRepeatTextBox.Name = "sessionRepeatTextBox";
            this.sessionRepeatTextBox.Size = new System.Drawing.Size(100, 28);
            this.sessionRepeatTextBox.TabIndex = 6;
            // 
            // SessionRepeatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 137);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sessionRepeatTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "SessionRepeatForm";
            this.Text = "구간반복";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SessionRepeatForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sessionRepeatTextBox;
    }
}
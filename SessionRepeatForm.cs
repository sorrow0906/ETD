using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class SessionRepeatForm : Form
    {
        Form1 mainForm = null;
        public SessionRepeatForm(Form1 mForm)
        {
            InitializeComponent();
            this.mainForm = mForm;

            this.Invalidate();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int session = Convert.ToInt16(sessionRepeatTextBox.Text);

            if (session < 5 || session > 60)
            {
                MessageBox.Show("5~60 까지만 입력 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                mainForm.setSessionRepeat(session);
                this.Close();
            }
        }

        private void SessionRepeatForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
                okButton_Click(sender, e);
        }
    }
}

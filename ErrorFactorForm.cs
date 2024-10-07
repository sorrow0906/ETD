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
    public partial class ErrorFactorForm : Form
    {
        Form1 mainForm = null;

        public ErrorFactorForm(Form1 mForm)
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
            int factor = Convert.ToInt16(errorFactorTextBox.Text);
            if (factor < 1 || factor > 10)
            {
                MessageBox.Show("1~10 까지만 입력 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                mainForm.setErrorFactor(factor);
                this.Close();
            }
        }

        private void ErrorFactorForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
                okButton_Click(sender, e);
        }
    }
}

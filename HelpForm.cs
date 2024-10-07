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
    public partial class HelpForm : Form
    {
        string [] howToUse = { "1. 파일 메뉴의 곡열기(혹은 Ctrl + F)를 선택합니다."
                             , "2. 부르고 싶은 노래의 MP3 파일을 선택합니다."
                             , "3. 노래 분석이 완료되면, 재생 버튼을 누른 뒤 노래를 부릅니다."
                             , "4. 노래가 끝나고 나면 목소리를 분석하여 보여주고, 틀린부분을 표시합니다." };
        string [] howToError = { "1. 설정 메뉴의 오차율 설정(혹은 Ctrl + E)를 선택합니다."
                               , "2. 오차율을 1~10 사이의 숫자로 입력합니다."
                               , "3. 확인(혹은 Enter)을 누르면 입력한 오차율로 변경됩니다." };
        string [] howToRepeat = { "1. 아직몰라용"
                                , "2. 미정이요"};
        public HelpForm()
        {
            InitializeComponent();
            helpTextBox.ScrollBars = ScrollBars.Vertical;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = helpListBox.Text;
            if (str.Equals("사용법"))
                helpTextBox.Lines = howToUse;

            else if (str.Equals("오차율 설정"))
                helpTextBox.Lines = howToError;

            else if (str.Equals("구간반복 설정"))
                helpTextBox.Lines = howToRepeat;

            else
                helpTextBox.Text = "";
        }
    }
}
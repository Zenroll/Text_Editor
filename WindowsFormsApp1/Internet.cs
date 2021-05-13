using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Internet : Form
    {
        public Internet()
        {
            InitializeComponent();
            toolStrip1.AutoSize = false;
        }

        private void GoBack_Click(object sender, EventArgs e) //뒤로가기
        {
            webBrowser1.GoBack();
        }

        private void GoFoward_Click(object sender, EventArgs e) //앞으로가기
        {
            webBrowser1.GoForward();
        }

        private void Go_Click(object sender, EventArgs e) //이동
        {
            webBrowser1.Navigate(URLTextBox.Text);
        }


        //버튼 링크
        private void naver_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://naver.com");
        }

        private void google_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://google.com");
        }

        private void daum_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://daum.com");
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtube.com");
        }

        
    }
}

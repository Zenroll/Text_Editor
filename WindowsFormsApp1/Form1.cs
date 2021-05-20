using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
       
        System.Drawing.FontStyle newFontStyle;
        int font_size = 10;
        string fo = "";
        string[] copy_list = { };
        public Form1()
        {

            InitializeComponent();

            //폰트 크기 add
            for (var i = 1; i < 30; i++)
            {
                comboBox1.Items.Add(i);
            }

            //폰트 add
            FontFamily[] ffArray = FontFamily.Families;
            foreach (FontFamily ff in ffArray)
            {
                FontCombo1.Items.Add(ff.Name);
            }
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //글꼴 I B U C클릭

        //기울임
        private void Italic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic == true)
            {
                Italic.BorderStyle = BorderStyle.None;
            }

            if (richTextBox1.SelectionFont.Italic == false)
            {
                Italic.BorderStyle = BorderStyle.Fixed3D;
            }

            int number = 1;

            number = richTextBox1.SelectionFont.Italic ? 1 : 2;

            number *= richTextBox1.SelectionFont.Bold ? 3 : 1;

            number *= richTextBox1.SelectionFont.Strikeout ? 5 : 1;

            number *= richTextBox1.SelectionFont.Underline ? 7 : 1;



            switch (number)

            {

                case 1: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular); break;

                case 2: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic); break;

                case 3: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold); break;

                case 5: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout); break;

                case 7: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline); break;



                case 6: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Bold); break;

                case 10: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout); break;

                case 14: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Underline); break;

                case 15: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Strikeout); break;

                case 21: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;

                case 35: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Underline); break;



                case 30: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Bold | FontStyle.Strikeout); break;

                case 42: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline); break;

                case 70: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline); break;

                case 105: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline); break;



                case 210: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline); break;



            }
        }

        //굵게
        private void Bold_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionFont.Bold == true)
            {
                Bold.BorderStyle = BorderStyle.None;
            }

            if (richTextBox1.SelectionFont.Bold == false)
            {
                Bold.BorderStyle = BorderStyle.Fixed3D;
            }
            int number = 1;

            number = richTextBox1.SelectionFont.Bold ? 1 : 2;

            number *= richTextBox1.SelectionFont.Italic ? 3 : 1;

            number *= richTextBox1.SelectionFont.Strikeout ? 5 : 1;

            number *= richTextBox1.SelectionFont.Underline ? 7 : 1;



            switch (number)

            {

                case 1: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular); break;

                case 2: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold); break;

                case 3: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic); break;

                case 5: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout); break;

                case 7: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline); break;



                case 6: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic); break;

                case 10: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Strikeout); break;

                case 14: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;

                case 15: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout); break;

                case 21: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Underline); break;

                case 35: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Underline); break;



                case 30: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout); break;

                case 42: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;

                case 70: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline); break;

                case 105: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline); break;



                case 210: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline); break;



            }
        }

        //밑줄
        private void Underline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline == true)
            {
                Underline.BorderStyle = BorderStyle.None;
            }

            if (richTextBox1.SelectionFont.Underline == false)
            {
                Underline.BorderStyle = BorderStyle.Fixed3D;
            }
            int number = 1;

            number = richTextBox1.SelectionFont.Underline ? 1 : 2;

            number *= richTextBox1.SelectionFont.Italic ? 3 : 1;

            number *= richTextBox1.SelectionFont.Strikeout ? 5 : 1;

            number *= richTextBox1.SelectionFont.Bold ? 7 : 1;



            switch (number)

            {

                case 1: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular); break;

                case 2: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline); break;

                case 3: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic); break;

                case 5: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout); break;

                case 7: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold); break;



                case 6: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Italic); break;

                case 10: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Strikeout); break;

                case 14: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Bold); break;

                case 15: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout); break;

                case 21: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Bold); break;

                case 35: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout | FontStyle.Bold); break;



                case 30: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Italic | FontStyle.Strikeout); break;

                case 42: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Italic | FontStyle.Bold); break;

                case 70: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Strikeout | FontStyle.Bold); break;

                case 105: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic | FontStyle.Strikeout | FontStyle.Bold); break;



                case 210: richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Bold); break;

            }
        }

        //글자 색 변경
        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            colorDialog1.Color = richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               colorDialog1.Color != richTextBox1.SelectionColor)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }



        //파일
        private void FileSaveBox_Click(object sender, EventArgs e) //저장하기
        {
            //피드백 : 이 앱만의 고유한 확장자명 지정
            saveFileDialog1.Filter = "텍스트파일|*.te";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void FileLoadBox_Click(object sender, EventArgs e)  // 불러오기
        {
            //피드백 : 이 앱만의 고유한 확장자명 지정
            openFileDialog1.Filter = "텍스트파일|*.te";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);

                richTextBox1.Text = sr.ReadToEnd();

                sr.Close();
            }
        }

        private void NewTextBox_Click(object sender, EventArgs e)  //새로 만들기
        {
            if (richTextBox1.TextLength > 0)
            {
                //기존 richTextBox를 사용했을 시 저장 여부
                DialogResult result = MessageBox.Show(this.Text + "파일의 내용이 변경되었습니다." + Environment.NewLine + Environment.NewLine
                    + "변경된 내용을 저장하시겠습니까?", "저장 확인", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        FileSaveBox_Click(sender, e);
                        richTextBox1.Text = "";
                        break;
                    case DialogResult.No:
                        richTextBox1.Text = "";
                        break;
                    case DialogResult.Cancel:
                        richTextBox1.Text = richTextBox1.Text;
                        break;
                }
            }
           
        }
        //복사한 목록
        int num = 0;
        private void CopyBox_Click(object sender, EventArgs e) 
        {

            num++;
            string num3 = num.ToString();
           
            richTextBox1.Copy();
            richTextBox2.AppendText(num3 + ". ");
            richTextBox1.Copy();
            richTextBox2.Paste();
            richTextBox2.AppendText(Environment.NewLine);
        }

        //붙여넣기
        private void PasteBox_Click(object sender, EventArgs e)  
        {
            richTextBox1.Paste();
        }
        
        //글자크기 변경
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
 
            int a = comboBox1.SelectedIndex - 1;
            font_size = a;
            richTextBox1.SelectionFont = new Font(currentFont.Name, a, currentFont.Style);
            

        }
        
        //글꼴 변경
        private void FontCombo1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;


            string b = FontCombo1.SelectedItem.ToString();
                
            richTextBox1.SelectionFont = new Font(b, currentFont.Size , currentFont.Style);
            fo = FontCombo1.SelectedItem.ToString();
        }

        //글 머리 기호
        int count = 0;
        private void Bullet_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 1)
            {
                richTextBox1.SelectionBullet = true;
                Bullet.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                richTextBox1.SelectionBullet = false;
                Bullet.BorderStyle = BorderStyle.None;
            }
        }

        //정렬
        private void LeftAlign_Click(object sender, EventArgs e) //왼쪽 정렬
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterAlign_Click(object sender, EventArgs e) //가운데 정렬
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightAlign_Click(object sender, EventArgs e) //오른쪽 정렬
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Justify_Click(object sender, EventArgs e) //양쪽 정렬(구현 안됨 : 왼쪽 정렬로 대체)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }



        //복사목록 내용 복사
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Copy();
        }

        //툴팁
        private void Form1_Load(object sender, EventArgs e)
        {
            //파일
            toolTip1.SetToolTip(NewTextBox, "새로 만들기\nCtrl+N");
            toolTip1.SetToolTip(FileSaveBox, "저장\nCtrl+S");
            toolTip1.SetToolTip(FileLoadBox, "불러오기\nAlt+O");
            toolTip1.SetToolTip(CopyBox, "복사\nCtrl+C");
            toolTip1.SetToolTip(PasteBox, "붙여넣기\nCtrl+V");
            //글꼴
            toolTip1.SetToolTip(Italic, "기울임\nCtrl+I");
            toolTip1.SetToolTip(Bold, "굵게\nCtrl+B");
            toolTip1.SetToolTip(Underline, "밑줄\nCtrl+B");
            toolTip1.SetToolTip(Color, "글자 색\nCtrl+Shift+C");
            //단락
            toolTip1.SetToolTip(Bullet, "글 머리 기호");
            toolTip1.SetToolTip(Left_Align, "왼쪽 정렬\nCtrl+L");
            toolTip1.SetToolTip(Center_Align, "가운데 정렬\nCtrl+E");
            toolTip1.SetToolTip(Right_Align, "오른쪽 정렬\nCtrl+R");
            toolTip1.SetToolTip(Justify, "양쪽 정렬\nCtrl+Shift+J");
        }


        //클릭 효과 정의
        private void NewTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            NewTextBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void NewTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            NewTextBox.BorderStyle = BorderStyle.None;
        }

        private void FileSaveBox_MouseDown(object sender, MouseEventArgs e)
        {
            FileSaveBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void FileSaveBox_MouseUp(object sender, MouseEventArgs e)
        {
            FileSaveBox.BorderStyle = BorderStyle.None;
        }

        private void FileLoadBox_MouseDown(object sender, MouseEventArgs e)
        {
            FileLoadBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void FileLoadBox_MouseUp(object sender, MouseEventArgs e)
        {
            FileLoadBox.BorderStyle = BorderStyle.None;
        }

        private void CopyBox_MouseDown(object sender, MouseEventArgs e)
        {
            CopyBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void CopyBox_MouseUp(object sender, MouseEventArgs e)
        {
            CopyBox.BorderStyle = BorderStyle.None;
        }

        private void PasteBox_MouseDown(object sender, MouseEventArgs e)
        {
            PasteBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PasteBox_MouseUp(object sender, MouseEventArgs e)
        {
            PasteBox.BorderStyle = BorderStyle.None;
        }

        private void Color_MouseDown(object sender, MouseEventArgs e)
        {
            Color.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Color_MouseUp(object sender, MouseEventArgs e)
        {
            Color.BorderStyle = BorderStyle.None;
        }

        private void Left_Align_MouseUp(object sender, MouseEventArgs e)
        {
            Left_Align.BorderStyle = BorderStyle.None;
        }
        private void Left_Align_MouseDown(object sender, MouseEventArgs e)
        {
            Left_Align.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Center_Align_MouseUp(object sender, MouseEventArgs e)
        {
            Center_Align.BorderStyle = BorderStyle.None;
        }

        private void Center_Align_MouseDown(object sender, MouseEventArgs e)
        {
            Center_Align.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Right_Align_MouseUp(object sender, MouseEventArgs e)
        {
            Right_Align.BorderStyle = BorderStyle.None;
        }

        private void Right_Align_MouseDown(object sender, MouseEventArgs e)
        {
            Right_Align.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Justify_MouseUp(object sender, MouseEventArgs e)
        {
            Justify.BorderStyle = BorderStyle.None;
        }

        private void Justify_MouseDown(object sender, MouseEventArgs e)
        {
            Justify.BorderStyle = BorderStyle.Fixed3D;
        }

        //글꼴 스크롤 바
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
      
            int a = vScrollBar1.Value;
            font_size = a;
            richTextBox1.SelectionFont = new Font(currentFont.Name, a, currentFont.Style);
            toolTip1.SetToolTip(vScrollBar1, vScrollBar1.Value.ToString());
        }

    }
}
       
  

namespace WindowsFormsApp1
{
    partial class Internet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Internet));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GoBack = new System.Windows.Forms.ToolStripButton();
            this.GoFoward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.URLTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Go = new System.Windows.Forms.ToolStripButton();
            this.naver = new System.Windows.Forms.ToolStripButton();
            this.google = new System.Windows.Forms.ToolStripButton();
            this.daum = new System.Windows.Forms.ToolStripButton();
            this.youtube = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoBack,
            this.GoFoward,
            this.toolStripSeparator1,
            this.URLTextBox,
            this.Go,
            this.naver,
            this.google,
            this.daum,
            this.youtube});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // GoBack
            // 
            this.GoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoBack.Image = global::WindowsFormsApp1.Properties.Resources.goback;
            this.GoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(29, 24);
            this.GoBack.Text = "뒤로가기";
            this.GoBack.ToolTipText = "뒤로가기";
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // GoFoward
            // 
            this.GoFoward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoFoward.Image = global::WindowsFormsApp1.Properties.Resources.gofront;
            this.GoFoward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoFoward.Name = "GoFoward";
            this.GoFoward.Size = new System.Drawing.Size(29, 24);
            this.GoFoward.Text = "앞으로가기";
            this.GoFoward.Click += new System.EventHandler(this.GoFoward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(400, 27);
            this.URLTextBox.ToolTipText = "주소를 입력하세요";
            // 
            // Go
            // 
            this.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Go.Image = ((System.Drawing.Image)(resources.GetObject("Go.Image")));
            this.Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(43, 24);
            this.Go.Text = "이동";
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // naver
            // 
            this.naver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.naver.Image = global::WindowsFormsApp1.Properties.Resources.네이버_아이콘;
            this.naver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.naver.Name = "naver";
            this.naver.Size = new System.Drawing.Size(29, 24);
            this.naver.Text = "toolStripButton4";
            this.naver.ToolTipText = "네이버";
            this.naver.Click += new System.EventHandler(this.naver_Click);
            // 
            // google
            // 
            this.google.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.google.Image = global::WindowsFormsApp1.Properties.Resources.구글_아이콘;
            this.google.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(29, 24);
            this.google.Text = "toolStripButton5";
            this.google.ToolTipText = "구글";
            this.google.Click += new System.EventHandler(this.google_Click);
            // 
            // daum
            // 
            this.daum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.daum.Image = global::WindowsFormsApp1.Properties.Resources.다음_아이콘;
            this.daum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.daum.Name = "daum";
            this.daum.Size = new System.Drawing.Size(29, 24);
            this.daum.Text = "toolStripButton1";
            this.daum.ToolTipText = "다음";
            this.daum.Click += new System.EventHandler(this.daum_Click);
            // 
            // youtube
            // 
            this.youtube.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.youtube.Image = global::WindowsFormsApp1.Properties.Resources.유튜브_아이콘;
            this.youtube.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(29, 24);
            this.youtube.Text = "toolStripButton2";
            this.youtube.ToolTipText = "유튜브";
            this.youtube.Click += new System.EventHandler(this.youtube_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 423);
            this.webBrowser1.TabIndex = 1;
            // 
            // Internet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Internet";
            this.Text = "Internet";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton GoBack;
        private System.Windows.Forms.ToolStripButton GoFoward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox URLTextBox;
        private System.Windows.Forms.ToolStripButton Go;
        private System.Windows.Forms.ToolStripButton naver;
        private System.Windows.Forms.ToolStripButton google;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton daum;
        private System.Windows.Forms.ToolStripButton youtube;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
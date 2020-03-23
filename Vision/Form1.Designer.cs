namespace Vision
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxIpl2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_Live = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBoxIpl3 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(160, 65);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(1200, 900);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 33;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_save.Location = new System.Drawing.Point(1554, 221);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 100);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Capture";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 20F);
            this.button2.Location = new System.Drawing.Point(1554, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "확대";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 20F);
            this.button3.Location = new System.Drawing.Point(1554, 715);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "축소";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxIpl2
            // 
            this.pictureBoxIpl2.Location = new System.Drawing.Point(160, 65);
            this.pictureBoxIpl2.Name = "pictureBoxIpl2";
            this.pictureBoxIpl2.Size = new System.Drawing.Size(1200, 900);
            this.pictureBoxIpl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl2.TabIndex = 4;
            this.pictureBoxIpl2.TabStop = false;
            this.pictureBoxIpl2.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBoxIpl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBoxIpl2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBoxIpl2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 20F);
            this.button1.Location = new System.Drawing.Point(1554, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 5;
            this.button1.Text = "원본";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_del.Location = new System.Drawing.Point(1554, 865);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(200, 100);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "삭제";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_Live
            // 
            this.btn_Live.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_Live.Location = new System.Drawing.Point(1554, 71);
            this.btn_Live.Name = "btn_Live";
            this.btn_Live.Size = new System.Drawing.Size(200, 100);
            this.btn_Live.TabIndex = 7;
            this.btn_Live.Text = "Live";
            this.btn_Live.UseVisualStyleBackColor = true;
            this.btn_Live.Click += new System.EventHandler(this.btn_Live_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1554, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "흑백";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBoxIpl3
            // 
            this.pictureBoxIpl3.Location = new System.Drawing.Point(160, 65);
            this.pictureBoxIpl3.Name = "pictureBoxIpl3";
            this.pictureBoxIpl3.Size = new System.Drawing.Size(1200, 900);
            this.pictureBoxIpl3.TabIndex = 9;
            this.pictureBoxIpl3.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1679, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "최대화";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1916, 1041);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBoxIpl3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Live);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxIpl2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Timer timer1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_Live;
        private System.Windows.Forms.Button button4;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl3;
        private System.Windows.Forms.Button button5;
    }
}


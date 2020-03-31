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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Expand = new System.Windows.Forms.Button();
            this.btn_Shrink = new System.Windows.Forms.Button();
            this.pictureBoxIpl2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.btn_Origin = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_Live = new System.Windows.Forms.Button();
            this.btn_BnW = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.pictureBoxIpl4 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 120;
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
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_save.Location = new System.Drawing.Point(1554, 198);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 100);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Capture";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Expand
            // 
            this.btn_Expand.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_Expand.Location = new System.Drawing.Point(1554, 565);
            this.btn_Expand.Name = "btn_Expand";
            this.btn_Expand.Size = new System.Drawing.Size(200, 100);
            this.btn_Expand.TabIndex = 2;
            this.btn_Expand.Text = "확대";
            this.btn_Expand.UseVisualStyleBackColor = true;
            this.btn_Expand.Click += new System.EventHandler(this.btn_Expand_Click);
            // 
            // btn_Shrink
            // 
            this.btn_Shrink.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_Shrink.Location = new System.Drawing.Point(1554, 715);
            this.btn_Shrink.Name = "btn_Shrink";
            this.btn_Shrink.Size = new System.Drawing.Size(200, 100);
            this.btn_Shrink.TabIndex = 3;
            this.btn_Shrink.Text = "축소";
            this.btn_Shrink.UseVisualStyleBackColor = true;
            this.btn_Shrink.Click += new System.EventHandler(this.btn_Shrink_Click);
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
            // btn_Origin
            // 
            this.btn_Origin.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_Origin.Location = new System.Drawing.Point(1554, 415);
            this.btn_Origin.Name = "btn_Origin";
            this.btn_Origin.Size = new System.Drawing.Size(200, 100);
            this.btn_Origin.TabIndex = 5;
            this.btn_Origin.Text = "원본";
            this.btn_Origin.UseVisualStyleBackColor = true;
            this.btn_Origin.Click += new System.EventHandler(this.btn_Origin_Click);
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
            this.btn_Live.Location = new System.Drawing.Point(1554, 65);
            this.btn_Live.Name = "btn_Live";
            this.btn_Live.Size = new System.Drawing.Size(200, 100);
            this.btn_Live.TabIndex = 7;
            this.btn_Live.Text = "Live";
            this.btn_Live.UseVisualStyleBackColor = true;
            this.btn_Live.Click += new System.EventHandler(this.btn_Live_Click);
            // 
            // btn_BnW
            // 
            this.btn_BnW.Location = new System.Drawing.Point(1554, 333);
            this.btn_BnW.Name = "btn_BnW";
            this.btn_BnW.Size = new System.Drawing.Size(75, 23);
            this.btn_BnW.TabIndex = 8;
            this.btn_BnW.Text = "흑백";
            this.btn_BnW.UseVisualStyleBackColor = true;
            this.btn_BnW.Visible = false;
            // 
            // btn_Max
            // 
            this.btn_Max.Location = new System.Drawing.Point(1554, 362);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(75, 23);
            this.btn_Max.TabIndex = 10;
            this.btn_Max.Text = "최대화";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Visible = false;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(1554, 304);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 11;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Visible = false;
            // 
            // pictureBoxIpl4
            // 
            this.pictureBoxIpl4.Location = new System.Drawing.Point(160, 65);
            this.pictureBoxIpl4.Name = "pictureBoxIpl4";
            this.pictureBoxIpl4.Size = new System.Drawing.Size(1200, 900);
            this.pictureBoxIpl4.TabIndex = 12;
            this.pictureBoxIpl4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(642, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1916, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxIpl4);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.btn_BnW);
            this.Controls.Add(this.btn_Live);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_Origin);
            this.Controls.Add(this.pictureBoxIpl2);
            this.Controls.Add(this.btn_Shrink);
            this.Controls.Add(this.btn_Expand);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Timer timer1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Expand;
        private System.Windows.Forms.Button btn_Shrink;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl2;
        private System.Windows.Forms.Button btn_Origin;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_Live;
        private System.Windows.Forms.Button btn_BnW;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_find;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


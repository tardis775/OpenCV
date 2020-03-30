using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using Point = System.Drawing.Point;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp.CPlusPlus;

namespace Vision
{
    public partial class Form1 : Form
    {
        #region 전역 변수
        private Point pntCurrentPicbox;
        private Point pntMouseClick;

        private bool bIsClick = false;

        int nPictureBoxX;
        int nPictureBoxY;
        string now;

        Bitmap bmp;
        CvCapture capture;
        IplImage src;
        IplImage ipl;
        IplImage canny;
        IplImage match;

        #region 참고

        //private Point imgPoint;
        //private Point LastPoint;
        //private Bitmap img;
        //private Rectangle imgRect;
        //private Point clickPoint;

        //private double ratio = 1.0F;

        //IplImage zoom;

        #endregion
        #endregion

        #region Form Load
        public Form1()
        {
            InitializeComponent();
            pictureBoxIpl1.BringToFront();
            Enabled_false();
            #region 참고
            //imgPoint = new Point(pictureBoxIpl2.Width / 2, pictureBoxIpl2.Height / 2);

            //ratio = 1.0;
            //clickPoint = imgPoint;

            //pictureBoxIpl2.Invalidate();
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                capture = CvCapture.FromCamera(CaptureDevice.DShow, 0);
                capture.SetCaptureProperty(CaptureProperty.FrameWidth, 1320);
                capture.SetCaptureProperty(CaptureProperty.FrameHeight, 990); 
            }
            catch
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            src = capture.QueryFrame();
            //if (src != null) Cv.ReleaseImage(src);
            Cv.Flip(src, src, FlipMode.Y);

            pictureBoxIpl1.ImageIpl = src;

            if(pictureBoxIpl2.ImageIpl != null)
            {
                pictureBoxIpl2.BringToFront();
            }
            else
            {
                TrySearch();

                pictureBoxIpl4.ImageIpl = match;
                pictureBoxIpl4.BringToFront();
                pictureBox1.BringToFront();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cv.ReleaseImage(src);

            if (src != null) src.Dispose();
        }
        #endregion
        
        #region Live 버튼
        private void btn_Live_Click(object sender, EventArgs e)
        {
            pictureBoxIpl1.BringToFront();
            Enabled_false();
        }
        #endregion

        #region 캡처이미지 저장 버튼
        private void btn_save_Click(object sender, EventArgs e)
        {
            string save_name = DateTime.Now.ToString("yy.MM.dd_hhmmss");

            now = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

            Cv.SaveImage("../capture/" + save_name + ".png", src);

            ipl = new IplImage("../capture/" + save_name + ".png", LoadMode.AnyColor);

            pictureBoxIpl2.ImageIpl = ipl;

            pntCurrentPicbox.X = 0;
            pntCurrentPicbox.Y = 0;

            //pictureBoxIpl2.BringToFront();

            Enabled_true();
            //MessageBox.Show("사진을 저장했습니다.");
        }
        #endregion

        #region 캡처이미지 삭제 버튼
        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                //삭제할 파일들이 있는 경로 설정
                string deletePath = (@"../capture/");
                DirectoryInfo di = new DirectoryInfo(deletePath);

                //삭제할 경로에 파일이 존재한다면
                if (di.Exists)
                {
                    FileInfo[] files = di.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        //날짜비교
                        if (now.CompareTo(file.LastWriteTime.ToString("yyyy-MM-ddTHH:mm:ss")) == 0)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(file.Name, ".png"))
                            {
                                File.Delete(di + "\\" + file.Name);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            pictureBoxIpl2.ImageIpl = null;
            pictureBoxIpl1.BringToFront();

            Enabled_false();
        }
        #endregion

        #region 캡처이미지 흑백 버튼
        //이벤트 등록해야함
        //private void button4_Click(object sender, EventArgs e)
        //{
        //    pictureBoxIpl2.ImageIpl = CannyEdge(pictureBoxIpl2.ImageIpl);
        //    pictureBoxIpl2.BringToFront();
        //}
        //public IplImage CannyEdge(IplImage src)
        //{
        //    canny = new IplImage(src.Size, BitDepth.U8, 1);
        //    Cv.Canny(src, canny, 100, 255);
        //    return canny;
        //}
        #endregion

        #region 캡처이미지 추출 버튼
        //find 버튼 이벤트 활성화
        //private void btn_find_Click(object sender, EventArgs e)
        //{
        //    //Mat Screen = null;
        //    TrySearch();
        //    //if (match != null) Cv.ReleaseImage(match);
        //    pictureBoxIpl4.ImageIpl = match;
        //    pictureBoxIpl4.BringToFront();
        //}
        public IplImage TrySearch()
        {
            match = pictureBoxIpl1.ImageIpl;

            IplImage templit = new IplImage("../capture/추출.png", LoadMode.AnyColor); ;
            IplImage tm = new IplImage(new CvSize(match.Size.Width - templit.Size.Width + 1, match.Size.Height - templit.Size.Height + 1), BitDepth.F32, 1);

            CvPoint minloc, maxloc;
            Double minval, maxval;

            Cv.MatchTemplate(match, templit, tm, MatchTemplateMethod.SqDiffNormed);
            Cv.MinMaxLoc(tm, out minval, out maxval, out minloc, out maxloc);
            Cv.DrawRect(match, new CvRect(minloc.X, minloc.Y, templit.Width, templit.Height), CvColor.Red, 3);

            if (pictureBoxIpl1.Image != null)
            {
                Bitmap croppedBitmap = new Bitmap(pictureBoxIpl1.Image);
                croppedBitmap = croppedBitmap.Clone(
                        new Rectangle(minloc.X, minloc.Y, templit.Width, templit.Height),
                        System.Drawing.Imaging.PixelFormat.DontCare);
                pictureBox1.Image = croppedBitmap;
            }

            Image img = pictureBoxIpl1.Image;

            bmp = img as Bitmap;

            Color pixelColor = bmp.GetPixel(600, 450);

            pictureBox1.BackColor = pixelColor;

            return match;

            #region 참고
            //Mat screen = null, find = null ,res = null;
            //try
            //{
            //    screen = OpenCvSharp.Extensions.BitmapConverter.ToMat((Bitmap)pictureBoxIpl2.Image);
            //    find = OpenCvSharp.Extensions.BitmapConverter.ToMat(new Bitmap(System.Windows.Forms.Application.StartupPath + @"\../capture/추출.png"));

            //    //이미지 유사도 찾기
            //    res = screen.MatchTemplate(find, MatchTemplateMethod.CCoeffNormed);
            //    double min, max = 0;
            //    //최소, 최대값 리턴
            //    Cv2.MinMaxLoc(res, out min, out max);

            //    Console.WriteLine("검색 유사도 : " + max);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message.ToString());
            //}
            //finally
            //{
            //    screen.Dispose();
            //    find.Dispose();
            //    res.Dispose();
            //}
            #endregion
        }
        #endregion

        #region 캡처이미지 원본 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxIpl2.ImageIpl = ipl;
            pntCurrentPicbox.X = 0;
            pntCurrentPicbox.Y = 0;
        }
        #endregion
        
        #region 캡처이미지 확대 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            Image img = pictureBoxIpl2.Image;
            Bitmap bmpMod = new Bitmap((img.Width * 5)/4, img.Height * 5 / 4);

            Graphics g = Graphics.FromImage(bmpMod);

            g.DrawImage(img, 0, 0, bmpMod.Width, bmpMod.Height);
            g.Dispose();

            pictureBoxIpl2.Image = bmpMod;
            
            #region 참고
            //------------------------------------------------------------------------------------------------
            //Bitmap bit = (Bitmap)pictureBoxIpl2.Image;
            //Bitmap temp = new Bitmap(bit.Width, bit.Height, bit.PixelFormat);

            ////double dZoom = 1.25;
            //Graphics gr = Graphics.FromImage(temp);

            //gr.DrawImage(bit, new RectangleF(0, 0, (float)(bit.Width * dZoom), (float)(bit.Height * dZoom)),
            //        new RectangleF(0, 0, bit.Width, bit.Height), GraphicsUnit.Pixel);

            //pictureBoxIpl2.Image = temp;
            //------------------------------------------------------------------------------------------------
            //pictureBoxIpl2.ImageIpl = ipl;

            //zoom = new IplImage(Cv.Size(ipl.Width * 2, src.Height * 2), BitDepth.U8, 3);
            //Cv.PyrUp(src, zoom, CvFilter.Gaussian5x5);

            //pictureBoxIpl2.ImageIpl = zoom;
            #endregion
        }
        #endregion

        #region 캡처이미지 축소 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            Image img = pictureBoxIpl2.Image;
            Bitmap bmpmod = new Bitmap(img.Width / 5 * 4, img.Height / 5 * 4);
            Graphics g = Graphics.FromImage(bmpmod);

            g.DrawImage(img, 0, 0, bmpmod.Width, bmpmod.Height);
            g.Dispose();

            pictureBoxIpl2.Image = bmpmod;

            #region 참고
            //-------------------------------------------------------------------------------------------------
            //Bitmap bit = (Bitmap)pictureBoxIpl2.Image;
            //Bitmap temp = new Bitmap(bit.Width, bit.Height, bit.PixelFormat);

            //double dZoom = 0.75;
            //Graphics gr = Graphics.FromImage(temp);
            //gr.DrawImage(bit, new RectangleF(0, 0, (float)(bit.Width * dZoom), (float)(bit.Height * dZoom)),
            //        new RectangleF(0, 0, bit.Width, bit.Height), GraphicsUnit.Pixel);

            //pictureBoxIpl2.Image = temp;
            //-------------------------------------------------------------------------------------------------
            //pictureBoxIpl2.ImageIpl = ipl;

            //zoom = new IplImage(Cv.Size(ipl.Width / 2, ipl.Height / 2), BitDepth.U8, 3);
            //Cv.PyrDown(ipl, zoom, CvFilter.Gaussian5x5);

            //pictureBoxIpl2.ImageIpl = zoom;            
            #endregion
        }
        #endregion
        
        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        #region 캡처이미지 이동
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxIpl2.Image != null)
            {
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawImage(pictureBoxIpl2.Image, pntCurrentPicbox);
                pictureBoxIpl2.Focus();
            }
        }
                
        #region 이미지 이동 클릭 Down
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bIsClick = true;

            pntMouseClick.X = e.X;
            pntMouseClick.Y = e.Y;
        }
        #endregion

        #region 이미지 이동 드래그
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bIsClick)
            {
                pntCurrentPicbox.X = pntCurrentPicbox.X + e.X - pntMouseClick.X;
                pntCurrentPicbox.Y = pntCurrentPicbox.Y + e.Y - pntMouseClick.Y;
                
                if (pntCurrentPicbox.X > 0)
                {
                    pntCurrentPicbox.X = 0;
                }
                if (pntCurrentPicbox.Y > 0)
                {
                    pntCurrentPicbox.Y = 0;
                }

                if (pntCurrentPicbox.X + pictureBoxIpl2.Image.Width < nPictureBoxX)
                {
                    pntCurrentPicbox.X = nPictureBoxX - pictureBoxIpl2.Image.Width;
                }
                if (pntCurrentPicbox.Y + pictureBoxIpl2.Image.Height < nPictureBoxY)
                {
                    pntCurrentPicbox.Y = nPictureBoxY - pictureBoxIpl2.Image.Height;
                }

                pntMouseClick = e.Location;

                pictureBoxIpl2.Invalidate();
            }
        }
        #endregion

        #region 이미지 이동 클릭 Up
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            bIsClick = false;
        }
        #endregion

        #endregion

        #region Enabled_false
        private void Enabled_false()
        {
            btn_del.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        #endregion

        #region Enabled_true
        private void Enabled_true()
        {
            btn_del.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

                if (FormBorderStyle == FormBorderStyle.Sizable)
                {
                    FormBorderStyle = FormBorderStyle.None;
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                }
        }
        #endregion

        //-------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
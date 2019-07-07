using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileViewer
{
    public partial class Form1 : Form
    {
        public Point loc;
        Graphics g;
        Graphics g1;
        Image img;
        Point pos = new Point(0,0);
        Image bmp;
        string path = "C:\\";
        public Form1()
        {
            InitializeComponent();
            g = side_pnl.CreateGraphics();
            g1 = top_pnl.CreateGraphics();
            img = FileViewer.Properties.Resources._20180827_155533;
            var tmph = img.Size.Height;
            var tmpyw = img.Size.Width;
            int h = (int)(((float)Screen.GetBounds(new Point(this.Left, this.Top)).Width / (float)tmpyw)*tmph);
            int w = (int)Screen.GetBounds(new Point(this.Left, this.Top)).Width ;

            
            bmp = new Bitmap(Blur(new Bitmap(img, new Size(w/10,h/10) ),4), new Size(w,h));
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = System.IO.Directory.GetCurrentDirectory();
            path_tb.Text = path.Replace("\\", ">");
            List<string> ts = DirSearch(path);
            
            foreach (string s in ts)
            {
                
                browser_lv.Items.Add(Path.GetFileName(s), 0);

            }

        }
        public static List<String> DirSearch(string sDir)
        {
            List<String> files = new List<String>();

            foreach (string f in Directory.GetFiles(sDir))
            {
                try
                {
                    
                    files.Add(f);
                }
                catch (Exception e)
                {

                    //System.Windows.Forms.MessageBox.Show("Access denied");
                }

            }
            foreach (string d in Directory.GetDirectories(sDir))
            {
                try
                {
                    //files.AddRange(DirSearch(d));
                    files.Add(d);
                }
                catch (Exception)
                {

                    //System.Windows.Forms.MessageBox.Show("access denied");
                }

            }
            return files;

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            pos = new Point(-this.Left, -this.Top);
            //label1.Text = pos.ToString()+Screen.GetBounds(new Point(this.Left,this.Top)).ToString();
            g.DrawImage(bmp, pos.X, pos.Y);
            g1.DrawImage(bmp, pos.X, pos.Y);
            g1.FillRectangle(new SolidBrush(Color.FromArgb(128, 0, 0, 0)), new Rectangle(0, 0, top_pnl.Width, top_pnl.Height));
            g1.DrawString("FileViewer", top_pnl.Font,Brushes.White, new Point(0, 0));
        }


        private void test_1_Resize(object sender, EventArgs e)
        {
            g = side_pnl.CreateGraphics();
        }
        private static Bitmap Blur(Bitmap image, Int32 blurSize)
        {
            return Blur(image, new Rectangle(0, 0, image.Width, image.Height), blurSize);
        }

        private static Bitmap Blur(Bitmap image, Rectangle rectangle, Int32 blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the blur rectangle
            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (int x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (int y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (int x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                        for (int y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }

        private void side_pnl_Resize(object sender, EventArgs e)
        {
            g = side_pnl.CreateGraphics();
            g1 = top_pnl.CreateGraphics();
        }

        private void side_pnl_SizeChanged(object sender, EventArgs e)
        {
            g = side_pnl.CreateGraphics();
            g1 = top_pnl.CreateGraphics();
        }

        private void top_pnl_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImage(bmp, pos.X, pos.Y);
            g1.DrawImage(bmp, pos.X, pos.Y);
            g1.FillRectangle(new SolidBrush(Color.FromArgb(128, 0, 0, 0)), new Rectangle(0, 0, top_pnl.Width, top_pnl.Height));
            g1.DrawString("FileViewer", top_pnl.Font, Brushes.White, new Point(0, 0));
        }

        private void top_pnl_MouseDown(object sender, MouseEventArgs e)
        {
            loc = e.Location;
        }

        private void top_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - loc.X), this.Location.Y + (e.Location.Y - loc.Y));
            }
        }

        private void mini_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void max_btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState== FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                max_btn.Text = ">-<";
            }else
            {
                this.WindowState = FormWindowState.Normal;
                max_btn.Text = "<->";
            }
            g = side_pnl.CreateGraphics();
            g1 = top_pnl.CreateGraphics();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void path_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                path = path_tb.Text.Replace(">", "\\");
                List<string> ts = DirSearch(path);

                foreach (string s in ts)
                {

                    browser_lv.Items.Add(Path.GetFileName(s), 0);

                }
            }
        }

        private void cmd_btn_Click(object sender, EventArgs e)
        {
            Process.Start("cmd","/k "+path[0]+path[1]+" && cd "+path);
        }

        private void powers_btn_Click(object sender, EventArgs e)
        {
            Process.Start("powershell", "-command cd " + path+"\npowershell");
        }
    }
}

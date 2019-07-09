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

            
            bmp = new Bitmap(Other.Blur(new Bitmap(img, new Size(w/10,h/10) ),4), new Size(w,h));
            
        }
        public List<_Index> CDir = new List<_Index> { };
        private void Form1_Load(object sender, EventArgs e)
        {
            
            path = System.IO.Directory.GetCurrentDirectory();
            path_tb.Text = path;
            updateDir();


        }
        public void updateDir()
        {
            path_tb.Text = path;
            CDir = new List<_Index> { new _Index(0, "../", 1) };
            browser_lv.Clear();
            FileFunction.DirSearch(path);
            var ts = FileFunction.Nfiles;
            var ts2 = FileFunction.Nfolders;
            foreach (_File s in ts)
            {
                
                    CDir.Add(new _Index(s.UIN, s.Name, 0)); 
                //MessageBox.Show(s.Tags.ToString());

            }
            foreach (_Folder s in ts2)
            {
                CDir.Add(new _Index(s.UIN, s.Name, 1));
            }
            foreach (_Index s in CDir)
            {
                if ((path != "C:\\") || (s.UIN != 0))
                {
                    browser_lv.Items.Add(s.UIN.ToString(), s.Name, Convert.ToInt32(s.Type));
                }
            }
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
                path = path_tb.Text;
                updateDir();
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

        private void browser_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        public ListViewItem CSelect = new ListViewItem();
        private void browser_lv_DoubleClick(object sender, EventArgs e)
        {
            CSelect = browser_lv.SelectedItems[0];
            open(CSelect);
        }
        public void open(ListViewItem i)
        {
            foreach (_Index x in CDir)
            {
                
                if (x.UIN.ToString() == i.Name)
                {
                    if (x.Type == 0)
                    {
                        foreach (_File s in FileFunction.Nfiles)
                        {
                            if (x.UIN == s.UIN)
                            {
                                //MessageBox.Show(@"" + s.FullLocation);
                                Process.Start(@"" + s.FullLocation);
                            }
                        }
                    }
                    if (x.Type == 1)
                    {
                        if (x.UIN != 0)
                        {
                            foreach (_Folder s in FileFunction.Nfolders)
                            {
                                if (x.UIN == s.UIN)
                                {
                                    //MessageBox.Show(@"" + s.FullLocation);
                                    path = s.FullLocation;
                                }
                            }
                        }
                        else
                        {
                            path = Path.GetDirectoryName(path);
                            
                        }
                        updateDir();
                    }

                }
            }
        }
        private void browser_lv_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            CSelect = browser_lv.SelectedItems[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Height > 32)
            {
                this.Height = 32;
            }
            else
            {
                this.Height = 500;
            }
        }
    }
}

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
        Point pos = new Point(0, 0);
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
            int h = (int)(((float)Screen.GetBounds(new Point(this.Left, this.Top)).Width / (float)tmpyw) * tmph);
            int w = (int)Screen.GetBounds(new Point(this.Left, this.Top)).Width;
            bmp = new Bitmap(Other.Blur(new Bitmap(img, new Size(w / 10, h / 10)), 4), new Size(w, h));
        }
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            path = System.IO.Directory.GetCurrentDirectory();
            path_tb.Text = path;
            updateDir();
        }
        public void updateDir()
        {
            path_tb.Text = path;
            uint filecount = 0;
            uint foldercount = 0;
            ulong filesize = 0;
            browser_lv.Clear();
            Crawler.DirSearch(path);
            var CUi = Crawler.CDir;
            foreach (string s in CUi)
            {
                string name = "Null";
                int type = Crawler.index.Get(s).Type;
                if (type == 0)
                {
                    name = Crawler.index.Get(s).file.Name;
                    filesize += Crawler.index.Get(s).file.size;
                    filecount++;
                }
                else if (type == 1)
                {
                    name = Crawler.index.Get(s).folder.Name;
                    foldercount++;
                }

                browser_lv.Items.Add(s, name, type);
            }
            string filesize_t = "";
            if ((filesize) < 1024)
            {
                filesize_t = filesize.ToString() + "Bytes";
            }else if ((filesize) < 1048576)
            {
                filesize_t = (Math.Round(filesize/1024f,3)).ToString() + "KiB (Kilibyte)";
            }
            else if ((filesize ) < 1073741824)
            {
                filesize_t = (Math.Round(filesize / 1048576f,3)).ToString() + "MiB (Megibyte)";
            }
            else if ((filesize) < 1099511627776)
            {
                filesize_t = (Math.Round(filesize / 1073741824f,3)).ToString() + "GiB (Gigibyte)";
            }
            else if ((filesize) < 1125899906842624)
            {
                filesize_t = (Math.Round(filesize / 1099511627776f,3)).ToString() + "TiB (Teribyte)";
            }
            size_lb.Text =filecount.ToString()+" Files(s) "+filesize_t+"\n"+foldercount.ToString()+" Folder(s)";
        }
        

        private void Form1_Move(object sender, EventArgs e)
        {
            pos = new Point(-this.Left, -this.Top);
            //label1.Text = pos.ToString()+Screen.GetBounds(new Point(this.Left,this.Top)).ToString();
            g.DrawImage(bmp, pos.X, pos.Y);
            g1.DrawImage(bmp, pos.X, pos.Y);
            g1.FillRectangle(new SolidBrush(Color.FromArgb(128, 0, 0, 0)), new Rectangle(0, 0, top_pnl.Width, top_pnl.Height));
            g1.DrawString("FileViewer - " + Crawler.index.Indexed().ToString(), top_pnl.Font, Brushes.White, new Point(0, 0));
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
            g1.DrawString("FileViewer - "+FileFunction.UINC.ToString(), top_pnl.Font, Brushes.White, new Point(0, 0));
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
            if (browser_lv.SelectedItems.Count > 0)
            {
                if (Crawler.index.Get(browser_lv.SelectedItems[0].Name).Type == 0)
                {
                    _File file = Crawler.index.Get(browser_lv.SelectedItems[0].Name).file;
                    fileinfo_lb.Text = "Name: " + file.Name + "\nLocation: " + file.Location + "\nSize: " + file.size + "\nLast Access: " + file.Lastaccess;
                }
            }
            
        }
        public ListViewItem CSelect = new ListViewItem();
        private void browser_lv_DoubleClick(object sender, MouseEventArgs e)
        {
            CSelect = browser_lv.SelectedItems[0];
            open(CSelect);
        }
        public void open(ListViewItem i)
        {
            if (Crawler.index.Get(i.Name).Type == 0)
            {
                Process.Start(@"" + Crawler.index.Get(i.Name).file.FullLocation);
            }else if (Crawler.index.Get(i.Name).Type == 1)
            {
                path = Crawler.index.Get(i.Name).folder.FullLocation;
                updateDir();
            }
                                    //string s = i.Name;
                                    //if (FileFunction.files.ContainsKey(s))
                                    //{
                                    //    //browser_lv.Items.Add(s, FileFunction.files[s].Name);
                                    //    Process.Start(@"" + FileFunction.files[s].FullLocation);
                                    //}
                                    //else if (FileFunction.folders.ContainsKey(s))
                                    //{
                                    //    path = FileFunction.folders[s].FullLocation;

            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //    Environment.Exit(0);
            //}
        }
        private void browser_lv_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            CSelect = browser_lv.SelectedItems[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(status_pnl.Visible)
            {
                this.Height = 32;
                button1.Text = "▼";
                status_pnl.Visible = false;
            }
            else
            {
                this.Height = 500;
                button1.Text = "▲";
                status_pnl.Visible = true;
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            updateDir();
        }

        private void dirup_btn_Click(object sender, EventArgs e)
        {
            if (path.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).Length > 1)
            {
                path = Directory.GetParent(path).ToString();
                updateDir();
            }
            else
            {
                MessageBox.Show("Can't Go Back Due To: At root of current drive.","Warning");
            }
        }


    }
}

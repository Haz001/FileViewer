namespace FileViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.close_btn = new System.Windows.Forms.Button();
            this.max_btn = new System.Windows.Forms.Button();
            this.mini_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmd_btn = new System.Windows.Forms.Button();
            this.powers_btn = new System.Windows.Forms.Button();
            this.side_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.path_tb = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.status_pnl = new System.Windows.Forms.Panel();
            this.home_btn = new System.Windows.Forms.Button();
            this.doc_btn = new System.Windows.Forms.Button();
            this.pic_btn = new System.Windows.Forms.Button();
            this.size_lb = new System.Windows.Forms.Label();
            this.sider_pnl = new System.Windows.Forms.Panel();
            this.browser_lv = new System.Windows.Forms.ListView();
            this.fileinfo_lb = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dirup_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.top_pnl.SuspendLayout();
            this.side_pnl.SuspendLayout();
            this.status_pnl.SuspendLayout();
            this.sider_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_pnl
            // 
            this.top_pnl.Controls.Add(this.close_btn);
            this.top_pnl.Controls.Add(this.max_btn);
            this.top_pnl.Controls.Add(this.mini_btn);
            this.top_pnl.Controls.Add(this.button1);
            this.top_pnl.Controls.Add(this.cmd_btn);
            this.top_pnl.Controls.Add(this.powers_btn);
            this.top_pnl.Controls.Add(this.button2);
            this.top_pnl.Controls.Add(this.dirup_btn);
            this.top_pnl.Controls.Add(this.button3);
            this.top_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_pnl.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.top_pnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_pnl.Location = new System.Drawing.Point(0, 0);
            this.top_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.top_pnl.Name = "top_pnl";
            this.top_pnl.Size = new System.Drawing.Size(1200, 32);
            this.top_pnl.TabIndex = 3;
            this.top_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.top_pnl_Paint);
            this.top_pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_pnl_MouseDown);
            this.top_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_pnl_MouseMove);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Gray;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(1152, 0);
            this.close_btn.Margin = new System.Windows.Forms.Padding(0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(48, 32);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // max_btn
            // 
            this.max_btn.BackColor = System.Drawing.Color.Gray;
            this.max_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.max_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.max_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.max_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_btn.ForeColor = System.Drawing.Color.White;
            this.max_btn.Location = new System.Drawing.Point(1104, 0);
            this.max_btn.Margin = new System.Windows.Forms.Padding(0);
            this.max_btn.Name = "max_btn";
            this.max_btn.Size = new System.Drawing.Size(48, 32);
            this.max_btn.TabIndex = 0;
            this.max_btn.Text = "<->";
            this.max_btn.UseVisualStyleBackColor = false;
            this.max_btn.Click += new System.EventHandler(this.max_btn_Click);
            // 
            // mini_btn
            // 
            this.mini_btn.BackColor = System.Drawing.Color.Gray;
            this.mini_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mini_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.mini_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mini_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mini_btn.ForeColor = System.Drawing.Color.White;
            this.mini_btn.Location = new System.Drawing.Point(1056, 0);
            this.mini_btn.Margin = new System.Windows.Forms.Padding(0);
            this.mini_btn.Name = "mini_btn";
            this.mini_btn.Size = new System.Drawing.Size(48, 32);
            this.mini_btn.TabIndex = 0;
            this.mini_btn.Text = "_";
            this.mini_btn.UseVisualStyleBackColor = false;
            this.mini_btn.Click += new System.EventHandler(this.mini_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1008, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "▲";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_btn
            // 
            this.cmd_btn.BackColor = System.Drawing.Color.Gray;
            this.cmd_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmd_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cmd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_btn.ForeColor = System.Drawing.Color.White;
            this.cmd_btn.Location = new System.Drawing.Point(960, 0);
            this.cmd_btn.Margin = new System.Windows.Forms.Padding(0);
            this.cmd_btn.Name = "cmd_btn";
            this.cmd_btn.Size = new System.Drawing.Size(48, 32);
            this.cmd_btn.TabIndex = 1;
            this.cmd_btn.Text = "CMD";
            this.cmd_btn.UseVisualStyleBackColor = false;
            this.cmd_btn.Click += new System.EventHandler(this.cmd_btn_Click);
            // 
            // powers_btn
            // 
            this.powers_btn.BackColor = System.Drawing.Color.Gray;
            this.powers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.powers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.powers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powers_btn.ForeColor = System.Drawing.Color.White;
            this.powers_btn.Location = new System.Drawing.Point(912, 0);
            this.powers_btn.Margin = new System.Windows.Forms.Padding(0);
            this.powers_btn.Name = "powers_btn";
            this.powers_btn.Size = new System.Drawing.Size(48, 32);
            this.powers_btn.TabIndex = 1;
            this.powers_btn.Text = "PS";
            this.powers_btn.UseVisualStyleBackColor = false;
            this.powers_btn.Click += new System.EventHandler(this.powers_btn_Click);
            // 
            // side_pnl
            // 
            this.side_pnl.Controls.Add(this.home_btn);
            this.side_pnl.Controls.Add(this.doc_btn);
            this.side_pnl.Controls.Add(this.pic_btn);
            this.side_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_pnl.Location = new System.Drawing.Point(0, 32);
            this.side_pnl.Name = "side_pnl";
            this.side_pnl.Size = new System.Drawing.Size(200, 468);
            this.side_pnl.TabIndex = 4;
            // 
            // path_tb
            // 
            this.path_tb.Dock = System.Windows.Forms.DockStyle.Top;
            this.path_tb.Location = new System.Drawing.Point(200, 32);
            this.path_tb.Name = "path_tb";
            this.path_tb.Size = new System.Drawing.Size(1000, 20);
            this.path_tb.TabIndex = 5;
            this.path_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.path_tb_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "doc.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            // 
            // status_pnl
            // 
            this.status_pnl.Controls.Add(this.size_lb);
            this.status_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_pnl.Location = new System.Drawing.Point(200, 474);
            this.status_pnl.Name = "status_pnl";
            this.status_pnl.Size = new System.Drawing.Size(1000, 26);
            this.status_pnl.TabIndex = 6;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Gray;
            this.home_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Location = new System.Drawing.Point(0, 0);
            this.home_btn.Margin = new System.Windows.Forms.Padding(0);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(200, 32);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // doc_btn
            // 
            this.doc_btn.BackColor = System.Drawing.Color.Gray;
            this.doc_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doc_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.doc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_btn.ForeColor = System.Drawing.Color.White;
            this.doc_btn.Location = new System.Drawing.Point(0, 32);
            this.doc_btn.Margin = new System.Windows.Forms.Padding(0);
            this.doc_btn.Name = "doc_btn";
            this.doc_btn.Size = new System.Drawing.Size(200, 32);
            this.doc_btn.TabIndex = 2;
            this.doc_btn.Text = "Documents";
            this.doc_btn.UseVisualStyleBackColor = false;
            this.doc_btn.Visible = false;
            // 
            // pic_btn
            // 
            this.pic_btn.BackColor = System.Drawing.Color.Gray;
            this.pic_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pic_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pic_btn.ForeColor = System.Drawing.Color.White;
            this.pic_btn.Location = new System.Drawing.Point(0, 64);
            this.pic_btn.Margin = new System.Windows.Forms.Padding(0);
            this.pic_btn.Name = "pic_btn";
            this.pic_btn.Size = new System.Drawing.Size(200, 32);
            this.pic_btn.TabIndex = 3;
            this.pic_btn.Text = "Pictures";
            this.pic_btn.UseVisualStyleBackColor = false;
            this.pic_btn.Visible = false;
            // 
            // size_lb
            // 
            this.size_lb.AutoSize = true;
            this.size_lb.Location = new System.Drawing.Point(0, 0);
            this.size_lb.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.size_lb.Name = "size_lb";
            this.size_lb.Size = new System.Drawing.Size(34, 26);
            this.size_lb.TabIndex = 0;
            this.size_lb.Text = "Tests\r\nTest2";
            // 
            // sider_pnl
            // 
            this.sider_pnl.Controls.Add(this.fileinfo_lb);
            this.sider_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.sider_pnl.Location = new System.Drawing.Point(1000, 52);
            this.sider_pnl.Name = "sider_pnl";
            this.sider_pnl.Size = new System.Drawing.Size(200, 422);
            this.sider_pnl.TabIndex = 8;
            // 
            // browser_lv
            // 
            this.browser_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser_lv.LargeImageList = this.imageList1;
            this.browser_lv.Location = new System.Drawing.Point(200, 52);
            this.browser_lv.Name = "browser_lv";
            this.browser_lv.Size = new System.Drawing.Size(800, 422);
            this.browser_lv.TabIndex = 9;
            this.browser_lv.UseCompatibleStateImageBehavior = false;
            this.browser_lv.SelectedIndexChanged += new System.EventHandler(this.browser_lv_SelectedIndexChanged);
            this.browser_lv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.browser_lv_DoubleClick);
            // 
            // fileinfo_lb
            // 
            this.fileinfo_lb.AutoSize = true;
            this.fileinfo_lb.Location = new System.Drawing.Point(6, 3);
            this.fileinfo_lb.Name = "fileinfo_lb";
            this.fileinfo_lb.Size = new System.Drawing.Size(35, 13);
            this.fileinfo_lb.TabIndex = 0;
            this.fileinfo_lb.Text = "label1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(864, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // dirup_btn
            // 
            this.dirup_btn.BackColor = System.Drawing.Color.Gray;
            this.dirup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dirup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dirup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dirup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirup_btn.ForeColor = System.Drawing.Color.White;
            this.dirup_btn.Location = new System.Drawing.Point(816, 0);
            this.dirup_btn.Margin = new System.Windows.Forms.Padding(0);
            this.dirup_btn.Name = "dirup_btn";
            this.dirup_btn.Size = new System.Drawing.Size(48, 32);
            this.dirup_btn.TabIndex = 4;
            this.dirup_btn.Text = "↑";
            this.dirup_btn.UseVisualStyleBackColor = false;
            this.dirup_btn.Click += new System.EventHandler(this.dirup_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(768, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.browser_lv);
            this.Controls.Add(this.sider_pnl);
            this.Controls.Add(this.status_pnl);
            this.Controls.Add(this.path_tb);
            this.Controls.Add(this.side_pnl);
            this.Controls.Add(this.top_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.top_pnl.ResumeLayout(false);
            this.side_pnl.ResumeLayout(false);
            this.status_pnl.ResumeLayout(false);
            this.status_pnl.PerformLayout();
            this.sider_pnl.ResumeLayout(false);
            this.sider_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel top_pnl;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button max_btn;
        private System.Windows.Forms.Button mini_btn;
        private System.Windows.Forms.FlowLayoutPanel side_pnl;
        private System.Windows.Forms.TextBox path_tb;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button cmd_btn;
        private System.Windows.Forms.Button powers_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel status_pnl;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button doc_btn;
        private System.Windows.Forms.Button pic_btn;
        private System.Windows.Forms.Label size_lb;
        private System.Windows.Forms.Panel sider_pnl;
        private System.Windows.Forms.ListView browser_lv;
        private System.Windows.Forms.Label fileinfo_lb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dirup_btn;
        private System.Windows.Forms.Button button3;
    }
}


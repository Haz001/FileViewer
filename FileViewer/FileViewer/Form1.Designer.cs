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
            this.cmd_btn = new System.Windows.Forms.Button();
            this.powers_btn = new System.Windows.Forms.Button();
            this.side_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.path_tb = new System.Windows.Forms.TextBox();
            this.browser_lv = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.top_pnl.SuspendLayout();
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
            // browser_lv
            // 
            this.browser_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser_lv.LargeImageList = this.imageList1;
            this.browser_lv.Location = new System.Drawing.Point(200, 52);
            this.browser_lv.Name = "browser_lv";
            this.browser_lv.Size = new System.Drawing.Size(1000, 448);
            this.browser_lv.TabIndex = 6;
            this.browser_lv.UseCompatibleStateImageBehavior = false;
            this.browser_lv.DoubleClick += new System.EventHandler(this.browser_lv_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "doc.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1008, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "↑";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.browser_lv);
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
        private System.Windows.Forms.ListView browser_lv;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button cmd_btn;
        private System.Windows.Forms.Button powers_btn;
        private System.Windows.Forms.Button button1;
    }
}


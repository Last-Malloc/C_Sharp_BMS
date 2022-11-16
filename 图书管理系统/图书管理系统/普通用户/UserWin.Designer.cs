namespace 图书管理系统
{
    partial class UserWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.我的信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书借阅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.续借ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbName = new System.Windows.Forms.Label();
            this.picBoxHead = new System.Windows.Forms.PictureBox();
            this.二维码还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHead)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的信息ToolStripMenuItem,
            this.图书借阅ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 我的信息ToolStripMenuItem
            // 
            this.我的信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.注销ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.我的信息ToolStripMenuItem.Name = "我的信息ToolStripMenuItem";
            this.我的信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.我的信息ToolStripMenuItem.Text = "我的信息";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem2.Text = "我的信息";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem3.Text = "人脸注册";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem1.Text = "更改密码";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 图书借阅ToolStripMenuItem
            // 
            this.图书借阅ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem,
            this.还书ToolStripMenuItem,
            this.续借ToolStripMenuItem,
            this.二维码还书ToolStripMenuItem});
            this.图书借阅ToolStripMenuItem.Name = "图书借阅ToolStripMenuItem";
            this.图书借阅ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.图书借阅ToolStripMenuItem.Text = "图书借阅";
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.借书ToolStripMenuItem.Text = "借书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.还书ToolStripMenuItem.Text = "还书";
            this.还书ToolStripMenuItem.Click += new System.EventHandler(this.还书ToolStripMenuItem_Click);
            // 
            // 续借ToolStripMenuItem
            // 
            this.续借ToolStripMenuItem.Name = "续借ToolStripMenuItem";
            this.续借ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.续借ToolStripMenuItem.Text = "续借";
            this.续借ToolStripMenuItem.Click += new System.EventHandler(this.续借ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("宋体", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(158, 110);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(300, 47);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "您好，卢宪涛";
            // 
            // picBoxHead
            // 
            this.picBoxHead.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHead.BackgroundImage = global::图书管理系统.Properties.Resources.moren;
            this.picBoxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxHead.Location = new System.Drawing.Point(42, 57);
            this.picBoxHead.Name = "picBoxHead";
            this.picBoxHead.Size = new System.Drawing.Size(100, 100);
            this.picBoxHead.TabIndex = 19;
            this.picBoxHead.TabStop = false;
            // 
            // 二维码还书ToolStripMenuItem
            // 
            this.二维码还书ToolStripMenuItem.Name = "二维码还书ToolStripMenuItem";
            this.二维码还书ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.二维码还书ToolStripMenuItem.Text = "二维码还书";
            this.二维码还书ToolStripMenuItem.Click += new System.EventHandler(this.二维码还书ToolStripMenuItem_Click);
            // 
            // UserWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 514);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picBoxHead);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "UserWin";
            this.Text = "图书管理员";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserWin_FormClosing);
            this.Load += new System.EventHandler(this.UserWin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 我的信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox picBoxHead;
        private System.Windows.Forms.ToolStripMenuItem 图书借阅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 续借ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 二维码还书ToolStripMenuItem;
    }
}
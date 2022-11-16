namespace 图书管理系统
{
    partial class ManaWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManaWin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.我的信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员信息更新ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.账号解封ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.类别管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户类别管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者类别管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加图书类别ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.手动输入ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.二维码输入ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改类别名称ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.图书类别查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.数据统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.活跃读者统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.热门图书统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBoxHead = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
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
            this.用户管理ToolStripMenuItem,
            this.图书管理ToolStripMenuItem,
            this.类别管理ToolStripMenuItem,
            this.数据统计ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 我的信息ToolStripMenuItem
            // 
            this.我的信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.注销ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.我的信息ToolStripMenuItem.Name = "我的信息ToolStripMenuItem";
            this.我的信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.我的信息ToolStripMenuItem.Text = "我的信息";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem1.Text = "我的信息";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem3.Text = "人脸注册";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem2.Text = "修改密码";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
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
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员信息更新ToolStripMenuItem3,
            this.账号解封ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.用户管理ToolStripMenuItem.Text = "人员管理";
            // 
            // 人员信息更新ToolStripMenuItem3
            // 
            this.人员信息更新ToolStripMenuItem3.Name = "人员信息更新ToolStripMenuItem3";
            this.人员信息更新ToolStripMenuItem3.Size = new System.Drawing.Size(174, 26);
            this.人员信息更新ToolStripMenuItem3.Text = "人员数据更新";
            this.人员信息更新ToolStripMenuItem3.Click += new System.EventHandler(this.人员信息更新ToolStripMenuItem3_Click);
            // 
            // 账号解封ToolStripMenuItem
            // 
            this.账号解封ToolStripMenuItem.Name = "账号解封ToolStripMenuItem";
            this.账号解封ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.账号解封ToolStripMenuItem.Text = "用户冻结解冻";
            this.账号解封ToolStripMenuItem.Click += new System.EventHandler(this.账号解封ToolStripMenuItem_Click);
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem4.Text = "增加图书信息";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem7.Text = "修改图书信息";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.修改图书信息ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem8.Text = "查询图书信息";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.查询图书信息ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem9.Text = "删除图书信息";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.删除图书信息ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem10.Text = "生成图书数据码";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.生成图书数据码ToolStripMenuItem_Click);
            // 
            // 类别管理ToolStripMenuItem
            // 
            this.类别管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户类别管理ToolStripMenuItem,
            this.读者类别管理ToolStripMenuItem});
            this.类别管理ToolStripMenuItem.Name = "类别管理ToolStripMenuItem";
            this.类别管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.类别管理ToolStripMenuItem.Text = "类别管理";
            // 
            // 用户类别管理ToolStripMenuItem
            // 
            this.用户类别管理ToolStripMenuItem.Name = "用户类别管理ToolStripMenuItem";
            this.用户类别管理ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.用户类别管理ToolStripMenuItem.Text = "人员类别管理";
            this.用户类别管理ToolStripMenuItem.Click += new System.EventHandler(this.用户类别管理ToolStripMenuItem_Click);
            // 
            // 读者类别管理ToolStripMenuItem
            // 
            this.读者类别管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加图书类别ToolStripMenuItem1,
            this.修改类别名称ToolStripMenuItem1,
            this.图书类别查询ToolStripMenuItem1});
            this.读者类别管理ToolStripMenuItem.Name = "读者类别管理ToolStripMenuItem";
            this.读者类别管理ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.读者类别管理ToolStripMenuItem.Text = "图书类别管理";
            // 
            // 添加图书类别ToolStripMenuItem1
            // 
            this.添加图书类别ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.手动输入ToolStripMenuItem2,
            this.二维码输入ToolStripMenuItem2});
            this.添加图书类别ToolStripMenuItem1.Name = "添加图书类别ToolStripMenuItem1";
            this.添加图书类别ToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.添加图书类别ToolStripMenuItem1.Text = "添加图书类别";
            // 
            // 手动输入ToolStripMenuItem2
            // 
            this.手动输入ToolStripMenuItem2.Name = "手动输入ToolStripMenuItem2";
            this.手动输入ToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.手动输入ToolStripMenuItem2.Text = "手动输入";
            this.手动输入ToolStripMenuItem2.Click += new System.EventHandler(this.手动输入ToolStripMenuItem_Click);
            // 
            // 二维码输入ToolStripMenuItem2
            // 
            this.二维码输入ToolStripMenuItem2.Name = "二维码输入ToolStripMenuItem2";
            this.二维码输入ToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.二维码输入ToolStripMenuItem2.Text = "二维码输入";
            this.二维码输入ToolStripMenuItem2.Click += new System.EventHandler(this.二维码输入ToolStripMenuItem_Click);
            // 
            // 修改类别名称ToolStripMenuItem1
            // 
            this.修改类别名称ToolStripMenuItem1.Name = "修改类别名称ToolStripMenuItem1";
            this.修改类别名称ToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.修改类别名称ToolStripMenuItem1.Text = "修改类别名称";
            this.修改类别名称ToolStripMenuItem1.Click += new System.EventHandler(this.修改类别名称ToolStripMenuItem_Click);
            // 
            // 图书类别查询ToolStripMenuItem1
            // 
            this.图书类别查询ToolStripMenuItem1.Name = "图书类别查询ToolStripMenuItem1";
            this.图书类别查询ToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.图书类别查询ToolStripMenuItem1.Text = "图书类别查询";
            this.图书类别查询ToolStripMenuItem1.Click += new System.EventHandler(this.图书类别查询ToolStripMenuItem_Click);
            // 
            // 数据统计ToolStripMenuItem
            // 
            this.数据统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.活跃读者统计ToolStripMenuItem,
            this.热门图书统计ToolStripMenuItem});
            this.数据统计ToolStripMenuItem.Name = "数据统计ToolStripMenuItem";
            this.数据统计ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.数据统计ToolStripMenuItem.Text = "数据统计";
            // 
            // 活跃读者统计ToolStripMenuItem
            // 
            this.活跃读者统计ToolStripMenuItem.Name = "活跃读者统计ToolStripMenuItem";
            this.活跃读者统计ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.活跃读者统计ToolStripMenuItem.Text = "活跃读者统计";
            this.活跃读者统计ToolStripMenuItem.Click += new System.EventHandler(this.活跃读者统计ToolStripMenuItem_Click);
            // 
            // 热门图书统计ToolStripMenuItem
            // 
            this.热门图书统计ToolStripMenuItem.Name = "热门图书统计ToolStripMenuItem";
            this.热门图书统计ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.热门图书统计ToolStripMenuItem.Text = "热门图书统计";
            this.热门图书统计ToolStripMenuItem.Click += new System.EventHandler(this.热门图书统计ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // picBoxHead
            // 
            this.picBoxHead.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHead.BackgroundImage = global::图书管理系统.Properties.Resources.moren;
            this.picBoxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxHead.Location = new System.Drawing.Point(96, 61);
            this.picBoxHead.Name = "picBoxHead";
            this.picBoxHead.Size = new System.Drawing.Size(100, 100);
            this.picBoxHead.TabIndex = 2;
            this.picBoxHead.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("宋体", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(212, 114);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(300, 47);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "您好，卢宪涛";
            // 
            // ManaWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 543);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picBoxHead);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ManaWin";
            this.Text = "系统管理员";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManaWin_FormClosing);
            this.Load += new System.EventHandler(this.ManaWin_Load);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 活跃读者统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 热门图书统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBoxHead;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ToolStripMenuItem 类别管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户类别管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者类别管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账号解封ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员信息更新ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 添加图书类别ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 手动输入ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 二维码输入ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 修改类别名称ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 图书类别查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
    }
}
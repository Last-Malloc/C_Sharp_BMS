namespace 图书管理系统
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textPW = new System.Windows.Forms.TextBox();
            this.comboID = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除该账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbRememPW = new System.Windows.Forms.CheckBox();
            this.cbAutoLogin = new System.Windows.Forms.CheckBox();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEmailLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(327, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(516, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 33);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("黑体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(232, 417);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(257, 56);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登  录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(205, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(205, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // textPW
            // 
            this.textPW.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPW.Location = new System.Drawing.Point(271, 331);
            this.textPW.Name = "textPW";
            this.textPW.PasswordChar = '*';
            this.textPW.Size = new System.Drawing.Size(239, 38);
            this.textPW.TabIndex = 2;
            // 
            // comboID
            // 
            this.comboID.ContextMenuStrip = this.contextMenuStrip1;
            this.comboID.Font = new System.Drawing.Font("黑体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboID.FormattingEnabled = true;
            this.comboID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboID.ItemHeight = 33;
            this.comboID.Location = new System.Drawing.Point(271, 264);
            this.comboID.MaxDropDownItems = 6;
            this.comboID.Name = "comboID";
            this.comboID.Size = new System.Drawing.Size(239, 41);
            this.comboID.TabIndex = 1;
            this.comboID.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboID_DrawItem);
            this.comboID.SelectedIndexChanged += new System.EventHandler(this.comboID_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除该账号ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 28);
            // 
            // 删除该账号ToolStripMenuItem
            // 
            this.删除该账号ToolStripMenuItem.Name = "删除该账号ToolStripMenuItem";
            this.删除该账号ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.删除该账号ToolStripMenuItem.Text = "删除该账号";
            this.删除该账号ToolStripMenuItem.Click += new System.EventHandler(this.删除该账号ToolStripMenuItem_Click);
            // 
            // cbRememPW
            // 
            this.cbRememPW.AutoSize = true;
            this.cbRememPW.BackColor = System.Drawing.Color.Transparent;
            this.cbRememPW.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRememPW.Location = new System.Drawing.Point(395, 387);
            this.cbRememPW.Name = "cbRememPW";
            this.cbRememPW.Size = new System.Drawing.Size(115, 24);
            this.cbRememPW.TabIndex = 5;
            this.cbRememPW.Text = "记住密码";
            this.cbRememPW.UseVisualStyleBackColor = false;
            // 
            // cbAutoLogin
            // 
            this.cbAutoLogin.AutoSize = true;
            this.cbAutoLogin.BackColor = System.Drawing.Color.Transparent;
            this.cbAutoLogin.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoLogin.Location = new System.Drawing.Point(217, 387);
            this.cbAutoLogin.Name = "cbAutoLogin";
            this.cbAutoLogin.Size = new System.Drawing.Size(115, 24);
            this.cbAutoLogin.TabIndex = 4;
            this.cbAutoLogin.Text = "自动登录";
            this.cbAutoLogin.UseVisualStyleBackColor = false;
            this.cbAutoLogin.CheckedChanged += new System.EventHandler(this.cbAutoLogin_CheckedChanged);
            // 
            // btnChangePW
            // 
            this.btnChangePW.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePW.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnChangePW.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangePW.Location = new System.Drawing.Point(563, 460);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(133, 38);
            this.btnChangePW.TabIndex = 6;
            this.btnChangePW.Text = "更改密码";
            this.btnChangePW.UseVisualStyleBackColor = false;
            this.btnChangePW.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEmailLogin
            // 
            this.btnEmailLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnEmailLogin.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnEmailLogin.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEmailLogin.Location = new System.Drawing.Point(0, 460);
            this.btnEmailLogin.Name = "btnEmailLogin";
            this.btnEmailLogin.Size = new System.Drawing.Size(133, 38);
            this.btnEmailLogin.TabIndex = 8;
            this.btnEmailLogin.Text = "邮箱验证";
            this.btnEmailLogin.UseVisualStyleBackColor = false;
            this.btnEmailLogin.Click += new System.EventHandler(this.btnEmailLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(516, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(696, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEmailLogin);
            this.Controls.Add(this.cbAutoLogin);
            this.Controls.Add(this.cbRememPW);
            this.Controls.Add(this.btnChangePW);
            this.Controls.Add(this.comboID);
            this.Controls.Add(this.textPW);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textPW;
        private System.Windows.Forms.ComboBox comboID;
        private System.Windows.Forms.CheckBox cbRememPW;
        private System.Windows.Forms.CheckBox cbAutoLogin;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除该账号ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEmailLogin;
        private System.Windows.Forms.Button button1;
    }
}


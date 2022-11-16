namespace 图书管理系统
{
    partial class MyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyInfo));
            this.pictureBoxHead = new System.Windows.Forms.PictureBox();
            this.btnChoHeadPic = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbSFID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTypeDay = new System.Windows.Forms.Label();
            this.lbNameSex = new System.Windows.Forms.Label();
            this.lbXYBJ = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbTypeNum = new System.Windows.Forms.Label();
            this.textTele = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHead
            // 
            this.pictureBoxHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxHead.BackgroundImage")));
            this.pictureBoxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHead.Location = new System.Drawing.Point(29, 29);
            this.pictureBoxHead.Name = "pictureBoxHead";
            this.pictureBoxHead.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxHead.TabIndex = 0;
            this.pictureBoxHead.TabStop = false;
            // 
            // btnChoHeadPic
            // 
            this.btnChoHeadPic.AutoSize = true;
            this.btnChoHeadPic.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnChoHeadPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoHeadPic.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoHeadPic.Location = new System.Drawing.Point(29, 135);
            this.btnChoHeadPic.Name = "btnChoHeadPic";
            this.btnChoHeadPic.Size = new System.Drawing.Size(100, 37);
            this.btnChoHeadPic.TabIndex = 1;
            this.btnChoHeadPic.Text = "更换头像";
            this.btnChoHeadPic.UseVisualStyleBackColor = true;
            this.btnChoHeadPic.Click += new System.EventHandler(this.btnChoHeadPic_Click);
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbID.Location = new System.Drawing.Point(36, 186);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(228, 35);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "学号：1704040213";
            // 
            // lbType
            // 
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbType.Location = new System.Drawing.Point(146, 64);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(228, 35);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "系统管理员";
            // 
            // lbSFID
            // 
            this.lbSFID.BackColor = System.Drawing.Color.Transparent;
            this.lbSFID.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSFID.Location = new System.Drawing.Point(36, 267);
            this.lbSFID.Name = "lbSFID";
            this.lbSFID.Size = new System.Drawing.Size(373, 35);
            this.lbSFID.TabIndex = 3;
            this.lbSFID.Text = "身份证号：37012319980813471X";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(36, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tele：";
            // 
            // lbTypeDay
            // 
            this.lbTypeDay.BackColor = System.Drawing.Color.Transparent;
            this.lbTypeDay.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTypeDay.Location = new System.Drawing.Point(146, 99);
            this.lbTypeDay.Name = "lbTypeDay";
            this.lbTypeDay.Size = new System.Drawing.Size(354, 35);
            this.lbTypeDay.TabIndex = 3;
            this.lbTypeDay.Text = "可借阅天数：100000000";
            // 
            // lbNameSex
            // 
            this.lbNameSex.BackColor = System.Drawing.Color.Transparent;
            this.lbNameSex.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNameSex.Location = new System.Drawing.Point(146, 29);
            this.lbNameSex.Name = "lbNameSex";
            this.lbNameSex.Size = new System.Drawing.Size(228, 35);
            this.lbNameSex.TabIndex = 3;
            this.lbNameSex.Text = "卢宪涛 男";
            // 
            // lbXYBJ
            // 
            this.lbXYBJ.BackColor = System.Drawing.Color.Transparent;
            this.lbXYBJ.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbXYBJ.Location = new System.Drawing.Point(36, 221);
            this.lbXYBJ.Name = "lbXYBJ";
            this.lbXYBJ.Size = new System.Drawing.Size(228, 35);
            this.lbXYBJ.TabIndex = 3;
            this.lbXYBJ.Text = "信息学院 计算172";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(36, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 35);
            this.label8.TabIndex = 3;
            this.label8.Text = "邮箱：";
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStatus.Location = new System.Drawing.Point(36, 402);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(317, 35);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "账户状态：可用";
            // 
            // lbTypeNum
            // 
            this.lbTypeNum.BackColor = System.Drawing.Color.Transparent;
            this.lbTypeNum.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTypeNum.Location = new System.Drawing.Point(146, 140);
            this.lbTypeNum.Name = "lbTypeNum";
            this.lbTypeNum.Size = new System.Drawing.Size(354, 35);
            this.lbTypeNum.TabIndex = 5;
            this.lbTypeNum.Text = "可借阅本数：100000000";
            // 
            // textTele
            // 
            this.textTele.Location = new System.Drawing.Point(124, 312);
            this.textTele.Name = "textTele";
            this.textTele.Size = new System.Drawing.Size(250, 25);
            this.textTele.TabIndex = 6;
            this.textTele.TextChanged += new System.EventHandler(this.textTele_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(124, 357);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(250, 25);
            this.textEmail.TabIndex = 6;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(0, 427);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 37);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确认更改";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(332, 427);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 37);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::图书管理系统.Properties.Resources.更改密码;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 462);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTele);
            this.Controls.Add(this.lbTypeNum);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSFID);
            this.Controls.Add(this.lbTypeDay);
            this.Controls.Add(this.lbNameSex);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbXYBJ);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnChoHeadPic);
            this.Controls.Add(this.pictureBoxHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的信息";
            this.Load += new System.EventHandler(this.MyInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHead;
        private System.Windows.Forms.Button btnChoHeadPic;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbSFID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTypeDay;
        private System.Windows.Forms.Label lbNameSex;
        private System.Windows.Forms.Label lbXYBJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbTypeNum;
        private System.Windows.Forms.TextBox textTele;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBack;
    }
}
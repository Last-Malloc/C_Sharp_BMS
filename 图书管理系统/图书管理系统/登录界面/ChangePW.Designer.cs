namespace 图书管理系统
{
    partial class ChangePW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePW));
            this.button2 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textNewPW2 = new System.Windows.Forms.TextBox();
            this.textNewPW = new System.Windows.Forms.TextBox();
            this.textPW = new System.Windows.Forms.TextBox();
            this.labelWarning2 = new System.Windows.Forms.Label();
            this.labelWarning1 = new System.Windows.Forms.Label();
            this.labelWarning3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(318, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(66, 300);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 43);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(36, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "确认密码";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(60, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "新密码";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(64, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "旧密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "账号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textID.Location = new System.Drawing.Point(152, 29);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(296, 38);
            this.textID.TabIndex = 1;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            this.textID.Leave += new System.EventHandler(this.textID_Leave);
            // 
            // textNewPW2
            // 
            this.textNewPW2.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNewPW2.Location = new System.Drawing.Point(152, 236);
            this.textNewPW2.Name = "textNewPW2";
            this.textNewPW2.PasswordChar = '*';
            this.textNewPW2.Size = new System.Drawing.Size(257, 38);
            this.textNewPW2.TabIndex = 4;
            this.textNewPW2.TextChanged += new System.EventHandler(this.textNewPW2_TextChanged);
            // 
            // textNewPW
            // 
            this.textNewPW.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNewPW.Location = new System.Drawing.Point(152, 166);
            this.textNewPW.Name = "textNewPW";
            this.textNewPW.PasswordChar = '*';
            this.textNewPW.Size = new System.Drawing.Size(257, 38);
            this.textNewPW.TabIndex = 3;
            // 
            // textPW
            // 
            this.textPW.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPW.Location = new System.Drawing.Point(152, 96);
            this.textPW.Name = "textPW";
            this.textPW.PasswordChar = '*';
            this.textPW.Size = new System.Drawing.Size(257, 38);
            this.textPW.TabIndex = 2;
            this.textPW.TextChanged += new System.EventHandler(this.textPW_TextChanged);
            this.textPW.Leave += new System.EventHandler(this.textPW_Leave);
            // 
            // labelWarning2
            // 
            this.labelWarning2.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWarning2.ForeColor = System.Drawing.Color.Red;
            this.labelWarning2.Location = new System.Drawing.Point(158, 140);
            this.labelWarning2.Name = "labelWarning2";
            this.labelWarning2.Size = new System.Drawing.Size(230, 23);
            this.labelWarning2.TabIndex = 20;
            // 
            // labelWarning1
            // 
            this.labelWarning1.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWarning1.ForeColor = System.Drawing.Color.Red;
            this.labelWarning1.Location = new System.Drawing.Point(158, 70);
            this.labelWarning1.Name = "labelWarning1";
            this.labelWarning1.Size = new System.Drawing.Size(230, 23);
            this.labelWarning1.TabIndex = 20;
            // 
            // labelWarning3
            // 
            this.labelWarning3.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWarning3.ForeColor = System.Drawing.Color.Red;
            this.labelWarning3.Location = new System.Drawing.Point(158, 277);
            this.labelWarning3.Name = "labelWarning3";
            this.labelWarning3.Size = new System.Drawing.Size(230, 23);
            this.labelWarning3.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(415, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(415, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 33);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(415, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 33);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 355);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelWarning1);
            this.Controls.Add(this.labelWarning3);
            this.Controls.Add(this.labelWarning2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textNewPW2);
            this.Controls.Add(this.textNewPW);
            this.Controls.Add(this.textPW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePW";
            this.Text = "更改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textNewPW2;
        private System.Windows.Forms.TextBox textNewPW;
        private System.Windows.Forms.TextBox textPW;
        private System.Windows.Forms.Label labelWarning2;
        private System.Windows.Forms.Label labelWarning1;
        private System.Windows.Forms.Label labelWarning3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
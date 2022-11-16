namespace 图书管理系统.普通用户
{
    partial class mareturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mareturn));
            this.imagePath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.choiceImg = new System.Windows.Forms.Button();
            this.codeimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.codeimg)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePath
            // 
            this.imagePath.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imagePath.Location = new System.Drawing.Point(29, 295);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(223, 36);
            this.imagePath.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(29, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = "检测二维码并写入数据库";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(357, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // choiceImg
            // 
            this.choiceImg.AutoSize = true;
            this.choiceImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("choiceImg.BackgroundImage")));
            this.choiceImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.choiceImg.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choiceImg.Location = new System.Drawing.Point(274, 295);
            this.choiceImg.Name = "choiceImg";
            this.choiceImg.Size = new System.Drawing.Size(158, 38);
            this.choiceImg.TabIndex = 14;
            this.choiceImg.Text = "选择二维码";
            this.choiceImg.UseVisualStyleBackColor = true;
            this.choiceImg.Click += new System.EventHandler(this.choiceImg_Click);
            // 
            // codeimg
            // 
            this.codeimg.Location = new System.Drawing.Point(79, 25);
            this.codeimg.Name = "codeimg";
            this.codeimg.Size = new System.Drawing.Size(293, 253);
            this.codeimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codeimg.TabIndex = 12;
            this.codeimg.TabStop = false;
            // 
            // mareturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::图书管理系统.Properties.Resources.更改密码;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 413);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.choiceImg);
            this.Controls.Add(this.imagePath);
            this.Controls.Add(this.codeimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mareturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "二维码还书";
            ((System.ComponentModel.ISupportInitialize)(this.codeimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button choiceImg;
        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.PictureBox codeimg;
    }
}
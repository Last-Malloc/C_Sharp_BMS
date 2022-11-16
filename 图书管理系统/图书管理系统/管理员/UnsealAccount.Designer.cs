namespace 图书管理系统
{
    partial class UnsealAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnsealAccount));
            this.btnFreeze = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnFreeze = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnResetPW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFreeze
            // 
            this.btnFreeze.BackColor = System.Drawing.Color.Transparent;
            this.btnFreeze.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnFreeze.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFreeze.Location = new System.Drawing.Point(645, 136);
            this.btnFreeze.Name = "btnFreeze";
            this.btnFreeze.Size = new System.Drawing.Size(133, 38);
            this.btnFreeze.TabIndex = 7;
            this.btnFreeze.Text = "冻结";
            this.btnFreeze.UseVisualStyleBackColor = false;
            this.btnFreeze.Click += new System.EventHandler(this.btnFreeze_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnBack.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(668, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 38);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(31, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(563, 398);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "头像";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 33;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "uID";
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 68;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "uName";
            this.Column3.HeaderText = "姓名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 42;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "性别";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 35;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "uType";
            this.Column5.HeaderText = "账户类型";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "账户状态";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnUnFreeze
            // 
            this.btnUnFreeze.BackColor = System.Drawing.Color.Transparent;
            this.btnUnFreeze.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnUnFreeze.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnFreeze.Location = new System.Drawing.Point(645, 206);
            this.btnUnFreeze.Name = "btnUnFreeze";
            this.btnUnFreeze.Size = new System.Drawing.Size(133, 38);
            this.btnUnFreeze.TabIndex = 10;
            this.btnUnFreeze.Text = "解冻";
            this.btnUnFreeze.UseVisualStyleBackColor = false;
            this.btnUnFreeze.Click += new System.EventHandler(this.btnUnFreeze_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectAll.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnSelectAll.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectAll.Location = new System.Drawing.Point(645, 70);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(133, 38);
            this.btnSelectAll.TabIndex = 12;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnResetPW
            // 
            this.btnResetPW.AutoSize = true;
            this.btnResetPW.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPW.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnResetPW.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResetPW.Location = new System.Drawing.Point(645, 277);
            this.btnResetPW.Name = "btnResetPW";
            this.btnResetPW.Size = new System.Drawing.Size(133, 38);
            this.btnResetPW.TabIndex = 13;
            this.btnResetPW.Text = "重置密码";
            this.btnResetPW.UseVisualStyleBackColor = false;
            this.btnResetPW.Click += new System.EventHandler(this.btnResetPW_Click);
            // 
            // UnsealAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetPW);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnUnFreeze);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFreeze);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UnsealAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户冻结/解冻";
            this.Load += new System.EventHandler(this.UnsealAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFreeze;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUnFreeze;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnResetPW;
    }
}
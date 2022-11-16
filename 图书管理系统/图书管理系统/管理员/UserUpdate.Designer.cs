namespace 图书管理系统
{
    partial class UserUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUpdate));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.筛选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.不限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息学院ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.不限ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.计算171ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算172ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息172ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材料学院ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.金属171ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.金属172ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材物171ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材物172ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(49, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(919, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "头像";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "uID";
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "账户类型";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "uName";
            this.Column4.HeaderText = "姓名";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 45;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "性别";
            this.Column5.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Column5.Name = "Column5";
            this.Column5.Width = 40;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "uInstitute";
            this.Column6.HeaderText = "学院";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 40;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "uClassName";
            this.Column7.HeaderText = "班级";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "uSFID";
            this.Column8.HeaderText = "身份证号";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 116;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "uTelephone";
            this.Column9.HeaderText = "手机号";
            this.Column9.Name = "Column9";
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 75;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "uEmail";
            this.Column10.HeaderText = "邮箱";
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 115;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.筛选ToolStripMenuItem,
            this.toolStripSeparator1,
            this.添加用户ToolStripMenuItem,
            this.删除用户ToolStripMenuItem,
            this.更改信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 134);
            // 
            // 筛选ToolStripMenuItem
            // 
            this.筛选ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.不限ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.图书管理员ToolStripMenuItem,
            this.信息学院ToolStripMenuItem,
            this.材料学院ToolStripMenuItem});
            this.筛选ToolStripMenuItem.Name = "筛选ToolStripMenuItem";
            this.筛选ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.筛选ToolStripMenuItem.Text = "筛选";
            // 
            // 不限ToolStripMenuItem
            // 
            this.不限ToolStripMenuItem.Checked = true;
            this.不限ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.不限ToolStripMenuItem.Name = "不限ToolStripMenuItem";
            this.不限ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.不限ToolStripMenuItem.Text = "不限";
            this.不限ToolStripMenuItem.Click += new System.EventHandler(this.不限ToolStripMenuItem_Click);
            // 
            // 图书管理员ToolStripMenuItem
            // 
            this.图书管理员ToolStripMenuItem.Name = "图书管理员ToolStripMenuItem";
            this.图书管理员ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.图书管理员ToolStripMenuItem.Text = "图书管理员";
            this.图书管理员ToolStripMenuItem.Click += new System.EventHandler(this.图书管理员ToolStripMenuItem_Click);
            // 
            // 信息学院ToolStripMenuItem
            // 
            this.信息学院ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.不限ToolStripMenuItem1,
            this.计算171ToolStripMenuItem,
            this.计算172ToolStripMenuItem,
            this.信息172ToolStripMenuItem});
            this.信息学院ToolStripMenuItem.Name = "信息学院ToolStripMenuItem";
            this.信息学院ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.信息学院ToolStripMenuItem.Text = "信息学院";
            // 
            // 不限ToolStripMenuItem1
            // 
            this.不限ToolStripMenuItem1.Name = "不限ToolStripMenuItem1";
            this.不限ToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.不限ToolStripMenuItem1.Text = "不限";
            this.不限ToolStripMenuItem1.Click += new System.EventHandler(this.不限ToolStripMenuItem1_Click);
            // 
            // 计算171ToolStripMenuItem
            // 
            this.计算171ToolStripMenuItem.Name = "计算171ToolStripMenuItem";
            this.计算171ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.计算171ToolStripMenuItem.Text = "计算171";
            this.计算171ToolStripMenuItem.Click += new System.EventHandler(this.计算171ToolStripMenuItem_Click);
            // 
            // 计算172ToolStripMenuItem
            // 
            this.计算172ToolStripMenuItem.Name = "计算172ToolStripMenuItem";
            this.计算172ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.计算172ToolStripMenuItem.Text = "计算172";
            this.计算172ToolStripMenuItem.Click += new System.EventHandler(this.计算172ToolStripMenuItem_Click);
            // 
            // 信息172ToolStripMenuItem
            // 
            this.信息172ToolStripMenuItem.Name = "信息172ToolStripMenuItem";
            this.信息172ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.信息172ToolStripMenuItem.Text = "信息172";
            this.信息172ToolStripMenuItem.Click += new System.EventHandler(this.信息172ToolStripMenuItem_Click);
            // 
            // 材料学院ToolStripMenuItem
            // 
            this.材料学院ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.金属171ToolStripMenuItem,
            this.金属172ToolStripMenuItem,
            this.材物171ToolStripMenuItem,
            this.材物172ToolStripMenuItem});
            this.材料学院ToolStripMenuItem.Name = "材料学院ToolStripMenuItem";
            this.材料学院ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.材料学院ToolStripMenuItem.Text = "材料学院";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.toolStripMenuItem1.Text = "不限";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 金属171ToolStripMenuItem
            // 
            this.金属171ToolStripMenuItem.Name = "金属171ToolStripMenuItem";
            this.金属171ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.金属171ToolStripMenuItem.Text = "金属171";
            this.金属171ToolStripMenuItem.Click += new System.EventHandler(this.金属171ToolStripMenuItem_Click);
            // 
            // 金属172ToolStripMenuItem
            // 
            this.金属172ToolStripMenuItem.Name = "金属172ToolStripMenuItem";
            this.金属172ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.金属172ToolStripMenuItem.Text = "金属172";
            this.金属172ToolStripMenuItem.Click += new System.EventHandler(this.金属172ToolStripMenuItem_Click);
            // 
            // 材物171ToolStripMenuItem
            // 
            this.材物171ToolStripMenuItem.Name = "材物171ToolStripMenuItem";
            this.材物171ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.材物171ToolStripMenuItem.Text = "材物171";
            this.材物171ToolStripMenuItem.Click += new System.EventHandler(this.材物171ToolStripMenuItem_Click);
            // 
            // 材物172ToolStripMenuItem
            // 
            this.材物172ToolStripMenuItem.Name = "材物172ToolStripMenuItem";
            this.材物172ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.材物172ToolStripMenuItem.Text = "材物172";
            this.材物172ToolStripMenuItem.Click += new System.EventHandler(this.材物172ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            this.删除用户ToolStripMenuItem.Click += new System.EventHandler(this.删除用户ToolStripMenuItem_Click);
            // 
            // 更改信息ToolStripMenuItem
            // 
            this.更改信息ToolStripMenuItem.Name = "更改信息ToolStripMenuItem";
            this.更改信息ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.更改信息ToolStripMenuItem.Text = "更改信息";
            this.更改信息ToolStripMenuItem.Click += new System.EventHandler(this.更改信息ToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(662, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 33);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(740, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(33, 33);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName.Location = new System.Drawing.Point(309, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(347, 34);
            this.textName.TabIndex = 18;
            this.textName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(779, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(33, 33);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Location = new System.Drawing.Point(701, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(33, 33);
            this.btnNew.TabIndex = 22;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(914, 496);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 37);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(0, 496);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 37);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem2.Text = "系统管理员";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::图书管理系统.Properties.Resources.更改密码;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 531);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人员数据更新";
            this.Load += new System.EventHandler(this.UserUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 筛选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 不限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息学院ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 不限ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 计算171ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算172ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息172ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料学院ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 金属171ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 金属172ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材物171ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材物172ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
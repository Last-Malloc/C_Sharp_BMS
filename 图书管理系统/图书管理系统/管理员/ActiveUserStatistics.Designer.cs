namespace 图书管理系统
{
    partial class ActiveUserStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveUserStatistics));
            this.cbYear1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.学院筛选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.不限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级筛选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMonth1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonth2 = new System.Windows.Forms.ComboBox();
            this.cbYear2 = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbYear1
            // 
            this.cbYear1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbYear1.FormattingEnabled = true;
            this.cbYear1.Location = new System.Drawing.Point(139, 22);
            this.cbYear1.Name = "cbYear1";
            this.cbYear1.Size = new System.Drawing.Size(113, 33);
            this.cbYear1.TabIndex = 0;
            this.cbYear1.SelectedIndexChanged += new System.EventHandler(this.cbYear1_SelectedIndexChanged);
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
            this.Column7});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(29, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(497, 330);
            this.dataGridView1.TabIndex = 1;
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
            this.Column5.DataPropertyName = "uInstitute";
            this.Column5.HeaderText = "学院";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 35;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "uClassName";
            this.Column6.HeaderText = "班级";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 51;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "allCount";
            this.Column7.HeaderText = "活跃度";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 49;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.学院筛选ToolStripMenuItem,
            this.班级筛选ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 106);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItem1.Text = "查看其活跃度变化";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItem2.Text = "取消查看";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // 学院筛选ToolStripMenuItem
            // 
            this.学院筛选ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.不限ToolStripMenuItem,
            this.信息ToolStripMenuItem,
            this.材料ToolStripMenuItem});
            this.学院筛选ToolStripMenuItem.Name = "学院筛选ToolStripMenuItem";
            this.学院筛选ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.学院筛选ToolStripMenuItem.Text = "学院筛选";
            // 
            // 不限ToolStripMenuItem
            // 
            this.不限ToolStripMenuItem.Checked = true;
            this.不限ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.不限ToolStripMenuItem.Name = "不限ToolStripMenuItem";
            this.不限ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.不限ToolStripMenuItem.Text = "不限";
            this.不限ToolStripMenuItem.Click += new System.EventHandler(this.不限ToolStripMenuItem_Click);
            // 
            // 信息ToolStripMenuItem
            // 
            this.信息ToolStripMenuItem.Name = "信息ToolStripMenuItem";
            this.信息ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.信息ToolStripMenuItem.Text = "信息";
            this.信息ToolStripMenuItem.Click += new System.EventHandler(this.信息ToolStripMenuItem_Click);
            // 
            // 材料ToolStripMenuItem
            // 
            this.材料ToolStripMenuItem.Name = "材料ToolStripMenuItem";
            this.材料ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.材料ToolStripMenuItem.Text = "材料";
            this.材料ToolStripMenuItem.Click += new System.EventHandler(this.材料ToolStripMenuItem_Click);
            // 
            // 班级筛选ToolStripMenuItem
            // 
            this.班级筛选ToolStripMenuItem.Name = "班级筛选ToolStripMenuItem";
            this.班级筛选ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.班级筛选ToolStripMenuItem.Text = "班级筛选";
            // 
            // cbMonth1
            // 
            this.cbMonth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbMonth1.FormattingEnabled = true;
            this.cbMonth1.Items.AddRange(new object[] {
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.cbMonth1.Location = new System.Drawing.Point(258, 22);
            this.cbMonth1.Name = "cbMonth1";
            this.cbMonth1.Size = new System.Drawing.Size(81, 33);
            this.cbMonth1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(361, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "至";
            // 
            // cbMonth2
            // 
            this.cbMonth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbMonth2.FormattingEnabled = true;
            this.cbMonth2.Items.AddRange(new object[] {
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.cbMonth2.Location = new System.Drawing.Point(545, 22);
            this.cbMonth2.Name = "cbMonth2";
            this.cbMonth2.Size = new System.Drawing.Size(81, 33);
            this.cbMonth2.TabIndex = 3;
            // 
            // cbYear2
            // 
            this.cbYear2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbYear2.FormattingEnabled = true;
            this.cbYear2.Location = new System.Drawing.Point(426, 22);
            this.cbYear2.Name = "cbYear2";
            this.cbYear2.Size = new System.Drawing.Size(113, 33);
            this.cbYear2.TabIndex = 4;
            this.cbYear2.SelectedIndexChanged += new System.EventHandler(this.cbYear2_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::图书管理系统.Properties.Resources.登录按钮;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(649, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 37);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 92F;
            chartArea1.Position.Width = 95F;
            chartArea1.Position.Y = 8F;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 6F;
            legend1.Position.Width = 24F;
            legend1.Position.X = 1F;
            legend1.Position.Y = 1F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(545, 81);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "活跃度";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(420, 330);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // ActiveUserStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 458);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbMonth2);
            this.Controls.Add(this.cbYear2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbMonth1);
            this.Controls.Add(this.cbYear1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActiveUserStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "活跃读者统计";
            this.Load += new System.EventHandler(this.ActiveUserStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbMonth1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonth2;
        private System.Windows.Forms.ComboBox cbYear2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学院筛选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 不限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级筛选ToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
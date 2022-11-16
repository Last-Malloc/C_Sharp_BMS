namespace 图书管理系统
{
    partial class popularbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popularbook));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button3 = new System.Windows.Forms.Button();
            this.显示图表 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.abISBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMSDataSet8 = new 图书管理系统.BMSDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.activeBookTableAdapter = new 图书管理系统.BMSDataSetTableAdapters.activeBookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(799, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 17;
            this.button3.Text = "导出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 显示图表
            // 
            this.显示图表.AutoSize = true;
            this.显示图表.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("显示图表.BackgroundImage")));
            this.显示图表.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.显示图表.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.显示图表.Location = new System.Drawing.Point(658, 20);
            this.显示图表.Name = "显示图表";
            this.显示图表.Size = new System.Drawing.Size(126, 35);
            this.显示图表.TabIndex = 16;
            this.显示图表.Text = "显示图表";
            this.显示图表.UseVisualStyleBackColor = true;
            this.显示图表.Click += new System.EventHandler(this.显示图表_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(85, 250);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 222);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(426, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 36);
            this.textBox1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(880, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abISBNDataGridViewTextBoxColumn,
            this.abTimeDataGridViewTextBoxColumn,
            this.abCountDataGridViewTextBoxColumn,
            this.abNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.activeBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(115, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(711, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // abISBNDataGridViewTextBoxColumn
            // 
            this.abISBNDataGridViewTextBoxColumn.DataPropertyName = "abISBN";
            this.abISBNDataGridViewTextBoxColumn.HeaderText = "ISBN码";
            this.abISBNDataGridViewTextBoxColumn.Name = "abISBNDataGridViewTextBoxColumn";
            // 
            // abTimeDataGridViewTextBoxColumn
            // 
            this.abTimeDataGridViewTextBoxColumn.DataPropertyName = "abTime";
            this.abTimeDataGridViewTextBoxColumn.HeaderText = "统计时间";
            this.abTimeDataGridViewTextBoxColumn.Name = "abTimeDataGridViewTextBoxColumn";
            // 
            // abCountDataGridViewTextBoxColumn
            // 
            this.abCountDataGridViewTextBoxColumn.DataPropertyName = "abCount";
            this.abCountDataGridViewTextBoxColumn.HeaderText = "统计数量";
            this.abCountDataGridViewTextBoxColumn.Name = "abCountDataGridViewTextBoxColumn";
            // 
            // abNameDataGridViewTextBoxColumn
            // 
            this.abNameDataGridViewTextBoxColumn.DataPropertyName = "abName";
            this.abNameDataGridViewTextBoxColumn.HeaderText = "图书名称";
            this.abNameDataGridViewTextBoxColumn.Name = "abNameDataGridViewTextBoxColumn";
            // 
            // activeBookBindingSource
            // 
            this.activeBookBindingSource.DataMember = "activeBook";
            this.activeBookBindingSource.DataSource = this.bMSDataSet8;
            // 
            // bMSDataSet8
            // 
            this.bMSDataSet8.DataSetName = "BMSDataSet";
            this.bMSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(565, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "月统计",
            "季统计",
            "半年统计",
            "年统计"});
            this.comboBox1.Location = new System.Drawing.Point(281, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "请按照需求进行选择：";
            // 
            // activeBookTableAdapter
            // 
            this.activeBookTableAdapter.ClearBeforeFill = true;
            // 
            // popularbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::图书管理系统.Properties.Resources.更改密码;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 484);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.显示图表);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "popularbook";
            this.Text = "按月统计";
            this.Load += new System.EventHandler(this.popularbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button 显示图表;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private BMSDataSet bMSDataSet8;
        private System.Windows.Forms.BindingSource activeBookBindingSource;
        private BMSDataSetTableAdapters.activeBookTableAdapter activeBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn abISBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abNameDataGridViewTextBoxColumn;
    }
}
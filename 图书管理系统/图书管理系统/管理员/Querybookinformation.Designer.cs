namespace 图书管理系统
{
    partial class Querybookinformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Querybookinformation));
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bISBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTableNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCollectBooksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bStandingCropDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPubCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPubDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIntroductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMSDataSet3 = new 图书管理系统.BMSDataSet5();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bookTableAdapter = new 图书管理系统.BMSDataSet5TableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(934, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "导出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ISBN码",
            "书名",
            "作者",
            "图书类别",
            "索书号",
            "藏书量",
            "库存量",
            "出版社",
            "出版日期",
            "图书价格",
            "图书状态"});
            this.comboBox1.Location = new System.Drawing.Point(410, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 33);
            this.comboBox1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1054, 59);
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
            this.bISBNDataGridViewTextBoxColumn,
            this.bNameDataGridViewTextBoxColumn,
            this.bAuthorDataGridViewTextBoxColumn,
            this.bCategoryDataGridViewTextBoxColumn,
            this.bTableNumberDataGridViewTextBoxColumn,
            this.bCollectBooksDataGridViewTextBoxColumn,
            this.bStandingCropDataGridViewTextBoxColumn,
            this.bPubCompanyDataGridViewTextBoxColumn,
            this.bPubDateDataGridViewTextBoxColumn,
            this.bPriceDataGridViewTextBoxColumn,
            this.bIntroductionDataGridViewTextBoxColumn,
            this.bTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 290);
            this.dataGridView1.TabIndex = 11;
            // 
            // bISBNDataGridViewTextBoxColumn
            // 
            this.bISBNDataGridViewTextBoxColumn.DataPropertyName = "bISBN";
            this.bISBNDataGridViewTextBoxColumn.HeaderText = "ISBN码";
            this.bISBNDataGridViewTextBoxColumn.Name = "bISBNDataGridViewTextBoxColumn";
            // 
            // bNameDataGridViewTextBoxColumn
            // 
            this.bNameDataGridViewTextBoxColumn.DataPropertyName = "bName";
            this.bNameDataGridViewTextBoxColumn.HeaderText = "图书名称";
            this.bNameDataGridViewTextBoxColumn.Name = "bNameDataGridViewTextBoxColumn";
            // 
            // bAuthorDataGridViewTextBoxColumn
            // 
            this.bAuthorDataGridViewTextBoxColumn.DataPropertyName = "bAuthor";
            this.bAuthorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.bAuthorDataGridViewTextBoxColumn.Name = "bAuthorDataGridViewTextBoxColumn";
            // 
            // bCategoryDataGridViewTextBoxColumn
            // 
            this.bCategoryDataGridViewTextBoxColumn.DataPropertyName = "bCategory";
            this.bCategoryDataGridViewTextBoxColumn.HeaderText = "图书种类";
            this.bCategoryDataGridViewTextBoxColumn.Name = "bCategoryDataGridViewTextBoxColumn";
            // 
            // bTableNumberDataGridViewTextBoxColumn
            // 
            this.bTableNumberDataGridViewTextBoxColumn.DataPropertyName = "bTableNumber";
            this.bTableNumberDataGridViewTextBoxColumn.HeaderText = "索书号";
            this.bTableNumberDataGridViewTextBoxColumn.Name = "bTableNumberDataGridViewTextBoxColumn";
            // 
            // bCollectBooksDataGridViewTextBoxColumn
            // 
            this.bCollectBooksDataGridViewTextBoxColumn.DataPropertyName = "bCollectBooks";
            this.bCollectBooksDataGridViewTextBoxColumn.HeaderText = "藏书总量";
            this.bCollectBooksDataGridViewTextBoxColumn.Name = "bCollectBooksDataGridViewTextBoxColumn";
            // 
            // bStandingCropDataGridViewTextBoxColumn
            // 
            this.bStandingCropDataGridViewTextBoxColumn.DataPropertyName = "bStandingCrop";
            this.bStandingCropDataGridViewTextBoxColumn.HeaderText = "现存量";
            this.bStandingCropDataGridViewTextBoxColumn.Name = "bStandingCropDataGridViewTextBoxColumn";
            // 
            // bPubCompanyDataGridViewTextBoxColumn
            // 
            this.bPubCompanyDataGridViewTextBoxColumn.DataPropertyName = "bPubCompany";
            this.bPubCompanyDataGridViewTextBoxColumn.HeaderText = "出版社";
            this.bPubCompanyDataGridViewTextBoxColumn.Name = "bPubCompanyDataGridViewTextBoxColumn";
            // 
            // bPubDateDataGridViewTextBoxColumn
            // 
            this.bPubDateDataGridViewTextBoxColumn.DataPropertyName = "bPubDate";
            this.bPubDateDataGridViewTextBoxColumn.HeaderText = "出版日期";
            this.bPubDateDataGridViewTextBoxColumn.Name = "bPubDateDataGridViewTextBoxColumn";
            // 
            // bPriceDataGridViewTextBoxColumn
            // 
            this.bPriceDataGridViewTextBoxColumn.DataPropertyName = "bPrice";
            this.bPriceDataGridViewTextBoxColumn.HeaderText = "图书价格";
            this.bPriceDataGridViewTextBoxColumn.Name = "bPriceDataGridViewTextBoxColumn";
            // 
            // bIntroductionDataGridViewTextBoxColumn
            // 
            this.bIntroductionDataGridViewTextBoxColumn.DataPropertyName = "bIntroduction";
            this.bIntroductionDataGridViewTextBoxColumn.HeaderText = "图书简介";
            this.bIntroductionDataGridViewTextBoxColumn.Name = "bIntroductionDataGridViewTextBoxColumn";
            // 
            // bTypeDataGridViewTextBoxColumn
            // 
            this.bTypeDataGridViewTextBoxColumn.DataPropertyName = "bType";
            this.bTypeDataGridViewTextBoxColumn.HeaderText = "图书状态";
            this.bTypeDataGridViewTextBoxColumn.Name = "bTypeDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.bMSDataSet3;
            // 
            // bMSDataSet3
            // 
            this.bMSDataSet3.DataSetName = "BMSDataSet5";
            this.bMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(618, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 36);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(812, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(89, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "请选择并输入查询条件：";
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // Querybookinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::图书管理系统.Properties.Resources.更改密码;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 446);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Querybookinformation";
            this.Text = "查询图书信息";
            this.Load += new System.EventHandler(this.Querybookinformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private BMSDataSet5 bMSDataSet3;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BMSDataSet5TableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bISBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTableNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCollectBooksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bStandingCropDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPubCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPubDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIntroductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTypeDataGridViewTextBoxColumn;
    }
}
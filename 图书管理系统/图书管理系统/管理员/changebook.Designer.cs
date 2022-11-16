namespace 图书管理系统
{
    partial class changebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changebook));
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.bMSDataSet6 = new 图书管理系统.BMSDataSet4();
            this.bookTableAdapter = new 图书管理系统.BMSDataSet4TableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(633, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "导出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(31, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1183, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 6;
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
            this.dataGridView1.Location = new System.Drawing.Point(31, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 315);
            this.dataGridView1.TabIndex = 4;
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
            this.bPriceDataGridViewTextBoxColumn.HeaderText = "图书价格";
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
            this.bookBindingSource.DataSource = this.bMSDataSet6;
            // 
            // bMSDataSet6
            // 
            this.bMSDataSet6.DataSetName = "BMSDataSet4";
            this.bMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // changebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::图书管理系统.Properties.Resources.更改密码;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "changebook";
            this.Text = "修改图书信息";
            this.Load += new System.EventHandler(this.changebook_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BMSDataSet4 bMSDataSet6;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BMSDataSet4TableAdapters.BookTableAdapter bookTableAdapter;
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
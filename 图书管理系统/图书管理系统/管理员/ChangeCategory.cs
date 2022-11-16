using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书管理系统
{
    public partial class ChangeCategory : Form
    {
        public ChangeCategory()
        {
            InitializeComponent();
        }

        //导入book表中的部分信息
        private void ChangeCategory_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bMSDataSet1.Book”中。您可以根据需要移动或删除它。
            this.bookTableAdapter.Fill(this.bMSDataSet1.Book);
        }

        //修改按钮，修改图书类别
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要修改吗？", "修改提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string constring = @"Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
                SqlConnection conn = new SqlConnection(constring);
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    string sql = String.Format("update [Book] set bAuthor='{0}',bCategory='{1}',bPubCompany='{2}',bType='{3}' where  bName='{4}'",
                        dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value, dataGridView1.Rows[i].Cells[4].Value,
                        dataGridView1.Rows[i].Cells[0].Value);
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        comm.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                MessageBox.Show("修改成功", "修改提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        //返回主界面
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel d = new ExportToExcel();
            d.OutputAsExcelFile(dataGridView1);
        }

        private void booktypeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bMSDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

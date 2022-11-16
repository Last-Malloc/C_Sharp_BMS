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
    public partial class deletebook : Form
    {
        public deletebook()
        {
            InitializeComponent();
        }



        //删除选择信息
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int current_ro = dataGridView1.CurrentCell.RowIndex;
                String value = dataGridView1.Rows[current_ro].Cells[3].Value.ToString();
                string cancer_connString = @"Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
                SqlConnection cancer_conn = new SqlConnection(cancer_connString);
                string cancer_sql = String.Format("select count(*) from booktype where bCategory='{0}'", value);
                try
                {
                    cancer_conn.Open();
                    SqlCommand cancer_comm = new SqlCommand(cancer_sql, cancer_conn);
                    int num = (int)cancer_comm.ExecuteScalar();
                    //判断是否在另外的表中存在book的记录
                    if (num == 1)
                    {
                        MessageBox.Show("该书籍有其他信息，不能删除！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //不存在时可以进行删除操作
                    else
                    {
                        string constring = @"Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
                        SqlConnection conn = new SqlConnection(constring);
                        MessageBox.Show("删除成功！", "操作完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //在控件上删除该行
                        DataGridViewRow row = dataGridView1.Rows[current_ro];
                        dataGridView1.Rows.Remove(row);

                        //在数据库删除
                        string sql = String.Format("delete Book where bCategory='{0}'", value);
                        try
                        {
                            conn.Open();
                            SqlCommand comm = new SqlCommand(sql, conn);
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "操作数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "数据库操作错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //返回主界面
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel d = new ExportToExcel();
            d.OutputAsExcelFile(dataGridView1);
        }

        private void deletebook_Load_1(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bMSDataSet6.Book”中。您可以根据需要移动或删除它。
            this.bookTableAdapter.Fill(this.bMSDataSet6.Book);

        }
    }
}

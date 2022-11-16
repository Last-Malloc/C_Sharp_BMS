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
    
    public partial class changebook : Form
    {
        public changebook()
        {
            InitializeComponent();
        }


        //返回主界面按钮
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //修改按钮
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag=false;               
            DialogResult dr = MessageBox.Show("确定要修改吗？", "修改提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string constring = @"Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
                SqlConnection conn = new SqlConnection(constring);
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    string sql = String.Format("update [Book] set bISBN='{0}',bAuthor='{1}',bCategory='{2}',bTableNumber='{3}',bCollectBooks='{4}',bStandingCrop='{5}'," +
                        "bPubCompany='{6}',bPubDate='{7}',bPrice='{8}',bIntroduction='{9}',bType='{10}' where  bName='{11}'", dataGridView1.Rows[i].Cells[0].Value, dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value, dataGridView1.Rows[i].Cells[4].Value, dataGridView1.Rows[i].Cells[5].Value,
                        dataGridView1.Rows[i].Cells[6].Value, dataGridView1.Rows[i].Cells[7].Value, dataGridView1.Rows[i].Cells[8].Value, dataGridView1.Rows[i].Cells[9].Value, dataGridView1.Rows[i].Cells[10].Value, dataGridView1.Rows[i].Cells[11].Value, dataGridView1.Rows[i].Cells[1].Value);

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
                        flag = true;
                        conn.Close();
                    }
                }
                if(flag==true)
                {
                    MessageBox.Show("修改成功", "修改提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;                   
                }
                else
                {
                    MessageBox.Show("修改失败", "修改提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel d = new ExportToExcel();
            d.OutputAsExcelFile(dataGridView1);
        }

        private void changebook_Load_1(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bMSDataSet4.Book”中。您可以根据需要移动或删除它。
            this.bookTableAdapter.Fill(this.bMSDataSet6.Book);

        }
    }
}
/*
 *  string sql = String.Format("update [Book] set bISBN='{0}',bName='{1}',bAuthor='{2}',bCategory='{3}',bTableNumber='{4}',bCollectBooks='{5}',bStandingCrop='{6}'," +
                        "bPubCompany='{7}',bPubDate='{8}',bPrize='{9}',bIntroduction='{10}',bType='{11}' where  bName='{4}'",
                        dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value, dataGridView1.Rows[i].Cells[4].Value,
                        dataGridView1.Rows[i].Cells[0].Value);
 */

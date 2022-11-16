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
    public partial class Querybookinformation : Form
    {
        public Querybookinformation()
        {
            InitializeComponent();
        }

        public int count = 0;//记录查询图书次数

        //导入数据库中book表的所有信息
        private void Querybookinformation_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bMSDataSet3.Book”中。您可以根据需要移动或删除它。
            this.bookTableAdapter.Fill(this.bMSDataSet3.Book);

        }



        //按照输入的信息进行查询
        private void button1_Click(object sender, EventArgs e)
        {
            string type = comboBox1.SelectedItem.ToString();

            string kind = "";

            switch (type)
            {
                case "ISBN码":
                    kind = "bISBN";
                    break;
                case "书名":
                    kind = " bName";
                    break;
                case "图书类别":
                    kind = "bCategory";
                    break;
                case "作者":
                    kind = "bAuthor";
                    break;
                case "索书号":
                    kind = "bTableNumber";
                    break;
                case "藏书量":
                    kind = "bCollectBooks";
                    break;
                case "库存量":
                    kind = "bStandingCrop";
                    break;
                case "出版社":
                    kind = "bPubCompany";
                    break;
                case "出版日期":
                    kind = "bPubDate";
                    break;
                case "图书价格":
                    kind = "bPrice";
                    break;
                case "图书状态":
                    kind = "bType";
                    break;
            }

            string information = textBox1.Text.Trim();

            if (information == "")
            {
                MessageBox.Show("请输入查询图书信息！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
                SqlConnection conn = new SqlConnection(connstring);
                string sql = "select * from [Book] where " + kind + "=" + "'" + information + "'";



                //bISBN,bName,bAuthor,bCategory,bTableNumber,bCollectBooks,bStandingCrop,bPubCompany,bPubDate,bPrice,bIntroduction,bType
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Book");
                try
                {
                    dataGridView1.DataSource = ds;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                dataGridView1.DataMember = "Book";
                conn.Close();

                //统计查询图书的ISBN码
                SqlConnection connISBN = new SqlConnection(connstring);
                connISBN.Open();
                string sqlISBN = "select bISBN from [Book] where " + kind + "=" + "'" + information + "'";
                SqlCommand commISBN = new SqlCommand(sqlISBN, connISBN);
                string isbn = Convert.ToString(commISBN.ExecuteScalar());
                Console.WriteLine(isbn);
                connISBN.Close();

                //获得active表中的统计次数
                string sqlcnt = String.Format("select abCount from [activeBook] where abISBN='{0}'", isbn);
                SqlConnection connCnt = new SqlConnection(connstring);
                connCnt.Open();
                SqlCommand commCnt = new SqlCommand(sqlcnt, connCnt);
                count = Convert.ToInt32(commCnt.ExecuteScalar());
                count++;
                Console.WriteLine(count);


                //更新activebook表里面的次数
                string sqlupdate = "update [activeBook] set abCount=" + count + "where abISBN=" + "'" + isbn + "'";
                SqlConnection connupdate = new SqlConnection(connstring);
                connupdate.Open();
                SqlCommand commupdate = new SqlCommand(sqlupdate, connupdate);
                commupdate.ExecuteNonQuery();
                connupdate.Close();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

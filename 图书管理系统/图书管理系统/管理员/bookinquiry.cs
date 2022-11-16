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
    public partial class bookinquiry : Form
    {
        public bookinquiry()
        {
            InitializeComponent();
        }

        //导入数据库中的部分数据
        private void bookinquiry_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bMSDataSet2.Book”中。您可以根据需要移动或删除它。
            this.bookTableAdapter.Fill(this.bMSDataSet2.Book);

        }

        //点击确认按钮，获得输入类别，并返回数据库中与之类别相同的数据
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();

            //判断是否输入为空
            if (name == "")
            {
                MessageBox.Show("请输入图书类别！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //返回输入类别的数据
            else
            {
                string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
                SqlConnection conn = new SqlConnection(connstring);
                string sql = String.Format("select bName, bAuthor,bCategory,bPubcompany,bType from [Book] where bCategory='{0}'", name);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                if(comm.ExecuteScalar()==null)
                {
                    MessageBox.Show("请输入存在类别！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
    }
}

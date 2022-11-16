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
    public partial class AddCategory : Form
    {
        // public event EventHandler Fanhui;//返回事件

        public AddCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获得文本框中输入的图书类别
            //当为空时，显示提示窗口
            //不为空时，连接数据库并写入数据库

            string name = txt1.Text.Trim();
            string id = textBox1.Text.Trim();

            if (name == "" || id == "")
            {
                MessageBox.Show("请输入完整的图书信息！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //声明连接数据库
            string connstring = "Data Source=.;Database=BMS;User ID=sa;Pwd=648371";
            SqlConnection conn = new SqlConnection(connstring);


            if (name == "")
            {
                MessageBox.Show("请输入图书类别名称", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string sql = String.Format("insert into [booktype] values('{0}','{1}')", name, id);
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
                    MessageBox.Show("插入成功", "成功提示", MessageBoxButtons.OK);
                }

               
            }
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bMSDataSet7.booktype”中。您可以根据需要移动或删除它。
            this.booktypeTableAdapter.Fill(this.bMSDataSet7.booktype);

        }

        //返回主界面
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void AddCategory_Load_1(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bMSDataSet1.booktype”中。您可以根据需要移动或删除它。
            this.booktypeTableAdapter.Fill(this.bMSDataSet7.booktype);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

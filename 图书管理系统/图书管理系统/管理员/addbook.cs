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
    public partial class addbook : Form
    {
        public addbook()
        {
            InitializeComponent();
        }

        public string isbn;
        public string name;
        public string author;
        public string catagory;
        public string tablenumber;
        public string collectbook;
        public string standing;
        public string pubcompany;
        public string pubdate;
        public string prize;
        public string introdution;
        public string type;



        //增加图书信息
        private void button1_Click(object sender, EventArgs e)
        {

            isbn = textBox1.Text.Trim();
            name = textBox2.Text.Trim();
            author = textBox3.Text.Trim();
            catagory = textBox4.Text.Trim();
            tablenumber = textBox5.Text.Trim();
            collectbook = textBox6.Text.Trim();
            standing = textBox7.Text.Trim();
            pubcompany = textBox8.Text.Trim();
            pubdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            prize = textBox9.Text.Trim();
            introdution = textBox10.Text.Trim();
            type = textBox11.Text.Trim();

            //判断各个输入信息的正确形式
            if (name == "" || author == "" || catagory == "" || tablenumber == "" || Int32.Parse(collectbook) < 0 || collectbook == ""
                 || standing == "" || Int32.Parse(standing) < 0 || pubcompany == "" || prize == "" || Double.Parse(prize) < 0 || introdution == "" || type == "")
            {
                MessageBox.Show("请输入图书的完整信息！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            //判断ISBN码的正确格式
            if (isbn == "" || isbn.Length != 17)
            {
                MessageBox.Show("请输入图书的完整信息！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                string a = isbn;
                int b = Int32.Parse(a.Substring(0, 3));
                int c = Int32.Parse(a.Substring(6, 4));
                int d = Int32.Parse(a.Substring(11, 4));
                int x = Int32.Parse(a.Substring(4, 1));
                int y = Int32.Parse(a.Substring(16, 1));

                if (b < 0 || b > 999)
                {
                    MessageBox.Show("请按照正确的ISBN码输入！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //
                if (a[3] != '-' || x < 0 || x > 9)
                {
                    Console.WriteLine(a[3]);
                    Console.WriteLine(a[4]);
                    MessageBox.Show("请按照正确的ISBN码输入！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (a[5] != '-' || c < 0 || c > 9999)
                {
                    MessageBox.Show("请按照正确的ISBN码输入！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (a[10] != '-' || d < 0 || d > 9999)
                {
                    MessageBox.Show("请按照正确的ISBN码输入！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (a[15] != '-' || y < 0 || y > 9)
                {
                    MessageBox.Show("请按照正确的ISBN码输入！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            //判断价格：
            if (Double.Parse(prize) < 0)
            {
                MessageBox.Show("请输入图书的正确价格！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //判断索书号的格式
            string f = tablenumber;
            if (f[0] < 'A' || f[0] > 'Z' || f[1] < 'A' || f[1] > 'Z')
            {
                MessageBox.Show("请输入图书索书号的正确形式！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //||f[3]<0||f[3]>9

            if (f[2] != '-')
            {
                MessageBox.Show("请输入图书索书号的正确形式！", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //判断完上述信息，插入到数据库中

            //声明连接数据库
            string connstring = "Data Source=.;Database=BMS;User ID=sa;Pwd=648371";
            SqlConnection conn = new SqlConnection(connstring);

            string sql = String.Format("insert into [Book] values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", isbn, name, author, catagory, tablenumber,
                collectbook, standing, pubcompany, pubdate, prize, introdution, type);

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
                MessageBox.Show("数据库操作成功", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //返回主界面
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

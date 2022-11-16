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
    public partial class xujie : Form
    {
        public xujie()
        {
            InitializeComponent();
        }

        public static string id;
        public static string name;
        public static string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";

        private void button1_Click(object sender, EventArgs e)
        {
            id = textBox1.Text.Trim();
            if (id == "")
            {
                MessageBox.Show("请输入具体信息！", "续借失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //判断该人是否存在
            string sqlexsits = "select uID from [UserToLoan] where uID='" + id + "'";
            SqlConnection connexsits = new SqlConnection(connstring);
            connexsits.Open();
            SqlCommand commexsits = new SqlCommand(sqlexsits, connexsits);
            int num = Convert.ToInt32(commexsits.ExecuteScalar());
            if (num == 0)
            {
                MessageBox.Show("请输入正确账号！", "续借失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            name = textBox2.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("请输入具体信息！", "续借失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //通过图书名称获得ISBN码
            string sqlISBN = "select bISBN from [Book] where bName='" + name + "'";
            SqlConnection connISBN = new SqlConnection(connstring);
            connISBN.Open();
            SqlCommand commISBN = new SqlCommand(sqlISBN, connISBN);
            string isbn = commISBN.ExecuteScalar().ToString();
            Console.WriteLine(isbn);
            if (isbn == "")
            {
                MessageBox.Show("请输入存在图书名称！", "借书失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //获得Loan表中对应图书的续借次数
            string sqlcnt = "select isReborrow from [Loan] where uID='" + id + "' and bISBN='" + isbn + "'";
            SqlConnection conncnt = new SqlConnection(connstring);
            conncnt.Open();
            SqlCommand commcnt = new SqlCommand(sqlcnt, conncnt);
            int count = Convert.ToInt32(commcnt.ExecuteScalar());
            count++;

            //更新Loan表里面的次数
            string sqlupdate = "update [Loan] set isReborrow=" + count + "where uID=" + "'" + id + "' and bISBN='" + isbn + "'";
            SqlConnection connupdate = new SqlConnection(connstring);
            connupdate.Open();
            SqlCommand commupdate = new SqlCommand(sqlupdate, connupdate);
            commupdate.ExecuteNonQuery();
            connupdate.Close();

            MessageBox.Show("续借成功，请按期归还！", "借书成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //增加人员活跃度
            Program.addActiveUserStatistics(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FaceLogin faceLoginWindow = new FaceLogin();
            faceLoginWindow.ShowDialog();
            textBox1.Text = faceLoginWindow.id;
        }
    }
}

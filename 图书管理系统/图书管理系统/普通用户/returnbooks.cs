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
    public partial class returnbooks : Form
    {
        public returnbooks()
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
                MessageBox.Show("请输入正确账号！", "还书失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            name = textBox2.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("请输入具体信息！", "续借失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //通过图书名称获得ISBN码
            string sqlISBN = "select bISBN from [Book] where bISBN='" + name + "'";
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


            //判断是否欠费
            //获得此人的续借次数
            string sqlreborrow = "select isReBorrow from [Loan] where uID='" + id + "'";
            SqlConnection connreborrow = new SqlConnection(connstring);
            connreborrow.Open();
            SqlCommand commreborrow = new SqlCommand(sqlreborrow, connreborrow);
            int cntreborrow = Convert.ToInt32(commreborrow.ExecuteScalar());
            connreborrow.Close();
            //Console.WriteLine(cntreborrow);



            //获得此人的最大借阅天数
            string sqlday = "select tMaxDay from [UserToLoan] where uID='" + id + "'";
            SqlConnection connday = new SqlConnection(connstring);
            connday.Open();
            SqlCommand commday = new SqlCommand(sqlday, connday);
            int cntday = Convert.ToInt32(commday.ExecuteScalar());
            connday.Close();

            //假设存在续借，将最大借阅天数*续借次数
            if (cntreborrow != 0)
            {
                cntday *= cntreborrow;
            }


            //获得当前日期
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            //在Loan表获得借书时的日期
            string sqlloandate = "select loanDate from [Loan] where uID='" + id + "'";
            SqlConnection connloandate = new SqlConnection(connstring);
            connloandate.Open();
            SqlCommand commloandate = new SqlCommand(sqlloandate, connloandate);
            string loandate = commloandate.ExecuteScalar().ToString();
            connloandate.Close();

            //获得借书天数
            string sqlborrowdays = "select DATEDIFF(DAY,'" + loandate + "','" + date + "')";
            SqlConnection connborrowdays = new SqlConnection(connstring);
            connborrowdays.Open();
            SqlCommand commborrowdays = new SqlCommand(sqlborrowdays, connborrowdays);
            int cntborrowdays = Convert.ToInt32(commborrowdays.ExecuteScalar());
            connborrowdays.Close();

            if (cntborrowdays > cntday)
            {
                double money = (cntborrowdays - cntday) * 0.1;
                string a = money.ToString();
                MessageBox.Show("您已逾期欠费，请先缴费！欠费金额为：" + a, "还书失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //删除该条借书信息
            string sqldelect = "delete [Loan] where uID='" + id + "' and bISBN='" + isbn + "'";
            SqlConnection conndelete = new SqlConnection(connstring);
            conndelete.Open();
            SqlCommand commdelete = new SqlCommand(sqldelect, conndelete);
            commdelete.ExecuteNonQuery();
            conndelete.Close();


            MessageBox.Show("还书成功！", "还书成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

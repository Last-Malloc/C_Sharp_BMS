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
    public partial class borrowbooks : Form
    {
        public borrowbooks()
        {
            InitializeComponent();
        }

        public static string uid;
        public static string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
        private void button1_Click(object sender, EventArgs e)
        {
            //获得读者证件号和图书名称
            string id = textBox1.Text.Trim();

            if (id == "")
            {
                MessageBox.Show("请输入具体信息！", "借书失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uid = id;
            //连接借阅表，查看此人的各项信息
            //声明连接数据库语句
            //string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";


            //判断该人是否存在
            /*string sqlexsits = "select uID from [UserToLoan] where uID='" + id + "'";
            SqlConnection connexsits = new SqlConnection(connstring);
            connexsits.Open();
            SqlCommand commexsits = new SqlCommand(sqlexsits, connexsits);
           int num = Convert.ToInt32(commexsits.ExecuteScalar());
            if (num == 0)
            {
                MessageBox.Show("请输入正确账号！", "借书失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            //判断该人的借书数量是否到达上界
            //获得最大的借书数量
            string sqlborrowcnt = "select tMaxNum from [UserToLoan] where uID='" + id + "'";
            SqlConnection connborrowcnt = new SqlConnection(connstring);
            connborrowcnt.Open();
            SqlCommand commborrowcnt = new SqlCommand(sqlborrowcnt, connborrowcnt);
            int borrowcnt = Convert.ToInt32(commborrowcnt.ExecuteScalar());
            connborrowcnt.Close();

            //获得当前借书数量select count(*) from loan where uID = 1704040213

            string sqlnowcnt = "select count(*) from [Loan] where uID='" + id + "'";
            SqlConnection connnowcnt = new SqlConnection(connstring);
            connnowcnt.Open();
            SqlCommand commnowcnt = new SqlCommand(sqlnowcnt, connnowcnt);
            int nowcnt = Convert.ToInt32(commnowcnt.ExecuteScalar());
            connnowcnt.Close();

            if (nowcnt > borrowcnt)
            {
                MessageBox.Show("您的借书数量已达上限！", "借书失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //获得此人的最大借阅天数
            string sqlday = "select tMaxDay from [UserToLoan] where uID='" + id + "'";
            SqlConnection connday = new SqlConnection(connstring);
            connday.Open();
            SqlCommand commday = new SqlCommand(sqlday, connday);
            int cntday = Convert.ToInt32(commday.ExecuteScalar());
            connday.Close();
            //Console.WriteLine(cntday);

            //获得此人的续借次数
            string sqlreborrow = "select isReBorrow from [Loan] where uID='" + id + "'";
            SqlConnection connreborrow = new SqlConnection(connstring);
            connreborrow.Open();
            SqlCommand commreborrow = new SqlCommand(sqlreborrow, connreborrow);
            int cntreborrow = Convert.ToInt32(commreborrow.ExecuteScalar());
            connreborrow.Close();
            //Console.WriteLine(cntreborrow);

            //假设存在续借，将最大借阅天数*续借次数
            if (cntreborrow != 0)
            {
                cntday *= cntreborrow;
            }

            //获得当前如期
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            //Console.WriteLine(date);

            //在Loan表获得借书时的日期
            string sqlloandate = "select loanDate from [Loan] where uID='" + id + "'";
            SqlConnection connloandate = new SqlConnection(connstring);
            connloandate.Open();
            SqlCommand commloandate = new SqlCommand(sqlloandate, connloandate);
            string loandate = commloandate.ExecuteScalar().ToString();
            connloandate.Close();
            //Console.WriteLine(loandate);

            //获得借书天数
            string sqlborrowdays = "select DATEDIFF(DAY,'" + loandate + "','" + date + "')";
            SqlConnection connborrowdays = new SqlConnection(connstring);
            connborrowdays.Open();
            SqlCommand commborrowdays = new SqlCommand(sqlborrowdays, connborrowdays);
            int cntborrowdays = Convert.ToInt32(commborrowdays.ExecuteScalar());
            connborrowdays.Close();

            //判断是否逾期
            if (cntborrowdays > cntday)
            {
                //double money = (cntreborrow - cntday) * 0.1;
                MessageBox.Show("您所借图书已经超过归还日期，请先归还图书！", "借书失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string bookname = textBox2.Text.Trim();
            if (bookname == "")
            {
                MessageBox.Show("请输入图书名称！", "借书失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //获得当前书的序号
            string sqlnum = "select num from [Loan] where uID='" + id + "'";
            SqlConnection connnum = new SqlConnection(connstring);
            connnum.Open();
            SqlCommand commnum = new SqlCommand(sqlnum, connnum);
            int number = Convert.ToInt32(commnum.ExecuteScalar());
            number++;
            connnum.Close();


            //通过图书名称获得ISBN码
            string sqlISBN = "select bISBN from [Book] where bName='" + bookname + "'";
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

            connISBN.Close();

            //获得日期
            string date1 = DateTime.Now.ToString("yyyy-MM-dd");

            //首次借书时，续借次数为0
            int reborrow = 0;

            //插入到Loan表
            string sqlinsert = "insert into [Loan] values('" + uid + "','" + isbn + "','" + date1 + "','" + reborrow + "','"+number+"')";
            Console.WriteLine(sqlinsert);
            SqlConnection conninsert = new SqlConnection(connstring);
            conninsert.Open();
            try
            {
                SqlCommand comminsert = new SqlCommand(sqlinsert, conninsert);
                comminsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conninsert.Close();
                MessageBox.Show("借书成功，请按期归还！", "借书成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

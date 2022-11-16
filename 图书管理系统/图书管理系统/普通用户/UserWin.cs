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
    public partial class UserWin : Form
    {
        public event EventHandler ZhuXiao;//注销事件
        public event EventHandler TuiChu;//退出事件
        public string loginUID;//登陆的账户ID

        private SqlConnection conn;
        private SqlDataReader dr;

        //初始化
        public UserWin(string id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loginUID = id;
        }

        //菜单栏注销按钮
        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认注销", "注销", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                ZhuXiao(this, e);
            }
        }

        //菜单栏退出按钮
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TuiChu(this, e);
        }

        //关闭窗口
        private void UserWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            TuiChu(this, e);
        }

        //我的信息
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyInfo myInfoWindow = new MyInfo(loginUID);
            myInfoWindow.ShowDialog();
            UserWin_Load(this, e);
            this.Show();
        }

        //更改密码
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePW changePWWindow = new ChangePW(loginUID, true);
            changePWWindow.ShowDialog();
            this.Show();
        }

        //重新加载头像和姓名信息(此项可能被更改后需要重新进行加载)
        private void UserWin_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
            try
            {
                string sql = "select uHeadPic, uName from theUser where uID = " + loginUID;
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    lbName.Text = "您好，" + (string)dr[1];
                    picBoxHead.BackgroundImage = Image.FromFile((string)dr[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowbooks form8 = new borrowbooks();
            this.Visible = false;
            form8.ShowDialog();
            this.Visible = true;
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnbooks form9 = new returnbooks();
            this.Visible = false;
            form9.ShowDialog();
            this.Visible = true;
        }

        private void 续借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xujie form10 = new xujie();
            this.Visible = false;
            form10.ShowDialog();
            this.Visible = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaceRegister faceRegisterWindow = new FaceRegister(loginUID);
            faceRegisterWindow.ShowDialog();
            this.Show();
        }

        private void 二维码还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            普通用户.mareturn form = new 普通用户.mareturn();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }
    }
}

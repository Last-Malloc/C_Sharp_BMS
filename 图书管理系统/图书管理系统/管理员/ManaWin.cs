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
    public partial class ManaWin : Form
    {
        public event EventHandler ZhuXiao;//注销事件
        public event EventHandler TuiChu;//退出事件
        public string loginUID;//登陆的账户ID

        private SqlConnection conn;
        private SqlDataReader dr;

        //初始化
        public ManaWin(string id)
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
        private void ManaWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            TuiChu(this, e);
        }

        //更改密码
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePW changePWWindow = new ChangePW(loginUID, true);
            changePWWindow.ShowDialog();
            this.Show();
        }

        //我的信息
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyInfo myInfoWindow = new MyInfo(loginUID);
            myInfoWindow.ShowDialog();
            ManaWin_Load(this, e);
            this.Show();
        }

        //重新加载头像和姓名信息(此项可能被更改后需要重新进行加载)
        private void ManaWin_Load(object sender, EventArgs e)
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

        //人员类别管理
        private void 用户类别管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PeopleTypeMana peopleTypeManaWindow = new PeopleTypeMana();
            peopleTypeManaWindow.ShowDialog();
            this.Show();
        }

        private void 活跃读者统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActiveUserStatistics acUserWindow = new ActiveUserStatistics();
            acUserWindow.ShowDialog();
            this.Show();
        }

        //账号解封
        private void 账号解封ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnsealAccount unsealAccountWindow = new UnsealAccount(loginUID);
            unsealAccountWindow.ShowDialog();
            this.Show();
        }

        private void 人员信息更新ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserUpdate userUpdateWindow = new UserUpdate(loginUID);
            userUpdateWindow.ShowDialog();
            this.Show();
        }

        //人脸识别注册
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaceRegister faceRegisterWindow = new FaceRegister(loginUID);
            faceRegisterWindow.ShowDialog();
            this.Show();
        }

        //--------------------------------------------------------------
        private void 热门图书统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popularbook form7 = new popularbook();
            this.Visible = false;
            form7.ShowDialog();
            this.Visible = true;
        }

        private void 手动输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory form = new AddCategory();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void 二维码输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            erweima form11 = new erweima();
            this.Visible = false;
            form11.ShowDialog();
            this.Visible = true;
        }

        private void 修改类别名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeCategory form1 = new ChangeCategory();
            this.Visible = false;
            form1.ShowDialog();
            this.Visible = true;
        }

        private void 图书类别查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookinquiry form2 = new bookinquiry();
            this.Visible = false;
            form2.ShowDialog();
            this.Visible = true;
        }

        private void 手动输入ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addbook form3 = new addbook();
            this.Visible = false;
            form3.ShowDialog();
            this.Visible = true;
        }

        private void 修改图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changebook form4 = new changebook();
            this.Visible = false;
            form4.ShowDialog();
            this.Visible = true;
        }

        private void 查询图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Querybookinformation form5 = new Querybookinformation();
            this.Visible = false;
            form5.ShowDialog();
            this.Visible = true;
        }

        private void 删除图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletebook form6 = new deletebook();
            this.Visible = false;
            form6.ShowDialog();
            this.Visible = true;
        }

        private void 生成图书数据码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            管理员.addma form = new 管理员.addma();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            addbook form3 = new addbook();
            this.Visible = false;
            form3.ShowDialog();
            this.Visible = true;
        }
    }
}

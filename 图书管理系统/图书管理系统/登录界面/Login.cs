using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;

namespace 图书管理系统
{
    struct RecentInfo//存储最近登录账户部分信息（以减少对数据库的访问）
    {
        public bool antoLogin;//自动登录
        public bool rememPW;//记住密码
        public string id;
        public string password;//密码
    }

    public partial class Login : Form
    {
        string connString = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
        bool showPW = false;//显示/隐藏密码标志
        private List<Image> images = new List<Image>();//泛型集合，用来存储6个最近登录用户头像图片
        RecentInfo[] recentInfo;//存储6个最近登录账户的记住密码和自动登录信息

        ManaWin managerWindow;//管理员窗口
        UserWin userWindow;//用户窗口
        
        SqlDataReader dr;
        SqlConnection conn;

        //初始化窗口
        public Login()
        {
            InitializeComponent();
            
            comboID.DrawMode = DrawMode.OwnerDrawFixed;//使comboBox可以绘制Item
            comboID.DrawItem += comboID_DrawItem;
            AddToComboID();
            timer1.Enabled = true;
            timer1.Interval = 1000;//计时周期为1s
        }

        //ID输入框填充最近登录
        public void AddToComboID()
        {
            try
            {
                string sql = "select recent.*, theUser.uHeadPic, theUser.uPW from recent, theUser where recent.rID = theUser.uID ORDER BY rInsertTime DESC";
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();

                comboID.Items.Clear();
                images.Clear();//清空之前存储的image
                recentInfo = new RecentInfo[6];
                int cnt = 0;
                while (dr.Read() && cnt < 6)//仅显示最近6条登录记录
                {
                    string url = (string)dr[4];
                    images.Add(Image.FromFile(url));
                    comboID.Items.Add((string)(dr[0]));
                    recentInfo[cnt].antoLogin = (bool)dr[2];//自动登录
                    recentInfo[cnt].rememPW = (bool)dr[1];//记住密码
                    recentInfo[cnt].password = (string)dr[5];//密码
                    recentInfo[cnt].id = (string)dr[0];//账户
                    ++cnt;
                }
                comboID.SelectedIndex = 0;
                pictureBox1.BackgroundImage = images[0];
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

        //显示/隐藏密码
        private void button2_Click(object sender, EventArgs e)
        {
            if (showPW)
            {
                showPW = false;
                textPW.PasswordChar = '*';
                button2.BackgroundImage = Image.FromFile("..\\..\\图片\\小按钮\\隐藏密码.png");
            }
            else
            {
                showPW = true;
                textPW.PasswordChar = new Char();
                button2.BackgroundImage = Image.FromFile("..\\..\\图片\\小按钮\\显示密码.png");
            }
        }

        //登录按钮响应函数------
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //验证账户/密码是否为空
            string user = comboID.Text;
            if (user.Length == 0)
            {
                MessageBox.Show("请输入用户名！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboID.Focus();
                return;
            }
            string password = textPW.Text;
            if (password.Length == 0)
            {
                MessageBox.Show("请输入密码！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPW.Focus();
                return;
            }

            string sql = "select uID, uPW, uType, uErrorCnt from theUser where uID = " + user + " and (uType = '系管' OR uType = '图管')";
            try
            {
                //数据库中读取
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();

                //用户名存在
                if (dr.Read())
                {
                    //错误次数达到上限3，无法登陆
                    if ((int)dr[3] == 3)
                    {
                        if ((string)dr[2] == "系管")
                        {
                            MessageBox.Show("您的系统管理员账号已被锁定，请联系其他系统管理员解锁！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("您的图书管理员账号已被锁定，请联系系统管理员解锁！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if ((int)dr[3] != 0)
                        {
                            CheckCode checkCodeWindow = new CheckCode();
                            checkCodeWindow.ShowDialog();
                            bool flag = checkCodeWindow.passCheckCode;
                            if (!flag)
                                return;//没有通过验证码，退出登录
                        }
                        //密码正确
                        if ((string)dr[1] == password)
                        {
                            MessageBox.Show("欢迎进入图书管理系统", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //更新最近登录表（删除重建）且ErrorCnt置0
                            int rrp = 0, ral = 0;
                            if (cbAutoLogin.Checked)
                                ral = 1;
                            if (cbRememPW.Checked)
                                rrp = 1;
                            string sql1 = "delete from recent where rID = " + user;
                            string sql2 = "insert into recent(rID, rRememPW, rAutoLogin) VALUES(" + user + ", " + rrp + ", " + ral + ")";
                            string sql3 = "update theUser set uErrorCnt = 0 where uID = " + user;
                            SqlConnection conn2 = new SqlConnection(connString);
                            conn2.Open();
                            SqlCommand comm2 = new SqlCommand(sql1, conn2);
                            comm2.ExecuteNonQuery();
                            comm2.CommandText = sql2;
                            comm2.ExecuteNonQuery();
                            comm2.CommandText = sql3;
                            comm2.ExecuteNonQuery();
                            conn2.Close();


                            if ((string)dr[2] == "系管")
                            {
                                //系统管理员成功登录
                                managerWindow = new ManaWin(user);
                                //订阅事件
                                managerWindow.ZhuXiao += new EventHandler(OnZhuxiaoClicked);
                                managerWindow.TuiChu += new EventHandler(OnTuichuClicked);
                                this.Hide();
                                managerWindow.Show();
                            }
                            else
                            {
                                //图书管理员成功登录
                                userWindow = new UserWin(user);
                                //订阅事件
                                userWindow.ZhuXiao += new EventHandler(OnZhuxiaoClicked);
                                userWindow.TuiChu += new EventHandler(OnTuichuClicked);
                                this.Hide();
                                userWindow.Show();
                            }
                        }
                        //密码错误
                        else
                        {
                            int errorCnt = (int)dr[3] + 1;
                            if (errorCnt == 3)
                            {
                                if ((string)dr[2] == "系管")
                                {
                                    MessageBox.Show("您的系统管理员账号已被锁定，请联系其他系统管理员解锁！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show("您的图书管理员账号已被锁定，请联系系统管理员解锁！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("您输入的用户名或密码错误，错误次数" + errorCnt + "次，连续3次错误账号将被永久锁定！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            //更新数据库错误次数
                            string sqlStr = "UPDATE theUser SET uErrorCnt = " + errorCnt + "WHERE uID = " + user;
                            SqlConnection conn2 = new SqlConnection(connString);
                            conn2.Open();
                            SqlCommand comm2 = new SqlCommand(sqlStr, conn2);
                            comm2.ExecuteNonQuery();
                            conn2.Close();
                        }
                    }
                }
                else//用户名不存在
                {
                    MessageBox.Show("用户不存在或非管理员用户！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
        }

        //关闭窗口
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        //注销事件响应
        private void OnZhuxiaoClicked(object sender, EventArgs e)
        {
            this.Show();
            AddToComboID();//重新加载最近登录
        }

        //退出事件响应
        private void OnTuichuClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        //ID输入框选中Item变化的响应（更新头像，更新选项）------
        private void comboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboID.SelectedIndex;
            pictureBox1.BackgroundImage = images[index];
            if(recentInfo[index].antoLogin)//自动登录信息
            {
                cbAutoLogin.Checked = true;
                cbRememPW.Checked = true;
            }
            else
            {
                cbAutoLogin.Checked = false;
            }
            if (recentInfo[index].rememPW)
            {
                cbRememPW.Checked = true;
                textPW.Text = recentInfo[index].password;
            }
            else
            {
                cbRememPW.Checked = false;
                textPW.Text = "";
            }
        }

        //绘制comboID的item
        private void comboID_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawImage(images[e.Index], 4, e.Bounds.Y + 2, 23, 23);
            e.Graphics.DrawString(comboID.Items[e.Index].ToString(), new Font("黑体", 22), new SolidBrush(Color.Black), 30, e.Bounds.Y + 1);
        }

        //自动登录框选中的处理方法（自动将记住密码框选中）
        private void cbAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAutoLogin.Checked)
            {
                cbRememPW.Checked = true;
            }
        }

        //右键菜单删除单个最近登录账号
        private void 删除该账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = comboID.SelectedItem.ToString();
            try
            {
                string sql = "delete from recent where rID = " +  id;
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
            AddToComboID();
        }

        //更改密码按钮处理函数
        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboID.SelectedIndex;
            ChangePW changePWWindow = new ChangePW(recentInfo[index].id, false);
            this.Hide();
            changePWWindow.ShowDialog();
            this.Show();
        }

        //显示登录界面一秒后根据当前自动登录情况自动登录
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (cbAutoLogin.Checked)
            {
                AutoLogin autoLoginWindow = new AutoLogin();//自动登录窗口
                autoLoginWindow.ShowDialog();//显示模态对话框
                if (autoLoginWindow.passAutoLogin)
                {
                    btnLogin_Click(sender, e);
                }
            }
        }

        //人脸识别登录按钮
        private void button1_Click_1(object sender, EventArgs e)
        {
            FaceLogin faceLoginWindow = new FaceLogin();
            faceLoginWindow.ShowDialog();
            if (faceLoginWindow.id.Length == 10)
            {
                try
                {
                    string sql = "select uType from theUser where uID = '" + faceLoginWindow.id + "'";
                    conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    dr = comm.ExecuteReader();
                   
                    if (dr.Read())
                    {
                        if ((string)dr[0] == "系管")
                        {
                            //系统管理员成功登录
                            managerWindow = new ManaWin(faceLoginWindow.id);
                            //订阅事件
                            managerWindow.ZhuXiao += new EventHandler(OnZhuxiaoClicked);
                            managerWindow.TuiChu += new EventHandler(OnTuichuClicked);
                            this.Hide();
                            managerWindow.Show();
                        }
                        else
                        {
                            //图书管理员成功登录
                            userWindow = new UserWin(faceLoginWindow.id);
                            //订阅事件
                            userWindow.ZhuXiao += new EventHandler(OnZhuxiaoClicked);
                            userWindow.TuiChu += new EventHandler(OnTuichuClicked);
                            this.Hide();
                            userWindow.Show();
                        }
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
        }

        private void btnEmailLogin_Click(object sender, EventArgs e)
        {
            登录界面.email email = new 登录界面.email();
            this.Visible = false;
            email.ShowDialog();
            this.Visible = true;
            try
            {
                string sql = "select uType, uID from theUser where uEmail = '" + email.email1 + "'";
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    if ((string)dr[0] == "系管")
                    {
                        //系统管理员成功登录
                        managerWindow = new ManaWin((string)dr[1]);
                        //订阅事件
                        managerWindow.ZhuXiao += new EventHandler(OnZhuxiaoClicked);
                        managerWindow.TuiChu += new EventHandler(OnTuichuClicked);
                        this.Hide();
                        managerWindow.Show();
                    }
                    else
                    {
                        //图书管理员成功登录
                        userWindow = new UserWin((string)dr[1]);
                        //订阅事件
                        userWindow.ZhuXiao += new EventHandler(OnZhuxiaoClicked);
                        userWindow.TuiChu += new EventHandler(OnTuichuClicked);
                        this.Hide();
                        userWindow.Show();
                    }
                }
                else
                {
                    MessageBox.Show("请输入存在的邮箱地址！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
    }
}

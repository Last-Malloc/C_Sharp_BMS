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
    public partial class MyInfo : Form
    {
        string id;
        string headpor;
        string telephone;
        string oldTelephone;
        string email;

        SqlConnection conn;
        SqlDataReader dr;
        string connString = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";

        public MyInfo(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        //选择头像
        private void btnChoHeadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG图片|*.png|JPG图片|*.jpg";
            openFileDialog.Title = "选择头像图片";
            openFileDialog.ShowDialog();
            headpor = openFileDialog.FileName;
        }

        private void MyInfo_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select theUser.*, userType.tMaxDay, userType.tMaxNum from theUser, userType where uType = tName and uID = " + id;
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    //头像
                    headpor = (string)dr[0];
                    pictureBoxHead.BackgroundImage = Image.FromFile(headpor);
                    //姓名 性别
                    string str = (string)dr[4] + " ";
                    if ((bool)dr[5])
                    {
                        str += "男";
                    }
                    else
                    {
                        str += "女";
                    }
                    lbNameSex.Text = str;
                    //账户类型
                    switch((string)dr[3])
                    {
                        case "系管":str = "系统管理员";break;
                        case "图管":str = "图书管理员";break;
                        default:str = (string)dr[3];break;
                    }
                    lbType.Text = str;
                    //最大借阅天数
                    str = "最大借阅天数：" + ((int)dr[12]).ToString();
                    lbTypeDay.Text = str;
                    //最大借阅本数
                    str = "最大借阅本数；" + ((int)dr[13]).ToString();
                    lbTypeNum.Text = str;
                    //学号
                    str = "学号：" + (string)dr[1];
                    lbID.Text = str;
                    //学院班级
                    str = (string)dr[6] + "学院 " + (string)dr[7];
                    lbXYBJ.Text = str;
                    //身份证号
                    str = "身份证号：" + (string)dr[8];
                    lbSFID.Text = str;
                    //手机号
                    if (dr[9] == System.DBNull.Value)
                        telephone = "";
                    else
                        telephone = (string)dr[9];
                    textTele.Text = telephone;
                    oldTelephone = telephone;
                    //邮箱
                    if (dr[10] == System.DBNull.Value)
                        email = "";
                    else
                        email = (string)dr[10];
                    textEmail.Text = email;
                    //账户状态
                    if ((int)dr[11] < 3)
                    {
                        str = "账户状态：可用";
                    }
                    else
                    {
                        str = "账户状态：不可用";
                    }
                    lbStatus.Text = str;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Program.IsHaveSpace(email))
            {
                MessageBox.Show("输入的邮箱中包含空格！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //验证手机号码格式（11位数字或为空）
            if (telephone != oldTelephone &&  Program.IsAUsefulPhoneNumber(telephone, "") == true)
            {
                //写入数据库
                try
                {
                    string sql = "update theUser set uHeadPic = '" + headpor + "', uTelephone = '" + telephone + "', uEmail = '" + email + "' where  uID = " + id;
                    conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    oldTelephone = telephone;
                    MessageBox.Show("您的信息修改成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void textTele_TextChanged(object sender, EventArgs e)
        {
            telephone = textTele.Text;
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            email = textEmail.Text;
        }
    }
}

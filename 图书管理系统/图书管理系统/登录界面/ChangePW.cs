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
    public partial class ChangePW : Form
    {
        bool havaTheId = false;
        bool pwIsTrue = false;
        bool newPWEqual = false;
        bool showPW1 = false;//旧密码输入框显示/隐藏密码标志
        bool showPW2 = false;//新密码输入框显示/隐藏密码标志
        bool showPW3 = false;//重新输入密码框显示/隐藏密码标志

        string connString = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
        SqlDataReader dr;
        SqlConnection conn;

        string id, password;

        //密码框失去焦点判断密码是否正确
        private void textPW_Leave(object sender, EventArgs e)
        {
            pwIsTrue = false;
            if (textPW.Text != "")
            {
                if (textPW.Text != password)
                {
                    labelWarning2.Text = "您输入的密码不正确";
                    return;
                }
                labelWarning2.Text = "";
                pwIsTrue = true;
            }
        }

        //重新输入密码框改变时，提示两次输入的密码是否一致
        private void textNewPW2_TextChanged(object sender, EventArgs e)
        {
            newPWEqual = false;
            if (textNewPW.Text != "")
            {
                if (textNewPW.Text == textNewPW2.Text)
                {
                    labelWarning3.Text = "";
                    newPWEqual = true;
                }
                else
                {
                    labelWarning3.Text = "您两次输入的密码不一致";
                }
            }
        }

        //构造方法
        public ChangePW(string keyId, bool flag)
        {
            id = keyId;
            InitializeComponent();
            textID.Text = id;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (flag)
            {
                textID.Enabled = false;
            }
        }

        //ID输入框失去焦点判断账户是否存在
        private void textID_Leave(object sender, EventArgs e)
        {
            havaTheId = false;
            if (textID.Text != "")
            {
                if (textID.Text.Length != 10)
                {
                    labelWarning1.Text = "您输入的账户不存在";
                    return;
                }
                try
                {
                    string sql = "select uID, uPW from theUser where (uType = '图管' or uType = '系管') and uID = " + textID.Text;
                    conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    dr = comm.ExecuteReader();
                    if (dr.Read())
                    {
                        password = (string)dr[1];
                    }
                    else
                    {
                        labelWarning1.Text = "您输入的账户不存在";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }

                havaTheId = true;
                labelWarning1.Text = "";
            }
        }

        //确定按钮
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textID.Text == "" || textPW.Text == "" || textNewPW.Text == "" || textNewPW2.Text == "")
            {
                MessageBox.Show("您的输入包含空值，请重新输入", "更改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Program.IsHaveSpace(textNewPW.Text) || Program.IsHaveSpace(textNewPW2.Text))
            {
                MessageBox.Show("输入的新密码中包含空格，请重新输入", "更改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNewPW.Text = "";
                textNewPW2.Text = "";
                return;
            }
            if (havaTheId && pwIsTrue && newPWEqual)
            {
                try
                {
                    string sql = "update theUser set uPW = " + textNewPW.Text + "where uID = " + textID.Text;
                    conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("您的密码更改成功！", "更改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textPW.Clear();
                    textNewPW.Clear();
                    textNewPW2.Clear();
                    button2.Focus();
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
                string str = labelWarning1.Text + "!" + labelWarning2.Text + "!" + labelWarning3.Text + "!";
                MessageBox.Show(str, "更改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {
            labelWarning1.Text = "";
        }

        private void textPW_TextChanged(object sender, EventArgs e)
        {
            labelWarning2.Text = "";
        }

        //显示/隐藏密码-1
        private void button1_Click(object sender, EventArgs e)
        {
            if (showPW1)
            {
                showPW1 = false;
                textPW.PasswordChar = '*';
                button1.BackgroundImage = Image.FromFile("..\\..\\图片\\小按钮\\隐藏密码.png");
            }
            else
            {
                showPW1 = true;
                textPW.PasswordChar = new Char();
                button1.BackgroundImage = Image.FromFile("..\\..\\图片\\小按钮\\显示密码.png");
            }
        }

        //显示/隐藏密码-2
        private void button3_Click(object sender, EventArgs e)
        {
            if (showPW2)
            {
                showPW2 = false;
                textNewPW.PasswordChar = '*';
                button3.BackgroundImage = Image.FromFile("..\\..\\图片\\小按钮\\隐藏密码.png");
            }
            else
            {
                showPW2 = true;
                textNewPW.PasswordChar = new Char();
                button3.BackgroundImage = Image.FromFile("..\\..\\图片\\小按钮\\显示密码.png");
            }
        }

        //显示/隐藏密码-3
        private void button4_Click(object sender, EventArgs e)
        {
            if (showPW3)
            {
                showPW3 = false;
                textNewPW2.PasswordChar = '*';
                button4.BackgroundImage = Image.FromFile("..\\..\\图片\\小按钮\\隐藏密码.png");
            }
            else
            {
                showPW3 = true;
                textNewPW2.PasswordChar = new Char();
                button4.BackgroundImage = Image.FromFile("..\\..\\图片\\小按钮\\显示密码.png");
            }
        }

        //返回按钮
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

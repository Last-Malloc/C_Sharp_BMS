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
    struct StructUserType
    {
        public string name;
        public int day;
        public int num;
        public StructUserType(string a, int b, int c)
        {
            name = a;
            day = b;
            num = c;
        }
    }

    public partial class PeopleTypeMana : Form
    {
        private SqlConnection conn;
        private SqlDataReader dr;
        List<StructUserType> listType;

        private bool beingNewType = false;
        private bool beingEditType = false;

        string connString = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";

        public PeopleTypeMana()
        {
            InitializeComponent();

            //可变标签和输入框隐藏
            lbLeft.Hide();
            textLeft.Hide();

            AddToCbName();

            textDay.Enabled = false;
            textNum.Enabled = false;

            取消ToolStripMenuItem.Enabled = false;
            toolStripMenuItem1.Enabled = true;
            删除ToolStripMenuItem.Enabled = true;
            修改类别ToolStripMenuItem.Enabled = true;

            btnSearch.Enabled = false;
        }

        //类别名称填充
        private void AddToCbName()
        {
            //暂时存储已有的账户类型信息
            listType = new List<StructUserType>();
            cbName.Items.Clear();
            try
            {
                string sql = "select * from userType";
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    StructUserType t = new StructUserType((string)dr[0], (int)dr[1], (int)dr[2]);
                    cbName.Items.Add(t.name);
                    listType.Add(t);
                }
                cbName.SelectedIndex = 0;
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

        //返回按钮
        private void btnBack_Click(object sender, EventArgs e)
        {
            取消ToolStripMenuItem.Enabled = false;
            toolStripMenuItem1.Enabled = true;
            删除ToolStripMenuItem.Enabled = true;
            修改类别ToolStripMenuItem.Enabled = true;

            //正在新建
            if (beingNewType)
            {
                beingNewType = false;
                btnOK.Text = "确定";
                btnBack.Text = "返回";
                lbLeft.Hide();
                textLeft.Hide();
                cbName_SelectedIndexChanged(this, e);
                textDay.Enabled = false;
                textNum.Enabled = false;
                return;
            }

            //正在修改
            if (beingEditType)
            {
                beingEditType = false;
                btnOK.Text = "确定";
                btnBack.Text = "返回";
                lbLeft.Hide();
                textLeft.Hide();
                cbName_SelectedIndexChanged(this, e);
                textDay.Enabled = false;
                textNum.Enabled = false;
                return;
            }

            //关闭窗口
            this.Close();
        }

        //类别名称改变时的处理方法(正在新建时不作反应、正在修改时遇到系/图管禁止更改名称)
        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (beingNewType == false)
            {
                int index = cbName.SelectedIndex;
                textDay.Text = listType[index].day.ToString();
                textNum.Text = listType[index].num.ToString();

                if (beingEditType)
                {
                    if (listType[cbName.SelectedIndex].name == "图管" || listType[cbName.SelectedIndex].name == "系管")
                    {
                        textLeft.Enabled = false;
                    }
                    else
                    {
                        textLeft.Enabled = true;
                    }
                    textLeft.Text = listType[index].name.ToString();
                }
            }
        }

        //新建类别
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (beingEditType == false)
            {
                取消ToolStripMenuItem.Enabled = true;
                toolStripMenuItem1.Enabled = false;
                删除ToolStripMenuItem.Enabled = false;
                修改类别ToolStripMenuItem.Enabled = false;

                beingNewType = true;
                lbLeft.Text = "新类别名称";
                lbLeft.Show();
                textLeft.Clear();
                textLeft.Show();

                textDay.Clear();
                textDay.Enabled = true;
                textNum.Clear();
                textNum.Enabled = true;

                btnOK.Text = "确认添加";
                btnBack.Text = "取消添加";
            }
        }

        //确定按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            //正在新建
            if (beingNewType)
            {
                string str = textLeft.Text.Trim();
                if (str.Length == 0)
                {
                    MessageBox.Show("新类型名称不能为空，请重新输入！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Program.IsHaveSpace(str))
                {
                    MessageBox.Show("新类型名称不能包含空格，请重新输入！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //验证类别名称是否已经存在
                for (int i = 0;i < listType.Count; ++i)
                {
                    if (str == listType[i].name)
                    {
                        MessageBox.Show("该类别名称已存在，请重新输入！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textLeft.Clear();
                        return;
                    }
                }

                int day, num;
                //验证最大天数/本数是够满足要求
                try
                {
                    day = Int32.Parse(textDay.Text);
                    num = Int32.Parse(textNum.Text);
                    if (day < 0 || num < 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("可借阅天数或本数格式不正确，请重新输入！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //添加到数据库
                try
                {
                    string sql = "INSERT INTO userType VALUES('" + str + "', " + day + ", " + num + ")";
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
                MessageBox.Show("新类别添加成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddToCbName();

                //cbName选中新增类别名称
                for (int i = 0;i < listType.Count;++i)
                {
                    if (str == listType[i].name)
                    {
                        cbName.SelectedIndex = i;
                        cbName_SelectedIndexChanged(this, e);
                        break;
                    }
                }

                beingNewType = false;
                btnOK.Text = "确定";
                btnBack.Text = "返回";

                lbLeft.Hide();
                textLeft.Hide();

                textDay.Enabled = false;
                textNum.Enabled = false;

                取消ToolStripMenuItem.Enabled = false;
                toolStripMenuItem1.Enabled = true;
                删除ToolStripMenuItem.Enabled = true;
                修改类别ToolStripMenuItem.Enabled = true;

                return;
            }

            //正在修改
            if (beingEditType)
            {
                string tName = textLeft.Text.Trim();
                if (tName.Length == 0)
                {
                    MessageBox.Show("新类型名称不能为空，请输入！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Program.IsHaveSpace(tName))
                {
                    MessageBox.Show("新类型名称不能包含空格，请重新输入！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //验证类别名称是否已经存在且不是当前要更改的名称
                for (int i = 0; i < listType.Count; ++i)
                {
                    if (tName == listType[i].name && i != cbName.SelectedIndex)
                    {
                        MessageBox.Show("该类别名称已存在，请重新输入！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textLeft.Text = listType[cbName.SelectedIndex].name;
                        return;
                    }
                }

                int tDay, tNum;
                //验证最大天数/本数是够满足要求
                try
                {
                    tDay = Int32.Parse(textDay.Text);
                    tNum = Int32.Parse(textNum.Text);
                    if (tDay < 0 || tNum < 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("可借阅天数或本数格式不正确，请重新输入！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //添加到数据库(涉及主键，删除重建)
                try
                {
                    string sql1 = "update theUser set uType = null where uType = '" + listType[cbName.SelectedIndex].name + "'";
                    string sql2 = "delete from userType where tName = '" + listType[cbName.SelectedIndex].name + "'";
                    string sql3 = "insert into userType values('" + tName + "', " + tDay + ", " + tNum + ")";
                    string sql4 = "update theUser set uType = '" + tName + "' where uType is null";
                    conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql1, conn);
                    comm.ExecuteNonQuery();
                    comm.CommandText = sql2;
                    comm.ExecuteNonQuery();
                    comm.CommandText = sql3;
                    comm.ExecuteNonQuery();
                    comm.CommandText = sql4;
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
                MessageBox.Show("类别修改成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddToCbName();
                for (int i = 0; i < listType.Count; ++i)
                {
                    if (tName == listType[i].name)
                    {
                        cbName.SelectedIndex = i;
                        cbName_SelectedIndexChanged(this, e);
                        break;
                    }
                }

                beingEditType = false;
                btnOK.Text = "确定";
                btnBack.Text = "返回";
                lbLeft.Hide();
                textLeft.Hide();
                textDay.Enabled = false;
                textNum.Enabled = false;

                取消ToolStripMenuItem.Enabled = false;
                toolStripMenuItem1.Enabled = true;
                删除ToolStripMenuItem.Enabled = true;
                修改类别ToolStripMenuItem.Enabled = true;

                return;
            }
        }

        //修改类别
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (beingNewType == false)
            {
                取消ToolStripMenuItem.Enabled = true;
                toolStripMenuItem1.Enabled = false;
                删除ToolStripMenuItem.Enabled = false;
                修改类别ToolStripMenuItem.Enabled = false;

                beingEditType = true;

                lbLeft.Text = "新类别名称";
                lbLeft.Show();

                cbName_SelectedIndexChanged(this, e);
                textLeft.Show();

                textDay.Enabled = true;
                textNum.Enabled = true;

                btnOK.Text = "确认修改";
                btnBack.Text = "取消修改";
            }
        }

        //删除类别-----------
        private void button1_Click(object sender, EventArgs e)
        {
            if (listType[cbName.SelectedIndex].name == "图管" || listType[cbName.SelectedIndex].name == "系管")
            {
                MessageBox.Show("不能删除系统管理员或图书管理员类型！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("删除类别同时删除该类别所有人员信息，确认删除类别" + listType[cbName.SelectedIndex].name + "？", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    string sql1 = "select * from Loan where uID in (select uID from theUser where uType = '" + listType[cbName.SelectedIndex].name + "')";
                    conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql1, conn);
                    dr = comm.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("该类型下存在用户有未还图书，删除失败！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dr.Close();
                    string sql2 = "delete from activeUser where auID in (select uID from theUser where uType = '" + listType[cbName.SelectedIndex].name + "')";
                    string sql3 = "delete from theUser where uType = '" + listType[cbName.SelectedIndex].name + "'";
                    string sql4 = "delete from userType where tName = '" + listType[cbName.SelectedIndex].name + "'";
                    comm.ExecuteNonQuery();
                    comm.CommandText = sql2;
                    comm.ExecuteNonQuery();
                    comm.CommandText = sql3;
                    comm.ExecuteNonQuery();
                    comm.CommandText = sql4;
                    comm.ExecuteNonQuery();
                    MessageBox.Show("类别删除成功！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (dr.IsClosed == false)
                    {
                        dr.Close();
                    }
                    conn.Close();
                }
            }
            AddToCbName();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnNew_Click(this, e);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(this, e);
        }

        private void 修改类别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEdit_Click(this, e);
        }

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBack_Click(this, e);
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text == "")
            {
                btnSearch.Enabled = false;
                label4.Show();
            }
            else
            {
                btnSearch.Enabled = true;
                label4.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AddToCbName();
            if (textSearch.Text != "")
            {
                string str = textSearch.Text;
                int fenhaoIndex = -1, douhaoIndex = -1;
                for (int i = 0; i < str.Length; ++i)
                {
                    if (str[i] == ':' || str[i] == '：')
                    {
                        fenhaoIndex = i;
                    }
                    if (str[i] == ',' || str[i] == '，')
                    {
                        douhaoIndex = i;
                    }
                }
                if (douhaoIndex != -1 && fenhaoIndex == -1)
                {
                    MessageBox.Show("查找关键字格式错误，未包含\":\"但包含\",\"！", "查找失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int minNum = 0, minDay = 0;//最小数量限制、最小天数限制
                try
                {
                    if (fenhaoIndex != -1)
                    {
                        if (douhaoIndex == -1)
                        {
                            minNum = Int32.Parse(str.Substring(fenhaoIndex + 1));
                        }
                        else
                        {
                            minNum = Int32.Parse(str.Substring(fenhaoIndex + 1, douhaoIndex - fenhaoIndex - 1));
                        }
                    }
                    if (douhaoIndex != -1)
                    {
                        minDay = Int32.Parse(str.Substring(douhaoIndex + 1));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("查找关键字格式错误，\":\"或\",\"后为非数字！", "查找失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string keyName;
                if (fenhaoIndex != -1)
                {
                    keyName = str.Substring(0, fenhaoIndex);//类别名称
                }
                else
                {
                    keyName = str.Substring(0);
                }

                //筛选符合条件的结果
                List<StructUserType> tInfo = new List<StructUserType>();
                cbName.Items.Clear();
                for (int i = 0;i < listType.Count; ++i)
                {
                    if (listType[i].num >= minNum && listType[i].day >= minDay)
                    {
                        string c = listType[i].name;
                        int a = listType[i].num, b = listType[i].day;
                        if (listType[i].name.Contains(keyName) || keyName.Contains(listType[i].name))
                        {
                            tInfo.Add(listType[i]);
                            cbName.Items.Add(listType[i].name);
                        }
                    }
                }
                listType = tInfo;
            }
            if (listType.Count != 0)
            {
                cbName.SelectedIndex = 0;
            }
            else
            {
                beingNewType = true;
                cbName.Items.Add("无查询结果");
                cbName.SelectedIndex = 0;
                beingNewType = false;//抵消一次cbName选中项改变反应
                textDay.Clear();
                textNum.Clear();
            }
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, e);
            }
        }
    }
}

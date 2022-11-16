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
    public partial class UserUpdate : Form
    {
        string connString = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
        SqlConnection conn;
        SqlDataAdapter dataAdapter;
        SqlDataReader dr;
        DataSet ds;
        bool beingNew = false, beingEdit = false;

        //填充DataGridView控件
        private void AddToDataGridView()
        {
            conn = new SqlConnection(connString);
            string sql = "select uHeadPic, uID, uType, uName, uSex, uInstitute, uClassName, uSFID, uTelephone, uEmail from theUser ";
            if ((ISAndCNLimit).Trim().Length != 0)
            {
                sql += " where " + ISAndCNLimit + nameLimit;
            }
            else
            {
                if ((nameLimit).Trim().Length != 0)
                {
                    sql += " where " + nameLimit.Substring(4, nameLimit.Length - 4);
                }
            }
            dataAdapter = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.AutoGenerateColumns = false;//取消自动添加列

            dataGridView1.DataSource = ds.Tables[0];

            //填充头像、性别和账户类型
            for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
            {
                dataGridView1.Rows[i].Cells[0].Value = Image.FromFile(ds.Tables[0].Rows[i][0].ToString());
                if ((bool)ds.Tables[0].Rows[i][4] == true)
                {
                    dataGridView1.Rows[i].Cells[4].Value = "男";
                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Value = "女";
                }
                dataGridView1.Rows[i].Cells[2].Value = (string)ds.Tables[0].Rows[i][2];
            }
        }

        string loginID;
        //构造函数
        public UserUpdate(string key)
        {
            InitializeComponent();

            loginID = key;

            //填充用户类型combobox
            try
            {
                string sql = "select distinct uType from theUser";
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Column3.Items.Add((string)dr[0]);
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

        //加载窗口
        private void UserUpdate_Load(object sender, EventArgs e)
        {
            AddToDataGridView();

            btnOK.Hide();

            //设置所有行为只读
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                dataGridView1.Rows[i].ReadOnly = true;
            }
        }

        //确定按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (beingNew)
            {
                //准备数据和数据检查
                //头像(不存在异常)
                string uHeadPic = newHeadPic;

                //uID（验空、验格式、验重复）
                string uID = (dataGridView1.Rows[newIndex].Cells[1].Value != System.DBNull.Value) ? (string)dataGridView1.Rows[newIndex].Cells[1].Value : null;
                if (uID == null)
                {
                    MessageBox.Show("请输入账户ID！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (uID.Length != 10)
                {
                    MessageBox.Show("账户ID格式不正确，请重新输入！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    for (int i = 0;i < 10; ++i)
                    {
                        if (Char.IsDigit(uID[i]) == false)
                        {
                            MessageBox.Show("账户ID格式不正确，请重新输入！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                try
                {
                    string sql = "select * from theUser where uID = '" + uID + "'";
                    conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    dr = comm.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("该账户ID已存在，请重新输入！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                //密码（账户后三位）
                string uPW = uID.Substring(7, 3);

                //类型（验空）
                string uType = (dataGridView1.Rows[newIndex].Cells[2].Value != System.DBNull.Value) ? (string)dataGridView1.Rows[newIndex].Cells[2].Value : null;
                if (uType == null)
                {
                    MessageBox.Show("请选择账户类型！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //姓名（验空）
                string uName = (dataGridView1.Rows[newIndex].Cells[3].Value != System.DBNull.Value) ? (string)dataGridView1.Rows[newIndex].Cells[3].Value : null;
                if (uName == null)
                {
                    MessageBox.Show("请输入用户名！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //性别（验空）
                int uSex;
                if (dataGridView1.Rows[newIndex].Cells[4].Value == null)
                {
                    MessageBox.Show("请选择性别！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((string)dataGridView1.Rows[newIndex].Cells[4].Value == "男")
                {
                    uSex = 1;
                }
                else
                {
                    uSex = 0;
                }

                //学院（验空）
                string uInstitute = (dataGridView1.Rows[newIndex].Cells[5].Value != System.DBNull.Value) ? (string)dataGridView1.Rows[newIndex].Cells[5].Value : null;
                if (uInstitute == null)
                {
                    MessageBox.Show("请输入学院信息！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //班级（验空）
                string uClassName = (dataGridView1.Rows[newIndex].Cells[6].Value != System.DBNull.Value) ? (string)dataGridView1.Rows[newIndex].Cells[6].Value : null;
                if (uClassName == null)
                {
                    MessageBox.Show("请输入班级信息！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //身份证号，由sqlServer进行检查处理
                string uSFID = (dataGridView1.Rows[newIndex].Cells[7].Value != System.DBNull.Value) ? (string)dataGridView1.Rows[newIndex].Cells[7].Value : "";
                if (Program.IsAUsefulSFID(uSFID, "") == false)
                {
                    return;
                }

                //手机号，由sqlServer进行检查处理
                string uTelephone = (dataGridView1.Rows[newIndex].Cells[8].Value != System.DBNull.Value) ? (string)dataGridView1.Rows[newIndex].Cells[8].Value : "";
                if (Program.IsAUsefulPhoneNumber(uTelephone, "") == false)
                {
                    return;
                }

                //邮箱，由sqlServer进行检查处理
                string uEmail = (dataGridView1.Rows[newIndex].Cells[9].Value != System.DBNull.Value) ? (string)dataGridView1.Rows[newIndex].Cells[9].Value : "";
                if (Program.IsHaveSpace(uEmail))
                {
                    MessageBox.Show("输入的邮箱中包含空格！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int uErrorCnt = 0;

                try
                {
                    string sql = "insert into theUser values('" + uHeadPic + "', '" + uID + "', '" + uPW + "', '" + uType + "', '" + uName + "', " + uSex + ", '" + uInstitute + "', '" + uClassName + "', '" + uSFID + "', '" + uTelephone + "', '" + uEmail + "', " + uErrorCnt + ")";
                    conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("成功添加新用户！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBack_Click(this, e);
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

            if (beingEdit)
            {
                //从dataGridView获取绑定数据存储到dataset(参考AddToDataGridView函数)
                for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
                {
                    //类型，由C#进行处理
                    string uType = (dataGridView1.Rows[i].Cells[2].Value != System.DBNull.Value) ? (string)dataGridView1.Rows[i].Cells[2].Value : null;
                    if (uType == null)
                    {
                        MessageBox.Show("账户类型不能为空值！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ds.Tables[0].Rows[i][2] = uType;
                    //性别，由C#进行处理
                    int uSex;
                    if (dataGridView1.Rows[newIndex].Cells[4].Value == System.DBNull.Value)
                    {
                        MessageBox.Show("性别不能为空值！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if ((string)dataGridView1.Rows[newIndex].Cells[4].Value == "男")
                    {
                        uSex = 1;
                    }
                    else
                    {
                        uSex = 0;
                    }
                    ds.Tables[0].Rows[i][4] = uSex;
                }
                try
                {
                    SqlCommandBuilder MyCb = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(ds);
                    MessageBox.Show("成功修改用户信息！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBack_Click(this, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "所修改数据均未提交！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //返回按钮
        private void btnBack_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            if (beingNew)
            {
                beingNew = false;

                btnOK.Hide();
                btnBack.Text = "返回";

                AddToDataGridView();

                //设置所有行为只读
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].ReadOnly = true;
                }
                dataGridView1.AllowUserToAddRows = false;

                return;
            }

            if (beingEdit)
            {
                beingEdit = false;

                btnOK.Hide();
                btnBack.Text = "返回";

                AddToDataGridView();

                //设置所有行为只读
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].ReadOnly = true;
                }

                return;
            }

            this.Close();
        }

        string newHeadPic;//添加行的图片路径
        int newIndex;//添加行行号
        //新建用户
        private void btnNew_Click(object sender, EventArgs e)
        {
            beingNew = true;
            btnOK.Text = "确认添加";
            btnOK.Show();
            btnBack.Text = "取消添加";

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            dataGridView1.AllowUserToAddRows = true;

            //最后一行可编辑且获得焦点
            newIndex = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[newIndex].Selected = true;
            dataGridView1.Rows[newIndex].ReadOnly = false;

            //为新增行的头像设置默认值
            dataGridView1.Rows[newIndex].Cells[0].Value = Image.FromFile("..\\..\\图片\\默认用户头像\\moren.png");
            newHeadPic = "..\\..\\图片\\默认用户头像\\moren.png";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            beingEdit = true;
            btnOK.Text = "确认修改";
            btnOK.Show();
            btnBack.Text = "取消修改";

            btnDelete.Enabled = false;
            btnNew.Enabled = false;

            //所有已存在行可编辑
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                dataGridView1.Rows[i].ReadOnly = false;
            }
        }

        SqlConnection connDelete;
        SqlConnection connIsHaveLoan;
        //判断该id是否有借书记录
        private bool idIsHaveLoan(string id)
        {
            try
            {
                string sql = "select count(*) from Loan where uID = '" + id + "'";
                connIsHaveLoan = new SqlConnection(connString);
                connIsHaveLoan.Open();
                SqlCommand comm = new SqlCommand(sql, connIsHaveLoan);
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    if ((int)dr[0] == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
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
                connIsHaveLoan.Close();
            }
            return true;
        }

        //删除功能
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (beingNew == false && beingEdit == false)
            {
                Stack<int> stackDelete = new Stack<int>();//从后向前删除所选的行，否则删前面行后面行号会变化
                for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
                {
                    stackDelete.Push(dataGridView1.SelectedRows[i].Index);
                }
                string inputException = "";//记录没有删除成功的账户
                string inputSuccess = "";//记录成功删除的账户信息
                List<string> errorDeleteID = new List<string>();
                while (stackDelete.Count != 0)
                {
                    int index = stackDelete.Pop();
                    string id = (string)ds.Tables[0].Rows[index][1];
                    if (id == loginID)
                    {
                        inputException += "," + loginID;
                        errorDeleteID.Add(id);
                        continue;
                    }

                    if (idIsHaveLoan(id) == false)
                    {
                        inputSuccess += "," + id;
                        ds.Tables[0].Rows[index].Delete();

                        try
                        {
                            connDelete = new SqlConnection(connString);
                            connDelete.Open();
                            SqlCommand comm = new SqlCommand();
                            comm.Connection = connDelete;
                            //删除最近登录记录依赖
                            string sql = "delete from recent where rID = '" + id + "'";
                            comm.CommandText = sql;
                            comm.ExecuteNonQuery();
                            //删除活跃用户记录依赖
                            sql = "delete from activeUser where auID = '" + id + "'";
                            comm.CommandText = sql;
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
                    }
                    else
                    {
                        inputException += "," + id;
                        errorDeleteID.Add(id);
                    }
                }
                try
                {
                    SqlCommandBuilder MyCb = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(ds);
                    AddToDataGridView();
                    if (inputException == "")
                    {
                        MessageBox.Show("成功删除所有所选用户信息！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (inputException.Trim().Length != 0)
                        {
                            inputException = inputException.Substring(1, inputException.Length - 1);
                        }
                        if (inputSuccess.Trim().Length != 0)
                        {
                            inputSuccess = inputSuccess.Substring(1, inputSuccess.Length - 1);
                        }
                        MessageBox.Show(inputException + "用户有图书未还(或为正在登陆的管理员账户)，不能删除，删除成功的用户有：" + inputSuccess + "!", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                int tIndex = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (errorDeleteID.Count > 0 && errorDeleteID[tIndex] == (string)dataGridView1.Rows[i].Cells[1].Value)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                        ++tIndex;
                        if (tIndex == errorDeleteID.Count)
                        {
                            break;
                        }
                    }
                }
            }
        } 

        //更换头像
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //正在添加
            if (beingNew && e.ColumnIndex == 0 && e.RowIndex == newIndex)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PNG图片|*.png|JPG图片|*.jpg";
                openFileDialog.Title = "选择头像图片";
                openFileDialog.ShowDialog();
                newHeadPic = openFileDialog.FileName;
                if (newHeadPic.Length == 0)
                {
                    newHeadPic = "..\\..\\图片\\默认用户头像\\moren.png";
                }
                dataGridView1.Rows[newIndex].Cells[0].Value = Image.FromFile(newHeadPic);
            }

            //正在修改
            if (beingEdit && e.ColumnIndex == 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PNG图片|*.png|JPG图片|*.jpg";
                openFileDialog.Title = "选择头像图片";
                openFileDialog.ShowDialog();
                string t = openFileDialog.FileName;
                if (t.Length == 0)
                {
                    t = "..\\..\\图片\\默认用户头像\\moren.png";
                }
                dataGridView1.Rows[newIndex].Cells[0].Value = Image.FromFile(t);
                if (t != (string)ds.Tables[0].Rows[e.RowIndex][0])
                {
                    ds.Tables[0].Rows[e.RowIndex][0] = t;
                }
            }

            if (e.ColumnIndex != 0)
            {
                for (int i = 0;i < dataGridView1.RowCount;++i)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }


        //姓名模糊查找
        string nameLimit = " ";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            nameLimit = " ";
            string name = textName.Text.Trim();
            if (name.Length != 0)
            {
                nameLimit = " and ( uName like '%" + name.Substring(0, 1) + "%' ";
                for (int i = 1;i < name.Length;++i)
                {
                    string t = name.Substring(i, 1);
                    nameLimit += " or uName like '%" + t + "%' ";
                }
                nameLimit += ")";
            }

            AddToDataGridView();
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, e);
            }
        }
        //-------------------------------右键菜单区-----------------------------------
        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNew_Click(this, e);
        }

        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(this, e);
        }

        private void 更改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEdit_Click(this, e);
        }

        string ISAndCNLimit = " ";//学院班级限制
        private void 不限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = true;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " ";
            AddToDataGridView();
        }

        private void 图书管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = true;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uType = '图管'";
            AddToDataGridView();
        }

        private void 不限ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = true;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uInstitute = '信息'";
            AddToDataGridView();
        }

        private void 计算171ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = true;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uClassName = '计算171'";
            AddToDataGridView();
        }

        private void 计算172ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = true;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uClassName = '计算172'";
            AddToDataGridView();
        }

        private void 信息172ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = true;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uClassName = '信息172'";
            AddToDataGridView();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = true;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uInstitute = '材料'";
            AddToDataGridView();
        }

        private void 金属171ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = true;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uClassName = '金属171'";
            AddToDataGridView();
        }

        private void 金属172ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = true;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uClassName = '金属172'";
            AddToDataGridView();
        }

        private void 材物171ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = true;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uClassName = '材物171'";
            AddToDataGridView();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = true;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = false;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uType = '系管'";
            AddToDataGridView();
        }

        private void 材物172ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //每次仅能一个Item在选中状态
                不限ToolStripMenuItem.Checked = false;

                图书管理员ToolStripMenuItem.Checked = false;
                toolStripMenuItem2.Checked = false;

                不限ToolStripMenuItem1.Checked = false;
                计算171ToolStripMenuItem.Checked = false;
                计算172ToolStripMenuItem.Checked = false;
                信息172ToolStripMenuItem.Checked = false;

                toolStripMenuItem1.Checked = false;
                金属171ToolStripMenuItem.Checked = false;
                金属172ToolStripMenuItem.Checked = false;
                材物171ToolStripMenuItem.Checked = false;
                材物172ToolStripMenuItem.Checked = true;
            }
            if (beingNew || beingEdit)
            {
                btnBack_Click(this, e);//筛选前退出正在进行的添加和修改
            }
            ISAndCNLimit = " uClassName = '材物172'";
            AddToDataGridView();
        }
    }
}

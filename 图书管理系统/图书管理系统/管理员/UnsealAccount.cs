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
    //账号解封
    public partial class UnsealAccount : Form
    {
        string connString = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
        SqlConnection conn;
        DataSet ds;

        string id;

        public UnsealAccount(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        //填充DataGridView
        private void AddToDataGridView()
        {
            conn = new SqlConnection(connString);
            string sql = "select uHeadPic, uID, uName, uSex, uType, uErrorCnt from theUser where uType = '图管' or uType = '系管' order by uErrorCnt";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.AutoGenerateColumns = false;//取消自动添加列

            dataGridView1.DataSource = ds.Tables[0];

            //填充头像、性别和账户状态
            for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
            {
                dataGridView1.Rows[i].Cells[0].Value = Image.FromFile(ds.Tables[0].Rows[i][0].ToString());
                if ((bool)ds.Tables[0].Rows[i][3] == true)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "男";
                }
                else
                {
                    dataGridView1.Rows[i].Cells[3].Value = "女";
                }
                if ((int)ds.Tables[0].Rows[i][5] == 3)
                {
                    dataGridView1.Rows[i].Cells[5].Value = "冻结";
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[5].Value = "正常";
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.PaleGreen ;
                }
            }
        }

        //返回按钮
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnsealAccount_Load(object sender, EventArgs e)
        {
            AddToDataGridView();
        }

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            List<string> tIDFreeze = new List<string>();
            for (int i = 0;i < dataGridView1.SelectedRows.Count;++i)
            {
                tIDFreeze.Add((string)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[1].Value);
            }
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                string sql;
                for (int i = 0;i < tIDFreeze.Count;++i)
                {
                    if (tIDFreeze[i] != id)
                    {
                        sql = "update theUser set uErrorCnt = 3 where uID = '" + tIDFreeze[i] + "'";
                        comm.CommandText = sql;
                        comm.ExecuteNonQuery();
                    }
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
            AddToDataGridView();
            beingSelectAll = false;
            btnSelectAll.Text = "全选";
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }

        bool beingSelectAll = false;//当前是否全选
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (beingSelectAll)
            {
                beingSelectAll = false;
                btnSelectAll.Text = "全选";
                for (int i = 0;i < dataGridView1.RowCount;++i)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
            }
            else
            {
                beingSelectAll = true;
                btnSelectAll.Text = "全不选";
                for (int i = 0; i < dataGridView1.RowCount; ++i)
                {
                    dataGridView1.Rows[i].Selected = true;
                }
            }
        }

        private void btnUnFreeze_Click(object sender, EventArgs e)
        {
            List<string> tIDFreeze = new List<string>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
            {
                tIDFreeze.Add((string)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[1].Value);
            }
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                string sql;
                for (int i = 0; i < tIDFreeze.Count; ++i)
                {
                    sql = "update theUser set uErrorCnt = 0 where uID = '" + tIDFreeze[i] + "'";
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();
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
            AddToDataGridView();
            beingSelectAll = false;
            btnSelectAll.Text = "全选";
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }

        //重置密码
        private void btnResetPW_Click(object sender, EventArgs e)
        {
            List<string> tIDFreeze = new List<string>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
            {
                tIDFreeze.Add((string)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[1].Value);
            }
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                string sql;
                for (int i = 0; i < tIDFreeze.Count; ++i)
                {
                    sql = "update theUser set uPW = '" + tIDFreeze[i].Substring(7, 3) + "' where uID = '" + tIDFreeze[i] + "'";
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();
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
            MessageBox.Show("已将账户密码重置为账号后3位！", "重置成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddToDataGridView();
            beingSelectAll = false;
            btnSelectAll.Text = "全选";
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }
    }
}

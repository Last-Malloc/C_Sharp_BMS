using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        //人员活跃度加1
        static string connString = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
        static SqlConnection conn;
        static SqlDataReader dr;
        public static void addActiveUserStatistics(string id)
        {
            string date = (DateTime.Now.Year * 100 + DateTime.Now.Month).ToString();
            try
            {
                string sql = "select * from activeUser where auID = " + id + "and autime = " + date;
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                if (dr.Read())//已经有该月份该人员的记录，其活跃度加1
                {
                    int cnt = (int)dr[2] + 1;
                    sql = "update activeUser set auCount = " + cnt + " where auID = " + id + "and autime = " + date;
                    dr.Close();
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();
                }
                else
                {
                    sql = "insert into activeUser values('" + id + "', '" + date + "', 1)";
                    dr.Close();
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
        }

        //key是否包含空格
        public static bool IsHaveSpace(string key)
        {
            for (int i = 0;i < key.Length; ++i)
            {
                if (key[i] == ' ')
                {
                    return true;
                }
            }
            return false;
        }

        //key是否为数据库中未存在的手机号格式
        public static bool IsAUsefulPhoneNumber(string telephone, string exception)
        {
            if (exception.Length == 0)
            {
                exception = "jfodnpd";//乱码
            }
            //验证手机号码格式（11位数字或为空）
            if (telephone.Length != 11)
            {
                if (telephone.Length != 0)
                {
                    MessageBox.Show("手机号码格式不正确！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                for (int i = 0; i < 11; ++i)
                {
                    if (Char.IsDigit(telephone[i]) == false)
                    {
                        MessageBox.Show("手机号码格式不正确！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                try
                {
                    conn = new SqlConnection(connString);
                    conn.Open();
                    string sql = "select * from theUser where uTelephone = '" + telephone + "' and uTelephone != '" + exception + "'";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    dr = comm.ExecuteReader();

                    //用户名存在
                    if (dr.Read())
                    {
                        MessageBox.Show("手机号码已经存在！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
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
                return true;
            }
        }

        //key是否为数据库中未存在的身份证格式
        public static bool IsAUsefulSFID(string sfid, string exception)
        {
            if (exception.Length == 0)
            {
                exception = "jfodnpd";//乱码
            }
            //验证手机号码格式（11位数字或为空）
            if (sfid.Length != 18)
            {
                if (sfid.Length != 0)
                {
                    MessageBox.Show("身份证号格式不正确！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                for (int i = 0; i < 17; ++i)
                {
                    if (Char.IsDigit(sfid[i]) == false)
                    {
                        MessageBox.Show("身份证号格式不正确！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if ((Char.IsDigit(sfid[17]) || sfid[17] == 'X') == false)
                    {
                        MessageBox.Show("身份证号格式不正确！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                try
                {
                    conn = new SqlConnection(connString);
                    conn.Open();
                    string sql = "select * from theUser where usfid = '" + sfid + "' and usfid != '" + exception + "'";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    dr = comm.ExecuteReader();

                    //用户名存在
                    if (dr.Read())
                    {
                        MessageBox.Show("身份证号已经存在！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
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
                return true;
            }
        }
    }
}

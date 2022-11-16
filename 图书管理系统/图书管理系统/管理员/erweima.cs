using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace 图书管理系统
{
    public partial class erweima : Form
    {
        public erweima()
        {
            InitializeComponent();
        }

        private void choiceImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "图片|*.jpg|图片|*.png";
            //openImage.Filter = "all files | *.*";
            if (DialogResult.OK == openImage.ShowDialog())
            {
                imagePath.Text = openImage.FileName;
                codeimg.Image = Image.FromFile(openImage.FileName);
            }
        }

        [DllImport("opencvdll.dll", CharSet = CharSet.Ansi, EntryPoint = "exportCode", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr exportCode(string path);
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "";
            string temp = imagePath.Text;
            if (temp.Length > 0)
            {
                temp = temp.Replace("\\", "/");
                IntPtr code = exportCode(temp);
                s = Marshal.PtrToStringAnsi(code);
                //string ss = s;
                //this.code.Text = ss;

            }

            string information = s;
            string[] a = information.Split(' ');
            Console.WriteLine(a[0]);
            string b = a[0].Substring(1, 1);
            Console.WriteLine(b);

            //写入到数据库中的category表
            //声明连接数据库
            string connstring = "Data Source=.;Database=BMS;User ID=sa;Pwd=648371";
            SqlConnection conn = new SqlConnection(connstring);
            string sql = String.Format("insert into [booktype] values('{0}','{1}')", a[1], b);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show("插入成功", "成功提示", MessageBoxButtons.OK);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imagePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeimg_Click(object sender, EventArgs e)
        {

        }
    }
}

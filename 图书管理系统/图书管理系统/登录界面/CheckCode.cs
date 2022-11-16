using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class CheckCode : Form
    {
        public bool passCheckCode = false;//通过验证标志

        ValidCode validCode;//验证码
        public CheckCode()
        {
            InitializeComponent();
        }

        //更新验证码
        private void pi_Click(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
        }
        
        //加载验证码
        private void CheckCode_Load(object sender, EventArgs e)
        {
            validCode = new ValidCode();
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
        }

        //返回按钮
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定按钮
        private void btnOk_Click(object sender, EventArgs e)
        {
            string a = "";
            string b = "";
            for (int i = 0;i < text.Text.Length;++i)
            {
                a += Char.ToLower(text.Text[i]);
            }
            for (int i = 0;i < validCode.checkCode.Length;++i)
            {
                b += Char.ToLower(validCode.checkCode[i]);
            }
            if (a == b)
            {
                passCheckCode = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("验证码不正确，请重新输入！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

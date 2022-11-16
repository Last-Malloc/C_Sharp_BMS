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
    public partial class AutoLogin : Form
    {
        public bool passAutoLogin = false;

        int cnt = 0;//计时器计时次数（3s即表示默许自动登录）

        public AutoLogin()
        {
            InitializeComponent();
            timer.Enabled = true;
            timer.Interval = 1000;//计时周期为1s
        }
        
        //cnt加1，3s后触发默许自动登录
        private void timer_Tick(object sender, EventArgs e)
        {
            ++cnt;
            string str = "自动登录中";
            switch (cnt % 3)
            {
                case 0:str += "。("; break;
                case 1: str += "。。("; break;
                case 2: str += "。。。(";break;
            }
            str += (3 - cnt).ToString() + "s)";

            label1.Text = str;
            if (cnt == 4)
            {
                passAutoLogin = true;
                this.Close();
            }
        }

        //点击取消即关闭窗口同时（取消自动登录）
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

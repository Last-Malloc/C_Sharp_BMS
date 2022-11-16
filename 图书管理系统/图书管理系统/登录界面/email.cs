using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace 图书管理系统.登录界面
{
    public partial class email : Form
    {
        public email()
        {
            InitializeComponent();
        }

        public string pwd;
        public string email1;

        //生成6位数字和大写字母的验证码
        private string createrandom(int codelengh)
        {
            int rep = 0;
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + rep;
            rep++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> rep)));
            for (int i = 0; i < codelengh; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }

            pwd = str;
            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            email1 = textBox1.Text.Trim();
            if (email1 == "")
            {
                MessageBox.Show("请输入邮箱地址！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //实例化一个发送邮件类。
            MailMessage mailMessage = new MailMessage();
            //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
            mailMessage.From = new MailAddress("2218220269@qq.com");
            //收件人邮箱地址。
            mailMessage.To.Add(new MailAddress(textBox1.Text));
            //邮件标题。
            mailMessage.Subject = "这是你的验证码";
            string verificationcode = createrandom(6);
            Console.WriteLine(verificationcode);
            //邮件内容。
            mailMessage.Body = "你的验证码是" + verificationcode;
            //实例化一个SmtpClient类。
            SmtpClient client = new SmtpClient();       
            client.Host = "smtp.qq.com";
            //使用安全加密连接。
            client.EnableSsl = true;
            //不和请求一块发送。
            client.UseDefaultCredentials = false;
            //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
            client.Credentials = new NetworkCredential("2218220269@qq.com", "qqxiasixykfrdihj");
            //发送
            client.Send(mailMessage);
            MessageBox.Show("发送成功！", "恭喜！");
        }


        //验证
        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text.Trim();
            if(a=="")
            {
                MessageBox.Show("请输入验证码！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(a==pwd)
            {
                MessageBox.Show("身份验证成功！", "验证成功", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                MessageBox.Show("身份验证失败！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

        }
    }
}

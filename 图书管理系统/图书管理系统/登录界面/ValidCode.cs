using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace 图书管理系统
{
    class ValidCode
    {
        private readonly string allCode = "1234567890qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM";//验证码为随机字母或数字串
        public string checkCode;

        public ValidCode()
        {
        }

        //生成长度为5的字母/数字串并返回
        private string GenerateRandomString()
        {
            string str = "";
            Random random = new Random();
            for (int i = 0; i < 5; ++i)
            {
                str += allCode[random.Next(allCode.Length)];
            }
            return str;
        }

        // 为图片添加波形滤镜效果
        private Bitmap TwistImage(Bitmap srcBmp, double dMultValue, double dPhase)
        {
            Bitmap destBmp = new Bitmap(srcBmp.Width, srcBmp.Height);
            Graphics graph = Graphics.FromImage(destBmp);
            graph.FillRectangle(new SolidBrush(Color.White), 0, 0, destBmp.Width, destBmp.Height);
            graph.Dispose();

            double dBaseAxisLen = (double)destBmp.Height;

            for (int i = 0; i < destBmp.Width; i++)
            {
                for (int j = 0; j < destBmp.Height; j++)
                {
                    double dx = 0;
                    dx = (Math.PI * 2 * (double)j) / dBaseAxisLen;
                    dx += dPhase;
                    double dy = Math.Sin(dx);

                    int nOldX = 0, nOldY = 0;
                    nOldX = i + (int)(dy * dMultValue);
                    nOldY = j;

                    Color color = srcBmp.GetPixel(i, j);
                    if (nOldX >= 0 && nOldX < destBmp.Width
                     && nOldY >= 0 && nOldY < destBmp.Height)
                    {
                        destBmp.SetPixel(nOldX, nOldY, color);
                    }
                }
            }
            return destBmp;
        }

        //返回生成的验证码图片
        public Stream CreateCheckCodeImage()
        {
            checkCode = GenerateRandomString();
            MemoryStream ms = null;
            Bitmap image = new Bitmap(130, 40);
            Graphics g = Graphics.FromImage(image);
            try
            {
                Random random = new Random();
                g.Clear(Color.White);//填充白色背景

                //绘制乱线
                for (int i = 0; i < 18; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.FromArgb(random.Next()), 1), x1, y1, x2, y2);
                }

                Font font = new Font("Times New Roman", 15, FontStyle.Bold);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 130, 40), Color.Blue, Color.DarkRed, 1.2f, true);

                for (int i = 0; i < 5; i++)
                {
                    g.DrawString(checkCode[i].ToString(), font, brush, 1 + i * 15, 2);
                }

                // 画图片的前景噪音点 
                for (int i = 0; i < 150; i++)
                {
                    int x = random.Next(130);
                    int y = random.Next(40);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }

                // 画图片的波形滤镜效果 
                image = TwistImage(image, 3, 1);

                // 画图片的边框线 
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, 129, 39);
                ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
            return ms;
        }
    }
}

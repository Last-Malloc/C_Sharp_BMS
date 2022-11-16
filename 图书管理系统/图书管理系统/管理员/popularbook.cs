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
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace 图书管理系统
{

    public partial class popularbook : Form
    {
        public popularbook()
        {
            InitializeComponent();
        }

        public string information;

        private void popularbook_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bMSDataSet8.activeBook”中。您可以根据需要移动或删除它。
            this.activeBookTableAdapter.Fill(this.bMSDataSet8.activeBook);

        }

        //获得统计的间隔时间
        private void button1_Click(object sender, EventArgs e)
        {
            //获得选择内容和具体条件
            string select = comboBox1.SelectedItem.ToString();
            information = textBox1.Text.Trim();
            if(information.Length!=6)
            {
                MessageBox.Show("请输入正确信息，例如“201909”！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (information == "")
            {
                MessageBox.Show("请输入具体信息，例如某月某季某年！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //声明连接数据库语句
            string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";

            //假设按月份统计
            if (select == "月统计")
            {
                string sqlmonth = String.Format("select * from [activeBook] where abTime='{0}' order by abCount DESC", information);
                SqlConnection connmonth = new SqlConnection(connstring);
                connmonth.Open();
                SqlCommand commmonth = new SqlCommand(sqlmonth, connmonth);
                SqlDataAdapter da = new SqlDataAdapter(commmonth);
                DataSet ds = new DataSet();
                da.Fill(ds, "activeBook");
                try
                {
                    dataGridView1.DataSource = ds;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                dataGridView1.DataMember = "activeBook";
                connmonth.Close();

            }

            //假设是按季统计
            if (select == "季统计")
            {
                Quarter quarter = new Quarter(information);
                this.Visible = false;
                quarter.ShowDialog();
                this.Visible = true;
            }

            //假设是按半年统计
            if (select == "半年统计")
            {
                halfyear halfyear = new halfyear(information);
                this.Visible = false;
                halfyear.ShowDialog();
                this.Visible = true;
            }

            //假设是按照年统计
            if (select == "年统计")
            {
                管理员.year1 year = new 管理员.year1(information);
                this.Visible = false;
                year.ShowDialog();
                this.Visible = true;
            }

        }

        //返回主界面
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 显示图表_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
            //声明查询语句
            string sqlchart = String.Format("select abISBN 'ISBN码', abTime '统计时间',abCount '统计数量',abName '图书名称' from [activeBook] where abTime='{0}'", information);
            SqlConnection connchart = new SqlConnection(connstring);
            connchart.Open();
            SqlDataAdapter myda;
            DataSet myds;
            myda = new SqlDataAdapter(sqlchart, connstring);
            myds = new DataSet();
            myda.Fill(myds, "activeBook");
            connchart.Close();

            chart1.DataSource = myds.Tables["activeBook"];
            chart1.Series[0].XValueMember = "图书名称";
            chart1.Series[0].YValueMembers = "统计数量";
            chart1.Show();
            AddStripLine(chart1);
        }

        private void AddStripLine(Chart chartInfo)
        {
            double max = 170;
            StripLine stripMax = new StripLine();
            stripMax.Text = string.Format("最大：{0:F}", max);//展示文本
            stripMax.ForeColor = Color.FromArgb(255, 255, 255);//字体颜色
            stripMax.Font = new Font("宋体", 20);//文本字体
            stripMax.BackColor = Color.FromArgb(245, 245, 245);//背景色
            stripMax.Interval = 0;//间隔
            stripMax.IntervalOffset = max;//偏移量
            stripMax.StripWidth = 0.005;//线宽 //   stripMax.ForeColor = Color.White;//前景色
            stripMax.TextAlignment = StringAlignment.Near;//文本对齐方式          
            chartInfo.ChartAreas[0].AxisY.StripLines.Add(stripMax);//添加到ChartAreas中
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel d = new ExportToExcel();
            d.OutputAsExcelFile(dataGridView1);
        }
    }
}

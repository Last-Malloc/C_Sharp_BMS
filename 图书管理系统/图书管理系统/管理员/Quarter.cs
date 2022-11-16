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
    public partial class Quarter : Form
    {
        private static string a;
        public int b;
        public Quarter(string key)
        {
            a = key;
            b = Int32.Parse(a);
            InitializeComponent();
        }
        private void Quarter_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bMSDataSet9.activeBook”中。您可以根据需要移动或删除它。
            // this.activeBookTableAdapter.Fill(this.bMSDataSet9.activeBook);

        }

        //返回主界面
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //按季度查询（输入季度）
        private void button2_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
            //声明查询语句
            string sqlquarter = String.Format("select abISBN 'ISBN码', sum(abCount) '统计数量',abName '图书名称' from [activeBook] where abTime <= {0} and abTime >= {1} group by abName, abISBN order by sum(abCount) DESC", b, b - 3);
            SqlConnection connquarter = new SqlConnection(connstring);
            connquarter.Open();
            SqlCommand commquarter = new SqlCommand(sqlquarter, connquarter);

            SqlDataAdapter da = new SqlDataAdapter(commquarter);
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
            connquarter.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
            //声明查询语句
            string sqlchart = String.Format("select abISBN 'ISBN码', sum(abCount) '统计数量',abName '图书名称' from [activeBook] where abTime <= {0} and abTime >= {1} group by abName, abISBN", b, b - 3);
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
            //stripMax.Text = string.Format("最大：{0:F}", max);//展示文本
            stripMax.ForeColor = Color.FromArgb(255, 255, 255);//字体颜色
            stripMax.Font = new Font("宋体", 20);//文本字体
            stripMax.BackColor = Color.FromArgb(245, 245, 245);//背景色
            stripMax.Interval = 0;//间隔
            stripMax.IntervalOffset = max;//偏移量
            stripMax.Text = String.Format("活跃度");
            stripMax.StripWidth = 0.005;//线宽 //   stripMax.ForeColor = Color.White;//前景色
            stripMax.TextAlignment = StringAlignment.Near;//文本对齐方式          
            chartInfo.ChartAreas[0].AxisY.StripLines.Add(stripMax);//添加到ChartAreas中

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportToExcel d = new ExportToExcel();
            d.OutputAsExcelFile(dataGridView1);
        }
    }
}

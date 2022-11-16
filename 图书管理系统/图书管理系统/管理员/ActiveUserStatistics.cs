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

namespace 图书管理系统
{
    public partial class ActiveUserStatistics : Form
    {
        SqlConnection conn;
        DataSet ds, dsShowTrend;
        string connString = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
        string instituteLimit = "不限", classNameLimit = "不限"; 

        //填充年份选择控件combobox
        void AddToCbYear()
        {
            int year = DateTime.Now.Year;
            for (int i = 2010;i <= year;++i)
            {
                cbYear1.Items.Add(i.ToString() + "年");
                cbYear2.Items.Add(i.ToString() + "年");
            }
            cbYear1.SelectedIndex = 0;
            cbYear2.SelectedIndex = 0;
        }

        private void cbYear1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            cbMonth1.Items.Clear();
            if (year.ToString() + "年" == cbYear1.Text)
            {
                for (int i = 1; i <= month; ++i)
                {
                    cbMonth1.Items.Add(i.ToString() + "月");
                }
            }
            else
            {
                for (int i = 1; i <= 12; ++i)
                {
                    cbMonth1.Items.Add(i.ToString() + "月");
                }
            }
            cbMonth1.SelectedIndex = 0;
        }

        private void cbYear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            cbMonth2.Items.Clear();
            if (year.ToString() + "年" == cbYear2.Text)
            {
                for (int i = 1; i <= month; ++i)
                {
                    cbMonth2.Items.Add(i.ToString() + "月");
                }
            }
            else
            {
                for (int i = 1; i <= 12; ++i)
                {
                    cbMonth2.Items.Add(i.ToString() + "月");
                }
            }
            cbMonth2.SelectedIndex = 0;
        }

        //构造函数
        public ActiveUserStatistics()
        {
            InitializeComponent();

            conn = new SqlConnection(connString);

            AddToCbYear();
            cbMonth1.SelectedIndex = 0;
            cbMonth2.SelectedIndex = 0;
        }

        //窗口 加载
        private void ActiveUserStatistics_Load(object sender, EventArgs e)
        {
            cbYear2.SelectedIndex = cbYear2.Items.Count - 1;
            cbMonth2.SelectedIndex = cbMonth2.Items.Count - 1;

            btnOK_Click(this, new EventArgs());

            不限ToolStripMenuItem.Checked = true;
            不限ToolStripMenuItem_Click(this, new EventArgs());

            //绘图
            PaintMyChart();
        }

        //确定按钮处理方法
        private void btnOK_Click(object sender, EventArgs e)
        {
            int dateStart = Int32.Parse(cbYear1.Text.Substring(0, 4)) * 100 + cbMonth1.SelectedIndex + 1;
            int dateEnd = Int32.Parse(cbYear2.Text.Substring(0, 4)) * 100 + cbMonth2.SelectedIndex + 1;

            if (dateStart > dateEnd)
            {
                MessageBox.Show("起始时间不能晚于终止时间，请重新选择！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //dataGridView控件显示的项：头像 id 姓名 性别 学院 班级 活跃度
            //判断是否有学院/班级限制
            string sqlPart = "";
            switch (instituteLimit)
            {
                case "不限": sqlPart = " ";break;
                case "信息": sqlPart = " and uInstitute = '信息' ";break;
                case "材料": sqlPart = " and uInstitute = '材料' "; break;
            }
            switch (classNameLimit)
            {
                case "不限": sqlPart += ""; break;
                case "计算171": sqlPart += " and uClassName = '计算171' "; break;
                case "计算172": sqlPart += " and uClassName = '计算172' "; break;
                case "信息172": sqlPart += " and uClassName = '信息172' "; break;
                case "金属171": sqlPart += " and uClassName = '金属171' "; break;
                case "金属172": sqlPart += " and uClassName = '金属172' "; break;
                case "材物171": sqlPart += " and uClassName = '材物171' "; break;
                case "材物172": sqlPart += " and uClassName = '材物171' "; break;
            }
            
            string sql = "select uHeadPic, uID, uName, uSex, uInstitute, uClassName, sum(auCount) allCount from theUser, activeUser where theUser.uID = activeUser.auID and auTime >= " + dateStart + " and auTime <= " + dateEnd + sqlPart + " group by uHeadPic, uID, uName, uSex, uInstitute, uClassName order by allCount desc";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = ds.Tables[0];
            
            //填充头像和性别
            for (int i = 0;i < ds.Tables[0].Rows.Count;++i)
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
            }

            PaintMyChart();
        }

        //----------------------------右键菜单-------------------------------
        //查看某人活跃度变化
        bool showTrend = false;//chart控件当前是否显示某个人的活跃度变化

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showTrend = true;
            int index = dataGridView1.CurrentCell.RowIndex;
            string id = (string)ds.Tables[0].Rows[index][1];
            string sql = "select cast(auTime as varchar) strAuTime, auCount from activeUser where auID = " + id;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dsShowTrend = new DataSet();
            dataAdapter.Fill(dsShowTrend);

            PaintMyChart();
        }

        //绘制chart;
        private void PaintMyChart()
        {
            //为chart添加拖动条
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false;
            chart1.ChartAreas["ChartArea1"].Area3DStyle.LightStyle = LightStyle.Realistic;
            chart1.ChartAreas["ChartArea1"].BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
            chart1.ChartAreas["ChartArea1"].CursorX.AutoScroll = true;
            chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = true;
            chart1.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
            chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Position = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Size = 10;
            chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;

            if (showTrend)
            {
                chart1.DataSource = dsShowTrend.Tables[0];
                chart1.Series["活跃度"].XValueMember = "strAuTime";
                chart1.Series["活跃度"].YValueMembers = "auCount";
            }
            else
            {
                chart1.DataSource = ds.Tables[0];
                chart1.Series["活跃度"].XValueMember = "uName";
                chart1.Series["活跃度"].YValueMembers = "allCount";
            }
        }

        //取消查看
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showTrend = false;
            PaintMyChart();
        }

        //除查看某一特定用户活跃度变化外的右键菜单
        private ToolStripMenuItem m1, m2, m3, m4, m5;

        private void 不限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            不限ToolStripMenuItem.Checked = true;
            信息ToolStripMenuItem.Checked = false;
            材料ToolStripMenuItem.Checked = false;
            instituteLimit = "不限";
            classNameLimit = "不限";

            this.班级筛选ToolStripMenuItem.DropDownItems.Clear();

            m1 = new ToolStripMenuItem("不限");
            m1.Click += OnClickMyItem1;
            this.班级筛选ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {m1});

            m1.Checked = true;

            btnOK_Click(this, e);
        }

        private void 信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            不限ToolStripMenuItem.Checked = false;
            信息ToolStripMenuItem.Checked = true;
            材料ToolStripMenuItem.Checked = false;
            instituteLimit = "信息";
            classNameLimit = "不限";

            this.班级筛选ToolStripMenuItem.DropDownItems.Clear();

            m1 = new ToolStripMenuItem("不限");
            m1.Click += OnClickMyItem1;
            m2 = new ToolStripMenuItem("计算171");
            m2.Click += OnClickMyItem2;
            m3 = new ToolStripMenuItem("计算172");
            m3.Click += OnClickMyItem3;
            m4 = new ToolStripMenuItem("信息172");
            m4.Click += OnClickMyItem4;

            this.班级筛选ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { m1, m2, m3, m4 });

            m1.Checked = true;

            btnOK_Click(this, e);
        }

        private void 材料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            不限ToolStripMenuItem.Checked = false;
            信息ToolStripMenuItem.Checked = false;
            材料ToolStripMenuItem.Checked = true;
            instituteLimit = "材料";
            classNameLimit = "不限";

            this.班级筛选ToolStripMenuItem.DropDownItems.Clear();

            m1 = new ToolStripMenuItem("不限");
            m1.Click += OnClickMyItem1;
            m2 = new ToolStripMenuItem("金属171");
            m2.Click += OnClickMyItem2;
            m3 = new ToolStripMenuItem("金属172");
            m3.Click += OnClickMyItem3;
            m4 = new ToolStripMenuItem("材物171");
            m4.Click += OnClickMyItem4;
            m5 = new ToolStripMenuItem("材物172");
            m5.Click += OnClickMyItem5;

            this.班级筛选ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { m1, m2, m3, m4 });

            m1.Checked = true;

            btnOK_Click(this, e);
        }

        
        //右键菜单二级菜单点击第一项的响应函数
        private void OnClickMyItem1(object sender, EventArgs e)
        {
            int index;//当前选中项为：不限/信息/材料
            if (不限ToolStripMenuItem.Checked == true)
            {
                index = 0;
            }
            else if (信息ToolStripMenuItem.Checked == true)
            {
                index = 1;
            }
            else
            {
                index = 2;
            }

            switch(index)
            {
                case 0: m1.Checked = true;classNameLimit = "不限";break;
                case 1: m1.Checked = true; m2.Checked = false; m3.Checked = false; m4.Checked = false; classNameLimit = "不限"; break;
                case 2: m1.Checked = true; m2.Checked = false; m3.Checked = false; m4.Checked = false; m5.Checked = false; classNameLimit = "不限"; break;
            }

            btnOK_Click(this, e);
        }

        //右键菜单二级菜单点击第二项的响应函数
        private void OnClickMyItem2(object sender, EventArgs e)
        {
            int index;//当前选中项为：不限/信息/材料
            if (信息ToolStripMenuItem.Checked == true)
            {
                index = 1;
            }
            else
            {
                index = 2;
            }

            switch (index)
            {
                case 1: m1.Checked = false; m2.Checked = true; m3.Checked = false; m4.Checked = false; classNameLimit = "计算171"; break;
                case 2: m1.Checked = false; m2.Checked = true; m3.Checked = false; m4.Checked = false; m5.Checked = false; classNameLimit = "金属171"; break;
            }

            btnOK_Click(this, e);
        }

        //右键菜单二级菜单点击第三项的响应函数
        private void OnClickMyItem3(object sender, EventArgs e)
        {
            int index;//当前选中项为：不限/信息/材料
            if (信息ToolStripMenuItem.Checked == true)
            {
                index = 1;
            }
            else
            {
                index = 2;
            }

            switch (index)
            {
                case 1: m1.Checked = false; m2.Checked = false; m3.Checked = true; m4.Checked = false; classNameLimit = "计算172"; break;
                case 2: m1.Checked = false; m2.Checked = false; m3.Checked = true; m4.Checked = false; m5.Checked = false; classNameLimit = "金属172"; break;
            }

            btnOK_Click(this, e);
        }

        //右键菜单二级菜单点击第四项的响应函数
        private void OnClickMyItem4(object sender, EventArgs e)
        {
            int index;//当前选中项为：不限/信息/材料
            if (信息ToolStripMenuItem.Checked == true)
            {
                index = 1;
            }
            else
            {
                index = 2;
            }

            switch (index)
            {
                case 1: m1.Checked = false; m2.Checked = false; m3.Checked = false; m4.Checked = true; classNameLimit = "信息172"; break;
                case 2: m1.Checked = false; m2.Checked = false; m3.Checked = false; m4.Checked = true; m5.Checked = false; classNameLimit = "材物171"; break;
            }

            btnOK_Click(this, e);
        }

        //右键菜单二级菜单点击第五项的响应函数
        private void OnClickMyItem5(object sender, EventArgs e)
        {
            m1.Checked = false;
            m2.Checked = false;
            m3.Checked = false;
            m4.Checked = false;
            m5.Checked = true;
            classNameLimit = "材物172";

            btnOK_Click(this, e);
        }
    }
}

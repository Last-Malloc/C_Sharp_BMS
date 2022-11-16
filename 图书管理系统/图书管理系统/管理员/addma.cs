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
using ZXing;

namespace 图书管理系统.管理员
{
    public partial class addma : Form
    {
        public addma()
        {
            InitializeComponent();
        }

        private barcodeclass bcc = new barcodeclass();
        private DocementBase _docement;
        public static string connstring = "Data Source=.;Initial Catalog=BMS;User ID=sa;Pwd=648371";
        public string id;
        public string isbn;
        public int number;
        public string message;


        /* private void comboBox1_Click(object sender, EventArgs e)
         {
             //设置下拉框的选项
             string sqldata = "select uID from [Loan]";
             SqlConnection conndata = new SqlConnection(connstring);
             conndata.Open();
             DataSet ds = new DataSet();
             SqlDataAdapter da = new SqlDataAdapter(sqldata, conndata);
             da.Fill(ds, "Loan");
             comboBox1.DataSource = ds.Tables["Loan"];
             comboBox1.DisplayMember = "uID";
             //id = comboBox1.Text;
             //id = comboBox1.SelectedItem.ToString();
             //Console.WriteLine(id);
         }

         private void comboBox2_Click(object sender, EventArgs e)
         {
             //设置下拉框的选项
             //string sqldata = "select bISBN from [Loan] where uID='"+id+"'";
             string sqldata = "select bISBN from [Loan]" ;
             SqlConnection conndata = new SqlConnection(connstring);
             conndata.Open();
             DataSet ds1 = new DataSet();
             SqlDataAdapter da1 = new SqlDataAdapter(sqldata, conndata);
             da1.Fill(ds1, "Loan");
             comboBox2.DataSource = ds1.Tables["Loan"];
             comboBox2.DisplayMember = "bISBN";
             //DataRowView drw = (DataRowView)comboBox1.Items[0];
             isbn = comboBox2.Text;
             //isbn = comboBox2.SelectedItem.ToString();
             Console.WriteLine(isbn);

         }*/



        private void button1_Click(object sender, EventArgs e)
        {
            id = textBox1.Text.Trim();
            isbn = textBox2.Text.Trim();
            if (id == ""||isbn=="")
            {
                MessageBox.Show("请输入具体信息！", "生成失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
     
            //获得借书序号
            string num = "select num from [Loan] where uID='" + id + "' and bISBN='" + isbn + "'";
            SqlConnection connnum = new SqlConnection(connstring);
            connnum.Open();
            SqlCommand commnum = new SqlCommand(num, connnum);
            number = Convert.ToInt32(commnum.ExecuteScalar());

            
            if(number==0)
            {
                MessageBox.Show("请输入对应信息！", "生成失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(number<10)
            {
                message = id + "0" + number;
            }

            else if(number>=10)
            {
                message = id + number;
            }
            Console.WriteLine(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //生成条形码
            bcc.CreateBarCode(pictureBox1, message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //生成二维码
            bcc.CreateQuickMark(pictureBox1, message);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //保存
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("you must load an image first!");
                return;
            }
            else
            {
                _docement = new imageDocument(pictureBox1.Image);
            }
            _docement.showPrintPreviewDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请录入图像再进行解码");
                return;
            }

            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pictureBox1.Image);
            MessageBox.Show(result.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PnG Image|*.png|Wmf  Image|*.wmf";
            saveFileDialog.FilterIndex = 0;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("没有预览图片");
            }
            else if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void addma_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

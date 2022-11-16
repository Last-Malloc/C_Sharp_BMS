using AForge.Video.DirectShow;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class FaceRegister : Form
    {
        string id = "";//用户id

        //调用百度云人脸识别库
        //Api_Key
        public static string Api_Key = "lEbKE5V9xWEOIoPuI02MHLGV";
        //Secret_Key
        public static string Secret_Key = "VVGS5My5wO5sU3MA9nGnWqDrP2gqyU27";

        public FaceRegister(string key)
        {
            InitializeComponent();
            id = key;
        }

        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;

        //窗体加载
        private void facelogin_Load(object sender, EventArgs e)
        {
            // 刷新可用相机的列表
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //打开摄像头
            openCamera();
        }

        //打开摄像头
        public void openCamera()
        {
            //连接摄像头。
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.VideoResolution = videoSource.VideoCapabilities[0];

            // 枚举所有摄像头支持的像素，设置拍照为1920*1080
            foreach (VideoCapabilities capab in videoSource.VideoCapabilities)
            {
                if (capab.FrameSize.Width == 1920 && capab.FrameSize.Height == 1080)
                {
                    videoSource.VideoResolution = capab;
                    break;
                }
            }
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();
        }

        //关闭摄像头并退出
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 点击确定进行人脸识别注册
        private void btnOK_Click(object sender, EventArgs e)
        {
            FacePhotoRegister(SavePicture(id), id);
        }

        //人脸注册
        public static bool FacePhotoRegister(string fileName, string id)
        {
            var client = new Baidu.Aip.Face.Face(Api_Key, Secret_Key);

            //jpg图片转为base64字符串
            var image = "";
            Bitmap bmp1 = new Bitmap(fileName);
            using (MemoryStream ms1 = new MemoryStream())
            {
                bmp1.Save(ms1, ImageFormat.Jpeg);
                byte[] arr1 = new byte[ms1.Length];
                ms1.Position = 0;
                ms1.Read(arr1, 0, (int)ms1.Length);
                ms1.Close();
                image = Convert.ToBase64String(arr1);
            }
            bmp1.Dispose();
            var imageType = "BASE64";
            var groupId = "GROUP1";
            var userId = id;

            string result = "";
            try
            {
                var tResult  = client.UserAdd(image, imageType, groupId, userId);
                result = tResult.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请检查网络连接！！！", "网络错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //验证是否成功识别人脸
            JObject jo_result = (JObject)JsonConvert.DeserializeObject(result);
            if ((string)jo_result["error_msg"] != "SUCCESS")
            {
                MessageBox.Show("对不起，请把脸放上！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            MessageBox.Show("人脸扫描成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        // 截图保存图片,名为id.jpg
        public string SavePicture(string id)
        {
            if (videoSource == null)
            {
                return null;
            }
            //截屏
            Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
            //图片路径名称
            string filePath = "..\\..\\图片\\人脸识别\\摄像头图片\\" + id + ".jpg";
            //将图片保存在本地文件里
            bitmap.Save(filePath, ImageFormat.Jpeg);
            bitmap.Dispose();//释放资源
            return filePath;//返回文件路径
        }

        private void FaceLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //停止摄像头
            videoSourcePlayer1.Stop();
        }
    }
}

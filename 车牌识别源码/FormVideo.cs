using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace 车牌识别
{
    public partial class FormVideo : Form
    {
        // 打开摄像头
        private VideoCapture cap = new VideoCapture();
        private int frameIndexLoop = 0;
        bool stop = true;
        Mat frameClone = new Mat();

        // hsv均衡化图
        private Mat HSVEvenimg = new Mat();
        //矩形集合
        private List<Rect> rectList = new List<Rect>();

        // 车牌图
        private static Mat matRoi = new Mat();

        public FormVideo()
        {
            InitializeComponent();            
        }


        // 实时显示视频
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //string rtsp = "rtsp://admin:dh123456@192.168.0.108:554/cam/realmonitor?channel=1&subtype=0";
            this.cap.Open(0);
            //this.cap.Open(rtsp);

            if (cap.IsOpened())
            {
                MessageBox.Show("打开摄像头成功...");
            }
            else
            {
                return;
            }

           

            while (stop) {

                if (stop)
                {
                    Mat image = new Mat();
                    this.cap.Read(image);

                    if (image.Empty())
                    {
                        stop = !stop;
                    }
                    else
                    {
                        int sleepTime = (int)Math.Round(1000 / this.cap.Fps);
                         //原始视频
                 //       this.picMatWithFlag.BackgroundImage = image.ToBitmap();

                       
                        Cv2.WaitKey(sleepTime);

                        if (this.frameIndexLoop % 5 == 0)
                        {
                             frameClone = image.Clone();
                          //   Random rd = new Random();
                          //   int random = rd.Next();
                          //   Plate_SVM.SaveCharSample(frameClone, PlateCategory.黑, "C:/Users/Myself/Desktop/车牌识别训练资源库--a/", "_" + random);
                        }

                        image.Release();//释放，

                    }
                }

                this.picMatWithFlag.Refresh();

                toolStripComboBox1_TextChanged(sender,e);
             
            }



        }

        
            /// <summary>
            /// 颜色交换
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            // 颜色法
            this.HSVEvenimg = my_Method.ColorMethod(this.frameClone, 5, 50, 255, this.HSVEvenimg);
            this.picColorM.Image = this.HSVEvenimg.ToBitmap();
    //        this.GenerateROI(this.HSVEvenimg, this.panelColor, false);

            // 颜色区域
            Mat element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(11, 2));
            // 定义点的二维数组
            OpenCvSharp.Point[][] contours = null;
            HierarchyIndex[] hierarchies = null;

            contours = my_Method.ColorRange(element, contours, hierarchies, frameClone, this.HSVEvenimg,5);

            string s = this.lblText.Text.Trim();
            //图像显示识别结果

            if (this.lblText.Text.Trim() != null && this.lblText.Text.Trim() != "")
            {
                String rest = this.lblText.Text.Trim();
                if ((int)rest[0] < 127)
                {
                    rest = rest.Remove(0, 1);
                }
                if (my_Method.bluenum > my_Method.greennum)
                {
                    if (rest.Length > 7)
                    {
                        rest.Remove(7);
                    }
                }
                if (my_Method.bluenum > my_Method.greennum)
                {
                    if (rest.Length > 8)
                    {
                        rest.Remove(8);
                    }
                }
                Regex reg = new Regex("[\u4e00-\u9fa5]+");
                foreach (Match Chinese in reg.Matches(rest))
                {
                    int indexof = rest.IndexOf(Chinese.Value);
                    rest = rest.Remove(indexof, 1);
                    int has = Form_Main.hashRes.Count;
                    if (Form_Main.hashRes.ContainsKey(Chinese.Value))
                    {
                        rest = rest.Insert(indexof, Form_Main.hashRes[Chinese.Value].ToString());
                    }
                }
                my_Method.matWithFlag.PutText("result:   "+rest, new OpenCvSharp.Point(50, 100), HersheyFonts.HersheyTriplex, 0.8, Scalar.Yellow, 2);
            }

            // 显示查找的轮廓
            this.picMatWithFlag.Image =   my_Method.matWithFlag.ToBitmap();

            this.rectList.Clear();

            for (int i = 0; i < contours.Length; i++)
            {
                // 轮廓的最小矩形
                Rect rect = Cv2.BoundingRect(contours[i]);
                this.rectList.Add(rect); // 添加到集合
            }

            // 遍历找到的矩形  然后截取出来
            foreach (var item in this.rectList)
            {

                if (item.Width >= 40 &&
                    item.Width <= 2000 &&
                    item.Height >= 20 &&
                    item.Height <= 2000&&
                    item.Width / item.Height > 0.8 &&
                    item.Width / item.Height < 5)
                {
                    //SubMat  对矩形区域进行截取
                    matRoi = this.frameClone.SubMat(item);
                    
                    if (Plate_Car_SVM.TestCar(matRoi) == PlateCar.车牌)
                    {


                        // 显示截取的矩形
                        this.picRect.Image = matRoi.ToBitmap();

                        // 进行分割
                        List<Mat> ListMat = my_Method.carCharSplit(matRoi);

                        List<PlateCategory> category = Plate_SVM.TestList(ListMat);

                        TextBox tx = new TextBox();
                        for (int index = 0; index < category.Count; index++)
                        {

                            if (category[index] == 0)
                            {

                                tx.AppendText(string.Format("{0}", ""));

                            }
                            else
                            {
                                tx.AppendText(string.Format("{0}", category[index]));

                            }


                        }

                        string res = tx.Text.Replace("_", "");

                        Console.WriteLine(res.Length + "   : 第一个");

                        for (int i = 0; i < res.Length; i++)
                        {
                            // 判断第一个是不是汉字 不是就删除
                            // 不是汉字
                            if ((int)res[0] < 127 && res.Length > 1 && res != null && res != "")
                            {
                                res = res.Substring(1);
                                // 显示识别结果
                                this.lblText.Text = res;

                            }
                            else
                            {
                                // 显示识别结果
                                this.lblText.Text = res;

                            }
                        }


                        GC.Collect();

                    }

                }
            }

       

        }


        /// <summary>
        ///  点击关闭摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.cap.Release();
            this.picMatWithFlag.Image = null;
            stop = false;
        }

       
    }
  }


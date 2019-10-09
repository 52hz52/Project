using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace 车牌识别
{
    public partial class Form_Main : Form
    {
        // hsv均衡化图
        private Mat HSVEvenimg = new Mat();
        private Mat srcImg;
        StreamWriter file;

        //创建一个数据表来存储图块的坐标 用于车牌从左到右的排序问题
        DataTable dtMatANDRect = new DataTable();
        Dictionary<int, Mat> FileNameAndMat = new Dictionary<int, Mat>();
        // 存储图片名称
        List<string> fileNames = new List<string>();

        //腐蚀图
        private Mat threshold_Erode;
        List<Mat> PicMatrois = null;

        // 键值对  键=图片名 值=图片中车牌
        Dictionary<String, List<Mat>> FileNameAndResult = new Dictionary<String, List<Mat>>();

        public static Hashtable hashRes = new Hashtable();

        private List<Rect> rectList = new List<Rect>();
        public Form_Main()
        {
            InitializeComponent();
            //启动加载文件列表
            DateTime dtStart = DateTime.Now;

            string imgfile = "C:/test-imgs";
            if (!Directory.Exists(imgfile)) {
                MessageBox.Show("图片测试文件夹路径需为:C: test-imgs");
                return;
            }
            OpenFlie(imgfile);
            Thread CreatFL = new Thread(CreatFile);
            CreatFL.Start();
            CreatFL.Join();
            Thread LoadHashtable = new Thread(LoadChinaeseToString);
            LoadHashtable.Start();
            LoadHashtable.Join();
            Thread PI = new Thread(ProImg);
            PI.Start();
            DateTime dtEnd = DateTime.Now;
            TimeSpan timeSpan = dtEnd - dtStart;
            this.tTimeInfo.Text = string.Format("耗时：{0}", timeSpan.TotalMilliseconds);
        }
        //初始化数据表
        private void LoadDT()
        {
            dtMatANDRect.Columns.Add("MatIndex", typeof(int));
            dtMatANDRect.Columns.Add("X", typeof(int));
            dtMatANDRect.Columns.Add("Y", typeof(int));
        }
        //用于汉字转换成拼音的HashTable
        private static void LoadChinaeseToString()
        {
            hashRes.Add("京", "JING");
            hashRes.Add("津", "JINA");
            hashRes.Add("沪", "HU");
            hashRes.Add("渝", "YUA");
            hashRes.Add("蒙", "MENG");
            hashRes.Add("新", "XIN");
            hashRes.Add("藏", "ZANG");
            hashRes.Add("宁", "NING");
            hashRes.Add("桂", "GUIA");
            hashRes.Add("黑", "HEI");
            hashRes.Add("吉", "JI");
            hashRes.Add("辽", "LIAO");
            hashRes.Add("晋", "JINB");
            hashRes.Add("冀", "JI");
            hashRes.Add("青", "QING");
            hashRes.Add("鲁", "LU");
            hashRes.Add("豫", "YUB");
            hashRes.Add("苏", "SU");
            hashRes.Add("皖", "WAN");
            hashRes.Add("浙", "ZHE");
            hashRes.Add("闽", "MIN");
            hashRes.Add("赣", "GANA");
            hashRes.Add("湘", "XIANG");
            hashRes.Add("鄂", "E");
            hashRes.Add("粤", "YUE");
            hashRes.Add("琼", "QIONG");
            hashRes.Add("甘", "GANB");
            hashRes.Add("陕", "SHAN");
            hashRes.Add("贵", "GUIB");
            hashRes.Add("云", "YUN");
            hashRes.Add("川", "CHUAN");
        }
        //创建存放结果集的文件夹与文件
        private void CreatFile()
        {
            //启动加载xml  在debug下 xml
            Plate_SVM.Load(Application.StartupPath + @"\MyTestChar.xml");
            Plate_Car_SVM.Load(Application.StartupPath + @"\MyTestCar.xml");

            String DirectoryPath = @"C:\test-results";
            if (!Directory.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }

            if (File.Exists(DirectoryPath + @"\No14866mresults.txt"))
            {
                File.Delete(DirectoryPath + @"\No14866mresults.txt");
                FileStream fs = new FileStream(DirectoryPath + @"\No14866mresults.txt", FileMode.Create, FileAccess.ReadWrite);//创建写入文件   
                file = new StreamWriter(fs);
            }
            else
            {
                FileStream fs = new FileStream(DirectoryPath + @"\No14866mresults.txt", FileMode.Create, FileAccess.ReadWrite);//创建写入文件   
                file = new StreamWriter(fs);
            }
        }

        //调用本地DLL 进行文件排序
        public class FileNameSort : IComparer
        {
            //调用DLL
            [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
            private static extern int StrCmpLogicalW(string param1, string param2);


            //前后文件名进行比较。
            public int Compare(object name1, object name2)
            {
                if (null == name1 && null == name2)
                {
                    return 0;
                }
                if (null == name1)
                {
                    return -1;
                }
                if (null == name2)
                {
                    return 1;
                }
                return StrCmpLogicalW(name1.ToString(), name2.ToString());
            }
        }
        //图片处理
        private void ProImg()
        {
            int FsIndex = 0;
            string imagePath = @"C:\test-imgs";
            if (!Directory.Exists(imagePath)) {
                MessageBox.Show("图片测试文件夹路径需为:C: test-imgs");
                return;
            }
            string[] subDirecotries = Directory.GetDirectories(imagePath);
            DirectoryInfo di = new DirectoryInfo(imagePath);
            if (subDirecotries.Length == 0)
            {
                FileInfo[] FileList = di.GetFiles();
                ArrayList FAL = new ArrayList();
                //筛选图片
                foreach (FileInfo Files in FileList)
                {
                    String FilesName = (Files.Name).ToUpper();
                    if (FilesName.EndsWith(".JPG") || FilesName.EndsWith(".PNG") || FilesName.EndsWith(".BMP"))
                    {
                        FAL.Add(Files);
                    }
                }
                //清空数组
                Array.Clear(FileList, 0, FileList.Length);
                //重新赋值
                FileList = (FileInfo[])(FAL.ToArray(typeof(FileInfo)));
                //根据文件名排序
                Array.Sort(FileList, new FileNameSort());
                //把文件名存进数组
                for (int i = 0; i < FileList.Length; i++)
                {
                    fileNames.Add(FileList[i].FullName);
                }
                //--------------获取图片处理所需的参数和阈值----------------------
                //加载Datatable数据表
                LoadDT();
                //模糊
                int blurSize = int.Parse(this.blurSize.Text);
                // 边缘
                int cannyThreshold1 = int.Parse(this.canny1.Text);
                int cannyThreshold2 = int.Parse(this.canny2.Text);

                // 膨胀的 element
                int ksizex = int.Parse(this.txDaliteX.Text);
                int ksizey = int.Parse(this.txDaliteY.Text);

                int minWidth = int.Parse(this.txtMinWidth.Text);
                int minHeight = int.Parse(this.txtMinHeight.Text);
                int maxWidth = int.Parse(this.txtMaxWidth.Text);
                int maxHeight = int.Parse(this.txtMaxHeight.Text);
                float WhScale = float.Parse(this.txtWHScale.Text);

                for (int index = 0; index < fileNames.Count; index++)
                {
                    dtMatANDRect.Clear();
                    //清空PicMatrois图片结果集 
                    PicMatrois = new List<Mat>();
                    //rectList.Clear();
                    int MatIndex = 0;
                    FileNameAndMat.Clear();
                    string fileName = fileNames[index];
                    //调用识别方法
                    // 读取原图
                    this.srcImg = Cv2.ImRead(fileName);
                    // 归一化
                    if (srcImg.Cols > 2000)
                    {
                        Cv2.Resize(srcImg, srcImg, new OpenCvSharp.Size(srcImg.Cols * 0.3, srcImg.Rows * 0.3));
                    }
                    //原图变化
                    this.picSrc.Image = this.srcImg.ToBitmap();
                    //获取HSV均衡图
                    this.HSVEvenimg = my_Method.ColorMethod(this.srcImg, blurSize, cannyThreshold1, cannyThreshold2, this.HSVEvenimg);

                    // 膨胀的 element
                    Mat element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(ksizex, ksizey));


                    // 定义点的二维数组,颜色法筛选开始
                    if (this.srcImg == null) return;
                    if (this.srcImg.Empty()) return;

                    Point[][] contours = null;
                    HierarchyIndex[] hierarchies = null;

                    contours = my_Method.ColorRange(element, contours, hierarchies, this.srcImg, this.HSVEvenimg, 3);

                    for (int i = 0; i < contours.Length; i++)
                    {
                        // 轮廓的最小矩形
                        Rect rect = Cv2.BoundingRect(contours[i]);
                        if (rect.Width >= minWidth &&
                             rect.Width <= maxWidth &&
                             rect.Height >= minHeight &&
                             rect.Height <= maxHeight &&
                             rect.Width / rect.Height > 0.8 &&
                             rect.Width / rect.Height < WhScale
                             )
                        {
                            Mat matRoi = this.srcImg.SubMat(rect);
                            PlateCar plateCar = Plate_Car_SVM.TestCar(matRoi);
                            if (PlateCar.车牌 == plateCar)
                            {
                                MatIndex++;
                                FileNameAndMat.Add(MatIndex, matRoi);
                                Console.WriteLine(dtMatANDRect.Columns.Count);
                                dtMatANDRect.Rows.Add(MatIndex, rect.X, rect.Y);
                            }
                        }
                    }
                    //判断颜色法是否筛选出符合要求的车牌，如果有添加进集合，结束筛选，开始下张图片
                    if (MatIndex != 0)
                    {
                        DataView dv = dtMatANDRect.DefaultView;
                        dv.Sort = "X ASC";
                        //dtMatANDRect.Clear();
                        dtMatANDRect = dv.ToTable();
                        for (int i = 0; i < dtMatANDRect.Rows.Count; i++)
                        {
                            int Mindex = int.Parse(dtMatANDRect.Rows[i]["MatIndex"].ToString());
                            Console.WriteLine(dtMatANDRect.Rows[i]["X"]);
                            if (FileNameAndMat.ContainsKey(Mindex))
                            {
                                Mat resMat;
                                FileNameAndMat.TryGetValue(Mindex, out resMat);
                                PicMatrois.Add(resMat);
                            }
                        }
                    }
                    //如果没，调用Sobel法
                    else
                    {
                        //调用Sobel法
                        this.SobelMethod();
                        if (this.srcImg == null) return;
                        if (this.srcImg.Empty()) return;

                        //找轮廓
                        Point[][] contours_sobel = null;
                        HierarchyIndex[] hierarchyIndex = null;

                        Cv2.FindContours(threshold_Erode, out contours_sobel, out hierarchyIndex,
                                         RetrievalModes.External, ContourApproximationModes.ApproxSimple);
                        // Sobel法筛选。对轮廓求最小外接矩形，然后验证，不满足条件的淘汰。
                        this.panSegment_Sobel.Controls.Clear();
                        int minWidth_sobel = int.Parse(this.txtMInWidth_sobel.Text);
                        int minHeight_sobel = int.Parse(this.txtMInHeight_sobel.Text);
                        int maxWidth_sobel = int.Parse(this.txtMaxWidth_sobel.Text);
                        int maxHeight_sobel = int.Parse(this.txtMaxHeight_sobel.Text);
                        float WhScale_sobel = float.Parse(this.txtWHScale_sobel.Text);

                        //List<Mat> SobelMat = new List<Mat>();

                        for (int i = 0; i < contours_sobel.Length; i++)
                        {
                            Rect rect = Cv2.BoundingRect(contours_sobel[i]);

                            if (rect.Width >= minWidth_sobel &&
                                rect.Width <= maxWidth_sobel &&
                                rect.Height >= minHeight_sobel &&
                                rect.Height <= maxHeight_sobel &&
                                rect.Width / rect.Height >= 0.8 &&
                                rect.Width / rect.Height <= WhScale_sobel)
                            {
                                Mat matROI = this.srcImg.SubMat(rect);
                                PlateCar plateCar = Plate_Car_SVM.TestCar(matROI);
                                if (PlateCar.车牌 == plateCar)
                                {
                                    MatIndex++;
                                    FileNameAndMat.Add(MatIndex, matROI);
                                    dtMatANDRect.Rows.Add(MatIndex, rect.X, rect.Y);
                                }
                            }
                        }
                        if (MatIndex != 0)
                        {
                            DataView dv = dtMatANDRect.DefaultView;
                            dv.Sort = "X ASC";
                            //dtMatANDRect.Clear();
                            dtMatANDRect = dv.ToTable();
                            for (int i = 0; i < dtMatANDRect.Rows.Count; i++)
                            {
                                int Mindex = int.Parse(dtMatANDRect.Rows[i]["MatIndex"].ToString());
                                if (FileNameAndMat.ContainsKey(Mindex))
                                {
                                    Mat resMat;
                                    FileNameAndMat.TryGetValue(Mindex, out resMat);
                                    PicMatrois.Add(resMat);
                                }
                            }
                        }
                    }
                    // 图片名称 和 得到的矩形存在Map中 
                    FileNameAndResult.Add(fileNames[index], PicMatrois);
                }

                //当一张图片有多张车牌时用于判断
                String FileName = null;
                foreach (KeyValuePair<String, List<Mat>> fvr in FileNameAndResult)
                {
                    string fileName = fvr.Key;
                    List<Mat> listChar = fvr.Value;

                    string shortFileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);

                    foreach (Mat value in listChar)
                    {
                        String res = this.CharsSplit(value);
                        //Console.WriteLine(this.CharsSplit(value));
                        /////////////////////////////////////////////////////  效率  shortFileName 存的值
                        if (res != null && res != "" && res.Length >4)
                        {
                            if (shortFileName == FileName)
                            {
                                file.Write("\r\n" + res);
                            }
                            else
                            {
                                FsIndex++;
                                if (FsIndex == 1)
                                {
                                    file.Write(shortFileName + "\r\n" + res);
                                }
                                else
                                {
                                    file.Write("\r\n" + shortFileName + "\r\n" + res);
                                }
                              
                            }
                            Console.WriteLine("=========================" + res);
                            FileName = shortFileName;
                        }            
                    }

                }
                file.Close();
                PicMatrois.Clear();
            }
        }

        //------------------------------------------------------------------------------------------------------------------------
        //在TreeView中创建文件列表
        private void ListImageFilesInTreeView(string path, TreeView tvFiles)
        {
            tvFiles.Nodes.Clear();
            string[] subDirecotries = Directory.GetDirectories(path);
            List<string> fileNameList = new List<string>();
            DirectoryInfo di = new DirectoryInfo(path);
            if (subDirecotries.Length == 0)
            {

                FileInfo[] FileList = di.GetFiles();
                ArrayList FAL = new ArrayList();
                //筛选图片
                foreach (FileInfo Files in FileList)
                {
                    String FilesName = (Files.Name).ToUpper();
                    if (FilesName.EndsWith(".JPG") || FilesName.EndsWith(".PNG") || FilesName.EndsWith(".BMP"))
                    {
                        FAL.Add(Files);
                    }
                }
                //清空数组
                Array.Clear(FileList, 0, FileList.Length);
                //重新赋值
                FileList = (FileInfo[])(FAL.ToArray(typeof(FileInfo)));
                //根据文件名排序
                Array.Sort(FileList, new FileNameSort());
                //把文件名存进数组
                for (int i = 0; i < FileList.Length; i++)
                {
                    fileNameList.Add(FileList[i].FullName);
                }

                for (int index = 0; index < fileNameList.Count; index++)
                {
                    string fileName = fileNameList[index];
                    string shortFileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);
                    TreeNode tvNode = tvFiles.Nodes.Add(shortFileName);
                    tvNode.Tag = fileName;
                }
            }
            else
            {
                for (int index = 0; index < subDirecotries.Length; index++)
                {
                    string subDirectory = subDirecotries[index];
                    string shortDirectory = subDirectory.Substring(subDirectory.LastIndexOf(@"\") + 1);

                    TreeNode tvNode_SubDirectry = tvFiles.Nodes.Add(shortDirectory);
                    tvNode_SubDirectry.Tag = subDirectory;

                    string[] pngFileNames = Directory.GetFiles(path, "*.png");
                    string[] bmpFileNames = Directory.GetFiles(path, "*.bmp");
                    string[] imageFileNames = Directory.GetFiles(subDirectory, "*.jpg");


                    fileNameList.AddRange(pngFileNames);
                    fileNameList.AddRange(imageFileNames);
                    fileNameList.AddRange(bmpFileNames);


                    for (int indexTemp = 0; indexTemp < fileNameList.Count; indexTemp++)
                    {
                        string fileName = imageFileNames[indexTemp];
                        string shortFileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);

                        TreeNode tvNodeImage = tvNode_SubDirectry.Nodes.Add(shortFileName);
                        tvNodeImage.Tag = fileName;
                    }
                }
            }
        }

        /// <summary>
        /// 加载读取文件 显示 一次性
        /// </summary>
        /// <param name="pathFile"></param>
        private void OpenFlie(string pathFile)
        {

            this.Path_TxT.Text = "";
            this.ListIMG.Refresh();

            this.Path_TxT.Text = pathFile;
            this.ListImageFilesInTreeView(pathFile, this.ListIMG);

        }

        //打开文件夹，读取文件夹路径
        private void OpenFile_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = @"C:\Users\Myself\Desktop\比赛照片";

            this.Path_TxT.Text = "";
            this.ListIMG.Refresh();
            DialogResult dlgResult = folderDlg.ShowDialog();

            if (dlgResult != DialogResult.OK) return;

            string selectedPath = folderDlg.SelectedPath;
            this.Path_TxT.Text = selectedPath;

            this.ListImageFilesInTreeView(folderDlg.SelectedPath, this.ListIMG);

        }

        private void ListIMG_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string fileName = (string)e.Node.Tag;

            this.ImageHanlder(fileName);
            tsColorChangeText_TextChanged(sender, e);
        }

        private void ImageHanlder(string fileName)
        {

            // 读取原图
            this.srcImg = Cv2.ImRead(fileName);

            // 归一化
            if (srcImg.Cols > 2000)
            {
                Cv2.Resize(srcImg, srcImg, new OpenCvSharp.Size(srcImg.Cols * 0.3, srcImg.Rows * 0.3));
            }

            this.picSrc.Image = this.srcImg.ToBitmap();

            // 调用颜色法
            this.ColorMethod();

            //调用sobel法
            this.SobelMethod();
        }

        /// <summary>
        ///  颜色法
        /// </summary>
        /// <param name="fileName"> </param>
        private void ColorMethod()
        {
            //模糊
            int blurSize = int.Parse(this.blurSize.Text);
            // 边缘
            int cannyThreshold1 = int.Parse(this.canny1.Text);
            int cannyThreshold2 = int.Parse(this.canny2.Text);

            this.HSVEvenimg = my_Method.ColorMethod(this.srcImg, blurSize, cannyThreshold1, cannyThreshold2, this.HSVEvenimg);

            this.picCtv.Image = my_Method.Grayimg.ToBitmap();
            this.picBlur.Image = my_Method.blurimg.ToBitmap();
            this.picCanny.Image = my_Method.Cannyimg.ToBitmap();
            this.picTs.Image = my_Method.thimg.ToBitmap();
            this.picHSV.Image = my_Method.hsvimg.ToBitmap();
            this.picH.Image = my_Method.mats_hsv[0].ToBitmap();
            this.picS.Image = my_Method.mats_hsv[1].ToBitmap();
            this.picV.Image = my_Method.mat_v.ToBitmap();
            // V 均衡化 
            this.picVEven.Image = my_Method.mats_hsv[2].ToBitmap();
            this.picHSVEven.Image = this.HSVEvenimg.ToBitmap();
        }


        /// <summary>
        ///  sobel 法
        /// </summary>
        /// <param name="fileName"> </param>
        private void SobelMethod()
        {
            if (this.srcImg == null) return;
            if (this.srcImg.Empty()) return;

            Mat blur = null;
            Mat gary = null;

            int blurSize = int.Parse(this.blurSize.Text);
            blur = this.srcImg.GaussianBlur(new OpenCvSharp.Size(blurSize, blurSize), 0);
            gary = blur.CvtColor(ColorConversionCodes.BGR2GRAY);

            // sobel 运算
            MatType ddepth = MatType.CV_16S;

            int sobel_Scale = 1;
            int sobel_Delta = 0;
            int sobel_X_Weight = 1;
            int sobel_Y_Weight = 0;
            int morph_Size_Width = 17;
            int morph_Size_Height = 3;

            Mat grad_x = gary.Sobel(ddepth, 1, 0, 3, sobel_Scale, sobel_Delta, BorderTypes.Default);

            Mat abs_grad_x = grad_x.ConvertScaleAbs();

            Mat grad_y = gary.Sobel(ddepth, 0, 1, 3, sobel_Scale, sobel_Delta, BorderTypes.Default);

            Mat abs_grad_y = grad_y.ConvertScaleAbs();

            Mat grad = new Mat();
            Cv2.AddWeighted(abs_grad_x, sobel_X_Weight, abs_grad_y, sobel_Y_Weight, 0, grad);

            this.picGrade.Image = grad.ToBitmap();

            //二值化
            Mat threshold = gary.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);
            this.picTh_sobel.Image = threshold.ToBitmap();

            //形态学操作
            Mat element = Cv2.GetStructuringElement(MorphShapes.Rect,
                                                   new OpenCvSharp.Size(morph_Size_Width, morph_Size_Height));
            Mat threshold_Close = threshold.MorphologyEx(MorphTypes.Close, element);
            this.picmorphology_sobel.Image = threshold_Close.ToBitmap();

            //腐蚀
            Mat element_Erode = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(3, 3));
            threshold_Erode = threshold_Close.Erode(element_Erode);
            this.picCorrode.Image = threshold_Erode.ToBitmap();
            //释放内存  --- 不够及时 
            GC.Collect();

        }


        // 判断车牌颜色 寻找车牌位置
        private void tsColorChangeText_TextChanged(object sender, EventArgs e)
        {

            // 膨胀的 element
            int ksizex = int.Parse(this.txDaliteX.Text);
            int ksizey = int.Parse(this.txDaliteY.Text);
            Mat element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(ksizex, ksizey));
            // 定义点的二维数组
            OpenCvSharp.Point[][] contours = null;
            HierarchyIndex[] hierarchies = null;

            contours = my_Method.ColorRange(element, contours, hierarchies, this.srcImg, this.HSVEvenimg, 3);
            this.picSelectColor.Image = my_Method.colorSelect.ToBitmap();
            this.picColorDalite.Image = my_Method.matDilate.ToBitmap();
            this.picFindC.Image = my_Method.matWithFlag.ToBitmap();

            // 清空
            this.listRect.Items.Clear();
            this.rectList.Clear();

            for (int i = 0; i < contours.Length; i++)
            {
                // 轮廓的最小矩形
                Rect rect = Cv2.BoundingRect(contours[i]);
                //报错点
                //rectResult.Add(rect);
                this.rectList.Add(rect); // 添加到集合
                this.listRect.Items.Add(string.Format("X:{0},Y:{1},W:{2},H:{3}", rect.X, rect.Y, rect.Width, rect.Height));
            }
        }

        //选择的矩形轮廓点的位置
        private void listRect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //得到矩形点的信息
            string rectinfo = this.listRect.Text;
            Rect rect = new Rect();
            string[] values = rectinfo.Split(',');
            rect.X = int.Parse(values[0].Split(':')[1]);
            rect.Y = int.Parse(values[1].Split(':')[1]);
            rect.Width = int.Parse(values[2].Split(':')[1]);
            rect.Height = int.Parse(values[3].Split(':')[1]);
            // 把选择的区域显示出来
            Mat matWithRectSelected = this.srcImg.Clone();
            matWithRectSelected.Rectangle(rect, Scalar.Red, 3);
            this.picFindC.Image = matWithRectSelected.ToBitmap();
        }

        /// <summary>
        ///  颜色法 筛选 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbtnlFilter_Click(object sender, EventArgs e)
        {

            if (this.srcImg == null) return;
            if (this.srcImg.Empty()) return;
            rectList.Clear();
            PicMatrois.Clear();
            tsColorChangeText_TextChanged(sender, e);
            int minWidth = int.Parse(this.txtMinWidth.Text);
            int minHeight = int.Parse(this.txtMinHeight.Text);
            int maxWidth = int.Parse(this.txtMaxWidth.Text);
            int maxHeight = int.Parse(this.txtMaxHeight.Text);
            float WhScale = float.Parse(this.txtWHScale.Text);

            this.panSegmentList.Controls.Clear();
            this.panChars.Controls.Clear();

            // rects 集合
            foreach (var item in this.rectList)
            {

                if (
                    item.Width >= minWidth &&
                    item.Width <= maxWidth &&
                    item.Height >= minHeight &&
                    item.Height <= maxHeight &&
                    item.Width / item.Height > 0.8 &&
                    item.Width / item.Height < WhScale
                    )
                {
                    //SubMat  对矩形区域进行截取
                    Mat matRoi = this.srcImg.SubMat(item);

                    PlateCar plateCar = Plate_Car_SVM.TestCar(matRoi);
                    if (PlateCar.车牌 == plateCar)
                    {
                        PicMatrois.Add(matRoi);
                    }
                    this.GenerateROI(matRoi, this.panSegmentList);
                }
            }
        }

        /// <summary>
        /// sobel 筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbtnClick_sobel_Click(object sender, EventArgs e)
        {
            if (this.srcImg == null) return;
            if (this.srcImg.Empty()) return;
            rectList.Clear();
            PicMatrois.Clear();
            //找轮廓
            OpenCvSharp.Point[][] contours = null;
            HierarchyIndex[] hierarchyIndex = null;

            Cv2.FindContours(threshold_Erode, out contours, out hierarchyIndex,
                             RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            // 筛选。对轮廓求最小外接矩形，然后验证，不满足条件的淘汰。
            int minWidth = int.Parse(this.txtMInWidth_sobel.Text.Trim());
            int minHeight = int.Parse(this.txtMInHeight_sobel.Text);
            int maxWidth = int.Parse(this.txtMaxWidth_sobel.Text);
            int maxHeight = int.Parse(this.txtMaxHeight_sobel.Text);
            float WhScale = float.Parse(this.txtWHScale.Text);
            this.panSegment_Sobel.Controls.Clear();
            this.panChars_sobel.Controls.Clear();

            for (int i = 0; i < contours.Length; i++)
            {
                Rect rect = Cv2.BoundingRect(contours[i]);

                if (rect.Width >= minWidth &&
                    rect.Width <= maxWidth &&
                    rect.Height >= minHeight &&
                    rect.Height <= maxHeight &&
                    rect.Width / rect.Height >= 0.8 &&
                    rect.Width / rect.Height <= WhScale)
                {
                    Mat matROI = this.srcImg.SubMat(rect);
                    this.listRect.Controls.Clear();
                    this.rectList.Add(rect);
                    PicMatrois.Add(matROI);
                    this.GenerateROI(matROI, this.panSegment_Sobel);
                }
            }

        }


        //感兴区域
        private void GenerateROI(Mat matRoi, Panel panParent, bool boundEvent = true)
        {
            // 创建 picBox 设置 picBox属性
            PictureBox picBox = new PictureBox();
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BorderStyle = BorderStyle.FixedSingle;
            picBox.Dock = DockStyle.Left;
            picBox.Width = 150;
            picBox.Image = matRoi.ToBitmap();
            picBox.Tag = matRoi;

            if (boundEvent)
            {
                if (panParent == this.panSegment_Sobel)
                {
                    picBox.Click += this.PicBox_Click_Sobel;
                }
                else
                {
                    picBox.Click += this.PicBox_Click;
                }
            }

            panParent.Controls.Add(picBox);


        }

        /// <summary>
        /// picbox 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicBox_Click_Sobel(object sender, EventArgs e)
        {
            Mat matroi = (Mat)((PictureBox)sender).Tag;
            this.CharsSplit(matroi, this.panChars_sobel);
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            Mat matroi = (Mat)((PictureBox)sender).Tag;
            this.CharsSplit(matroi, this.panChars);
        }

        /// <summary>
        ///  字符分割  -- 保存 到 txt
        /// </summary>
        /// <param name="matPlate"></param>
        private String CharsSplit(Mat matPlate)
        {
            List<Mat> ListMat = my_Method.carCharSplit(matPlate);
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
            if (res != null&&res != ""&&res.Length>4)
            {
                res = this.SubChar(res);
            }
            return res;
        }

        public String SubChar(string res)
        {
            string Res = res;
            if (Res.Length > 0)
            {
                ////判断第一个是不是汉字
                //if ((int)Res[0] < 127)
                //{
                //    Res = Res.Remove(0, 1);
                //}
          
                //转换成拼音
                int indexof = -1;
                Regex reg = new Regex("[\u4e00-\u9fa5]+");
                Match m= reg.Match(Res);
                indexof = m.Index;
                
                if (indexof!=-1&&m.Success)
                {

                    Res = Res.Substring(indexof);
                    if ((int)Res[0] > 128 && (int)Res[1] > 128)
                    {
                        if(Res.Length>2)
                        Res = Res.Remove(0, 1);
                    }
                    //判断车牌颜色
                    if (my_Method.bluenum > my_Method.greennum)
                    {
                        if (Res.Length>6)
                        {
                            Res = Res.Substring(0, 7);
                        }
                    }
                    if (my_Method.bluenum < my_Method.greennum)
                    {
                        if(Res.Length>7)
                        Res = Res.Substring(0, 8);
                    }
                    m = reg.Match(Res);
                    indexof = m.Index;
                    Char c= Res[indexof];
                    string strc = c.ToString();
                    if (strc != null)
                    {
                        if (hashRes.ContainsKey(strc))
                            Res = Res.Replace(strc, hashRes[strc].ToString());
                    }         
                }


                /*
                foreach (Match Chinese in reg.Matches(Res))
                {
                    indexof = Res.IndexOf(Chinese.Value);
                    Res = Res.Remove(0, indexof);
                    Res = Res.Remove(indexof, 1);
                    int has = hashRes.Count;
                    if (hashRes.ContainsKey(Chinese.Value))
                    {
                        Res = Res.Insert(indexof, hashRes[Chinese.Value].ToString());
                    }
                }*/
            }
            return Res;
        }

        /// <summary>
        /// 显示lable 点击切割
        /// </summary>
        /// <param name="matPlate"></param>
        /// <param name="panel"></param>
        private void CharsSplit(Mat matPlate, Panel panel)
        {

            panel.Controls.Clear();//清空
            Console.WriteLine(panel.Name);
            List<Mat> ListMat = my_Method.carCharSplit(matPlate);
            //添加灰度图
            this.GenerateROI(my_Method.matGray_car, panel, false);
            //添加二值图
            this.GenerateROI(my_Method.matshoid, panel, false);
            //膨胀图
            this.GenerateROI(my_Method.matDilate_car, panel, false);
            //
            this.GenerateROI(my_Method.matWithFalg_car, panel, false);
            //矩形
            this.GenerateROI(my_Method.matWithRects, panel, false);
            // 分割出来的每个字符图
            foreach (var item in ListMat)
            {
                this.GenerateROI(item, panel, false);
            }

            this.GenerateROI(my_Method.matWithRects, panel, false);

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

            //for (int i = 0; i < res.Length; i++)
            //{
            if (res != null && res != "" && res.Length > 4)
            {
                res = this.SubChar(res);
            }
            // 显示识别结果
            this.lblCarText.Text = res;
            //}
        }
        // 打开训练
        private void OpenSVMForm_Click(object sender, EventArgs e)
        {
            Form_SVM svmfrom = new Form_SVM();
            svmfrom.ShowDialog();
        }

        private void OpenXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "XML文件|*.xml";

            DialogResult dlgResult = openDlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                Plate_SVM.Load(openDlg.FileName);

            }
        }

        /// <summary>
        /// 摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenVideoForm_Click(object sender, EventArgs e)
        {
            FormVideo fromVideo = new FormVideo();
            fromVideo.ShowDialog();
        }

        private void 点击识别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbtnlFilter_Click(sender, e);
            if (PicMatrois.Count == 0)
            {
                tbtnClick_sobel_Click(sender, e);
            }
            if (PicMatrois == null && PicMatrois.Count == 0) return;
            List<Mat> MatResult = new List<Mat>();
            MatResult.Add(this.srcImg.Clone());
            int index = 0;
            foreach (Mat mat in PicMatrois)
            {
                String res = this.CharsSplit(mat);
               
                    for (int i = 0; i < rectList.Count; i++)
                    {
                        if (rectList[i].Width == mat.Width && res!="" &&res.Length > 4)
                        {
                            MatResult[index].Rectangle(rectList[i], Scalar.Red, 2);
                            Cv2.PutText(MatResult[index], res, new OpenCvSharp.Point(rectList[i].X, rectList[i].Y), HersheyFonts.HersheyTriplex, 2, Scalar.Red, 4);
                            MatResult.Add(MatResult[index]);
                            index++;
                        }
                    }
                
            }
            MatResult.Reverse();
            this.picSrc.Image = MatResult[0].ToBitmap();
        }
    }
}

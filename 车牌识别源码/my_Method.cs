using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Collections;

namespace 车牌识别
{

    public class my_Method
    {

        public static Scalar startColor = new Scalar();
        public static Scalar endColor = new Scalar();

        public static Mat Grayimg = new Mat();
        public static Mat blurimg = new Mat();
        public static Mat Cannyimg = new Mat();
        public static Mat thimg = new Mat();
        public static Mat hsvimg = new Mat();
        public static Mat[] mats_hsv = null;
        public static Mat mat_v = null;

        //颜色选择
        public static Mat colorSelect = new Mat();

        public static Mat matDilate = new Mat();

        //框出车牌后的图
        public static Mat matWithFlag = new Mat();

        //字符分割
        public static Mat matGray_car = new Mat();
        public static Mat matshoid = new Mat();
        public static Mat matDilate_car = new Mat();
        public static Mat matWithFalg_car = new Mat();
        public static Mat matWithRects = new Mat();

        //用颜色遍历判断颜色

        public static int bluenum = 0;
        public static int yellownum = 0;
        public static int whitenum = 0;
        public static int blacknum = 0;
        public static int othernum = 0;
        public static int greennum = 0;



        /// <summary>
        /// 颜色法
        /// </summary>
        /// <param name="srcImg"></param>
        /// <param name="blurSize"></param>
        /// <param name="cannyThreshold1"></param>
        /// <param name="cannyThreshold2"></param>
        /// <param name="HSVEvenimg"></param>
        /// <returns></returns>
        public static Mat ColorMethod(Mat srcImg, int blurSize, int cannyThreshold1, int cannyThreshold2, Mat HSVEvenimg)
        {

            if (srcImg == null) return null;
            if (srcImg.Empty()) return null;

            //灰度    
            Grayimg = srcImg.CvtColor(ColorConversionCodes.BGR2GRAY);
            //模糊
            blurimg = Grayimg.GaussianBlur(new OpenCvSharp.Size(blurSize, blurSize), 0);
            // 边缘
            Cannyimg = blurimg.Canny(cannyThreshold1, cannyThreshold2);
            //二值化
            thimg = blurimg.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);
            //HSV 
            hsvimg = srcImg.CvtColor(ColorConversionCodes.BGR2HSV);

            //对t通道进行拆分 Split
            mats_hsv = hsvimg.Split();
            mat_v = mats_hsv[2];
            //V  均衡化
            mats_hsv[2] = mats_hsv[2].EqualizeHist();
            //对拆分的通道数据合并  Merge
            Cv2.Merge(mats_hsv, HSVEvenimg);
            //释放内存  --- 不够及时 
            GC.Collect();

            return HSVEvenimg;
        }



        /// <summary>
        /// 颜色区间  颜色选择
        /// </summary>
        /// <param name="text"></param>
        public static Point[][] ColorRange(Mat element, OpenCvSharp.Point[][] contours, HierarchyIndex[] hierarchies, Mat srcImg, Mat HSVEvenimg, int ContoursSize)
        {


            if (srcImg == null) return null;
            if (srcImg.Empty()) return null;
            if (HSVEvenimg.Empty()) return null;

            //蓝色
            startColor = new Scalar(100, 95, 95);
            endColor = new Scalar(140, 255, 255);
            Mat blue = HSVEvenimg.InRange(startColor, endColor);

            //绿色
            startColor = new Scalar(60, 43, 46);
            endColor = new Scalar(85, 255, 255);
            Mat yellow = HSVEvenimg.InRange(startColor, endColor);

            colorSelect = blue + yellow;

            // 膨胀
            matDilate = colorSelect.MorphologyEx(MorphTypes.Dilate, element);
            //查找轮廓
            matDilate.FindContours(out contours, out hierarchies, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            // 复制原图一份原图
            matWithFlag = srcImg.Clone();
            //画出查找的轮廓
            matWithFlag.DrawContours(contours, -1, Scalar.Yellow, ContoursSize);


            return contours;
        }


        public static List<Mat> carCharSplit(Mat matPlate)
        {

            Mat hsvmat = matPlate.CvtColor(ColorConversionCodes.BGR2HSV);

            Mat[] hsv = hsvmat.Split();
            Mat h = hsv[0];
            Mat s = hsv[1];
            Mat v = hsv[2];

            for (int i = 0; i < hsvmat.Rows; i++)
            {
                for (int j = 0; j < hsvmat.Cols; j++)
                {

                    byte hvalue = h.At<byte>(i, j);  //////////////////h通道/-/////////////////////
                                                     // Console.WriteLine(hvalue + ":h");
                    byte svalue = s.At<byte>(i, j);  //////////////////s通道/-/////////////////////

                    byte vvalue = v.At<byte>(i, j);  //////////////////v通道/-/////////////////////
                                                     // printf("x=%d,y=%d,HSV: H=%d,S=%d,V=%d\n",i,j,hvalue,svalue,vvalue);
                    if ((hvalue > 80 && hvalue < 130) && (svalue > 43 && svalue < 220) && (vvalue > 46 && vvalue < 255))//hsv图像在蓝色区域里
                    {
                        //蓝色+1
                        bluenum++;
                    }
                    else if ((hvalue > 11 && hvalue < 34) && (svalue > 43 && svalue < 255) && (vvalue > 46 && vvalue < 255))//hsv在黄色区域里
                    {
                        //黄色+1
                        yellownum++;
                    }
                    else if ((hvalue > 0 && hvalue < 180) && (svalue > 0 && svalue < 255) && (vvalue > 0 && vvalue < 46))//hsv在黑色区域里
                    {
                        blacknum++;
                        //黑色+1
                    }
                    else if ((hvalue > 0 && hvalue < 180) && (svalue > 0 && svalue < 30) && (vvalue > 46 && vvalue < 220))//hsv在白色区域里
                    {
                        //白色+1
                        whitenum++;
                    }
                    else if ((hvalue > 60 && hvalue < 90) && (svalue > 43 && svalue < 255) && (vvalue > 46 && vvalue < 255))//hsv在绿色区域里
                    {
                        //绿色+1
                        greennum++;
                    }
                    else
                    {
                        //其他颜色
                        othernum++;
                    }


                }
            }


            Console.WriteLine(greennum + ":绿色");
            Console.WriteLine(hsvmat.Rows * hsvmat.Cols + ":总");

            Console.WriteLine(yellownum + ":黄色");
            Console.WriteLine(bluenum + ":蓝色");

            // 灰度
            matGray_car = matPlate.CvtColor(ColorConversionCodes.BGR2GRAY);
            //二值化
            Mat matshoid_th = matGray_car.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);
            matshoid = new Mat();

            //   判断 取反 否
            if (bluenum < yellownum && yellownum > greennum)
            {
                // 取反
                matshoid = 255 - matshoid_th;
            }
            else if (bluenum > yellownum && bluenum > greennum)
            {
                matshoid = matGray_car.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);

            }
            else if (greennum > yellownum && greennum > bluenum)
            {
                // 取反
                matshoid = 255 - matshoid_th;
            }
            else
            {
                matshoid = matGray_car.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);

            }


            // 车牌高度大于20的去除边框和柳钉
            Mat clearBorder = new Mat();
            Mat clearMoDing = new Mat();

            if (matshoid.Height > 22)
            {
                // 去除边框
                clearBorder = ClearBorder(matshoid);

                // 去除柳钉
                clearMoDing = ClearMaoding(matshoid, 4);


            }
            else if (matshoid.Height <= 22 && matshoid.Height > 20)
            {
                // 去除边框
                clearBorder = ClearBorder(matshoid);

                // 去除柳钉
                clearMoDing = ClearMaoding(matshoid, 3);
            }
            else
            {
                clearMoDing = matshoid;
            }

            // 膨胀
            Mat element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(1, 1));
            matDilate_car = clearMoDing.MorphologyEx(MorphTypes.Dilate, element);


            //点的二维数组
            OpenCvSharp.Point[][] contours = null;
            HierarchyIndex[] hierarchyIndexs = null;
            matDilate_car.FindContours(out contours, out hierarchyIndexs, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            matWithFalg_car = matPlate.Clone();
            matWithFalg_car.DrawContours(contours, -1, Scalar.Red);

            matWithRects = matPlate.Clone();

            // 创建集合 存储分割后的图片 -- 用于 识别
            List<Mat> ListMat = new List<Mat>();
            // 切割的矩形 图
            List<Rect> ListRect = new List<Rect>();
            for (int index = 0; index < contours.Length; index++)
            {
                Rect rect = Cv2.BoundingRect(contours[index]);

                ListRect.Add(rect);

                matWithRects.Rectangle(rect, Scalar.Red);

            }

            //  对分割的字符排序
            SortRectsByLeft_ASC(ListRect);

            foreach (var rect in ListRect)
            {
                Mat matchar = matPlate.SubMat(rect); // 切割矩形
                Console.WriteLine("========= 宽:" + matchar.Width + " 高:" + matchar.Height);
                // 判断 太小的不要
                if (matchar.Width >= 3 && matchar.Height >= 10)
                {

                    PlateCategory plateCate = Plate_SVM.Test(matchar);

                    ListMat.Add(matchar);

                    Console.WriteLine(ListMat.Count + "  个");


                }

                Console.WriteLine("========= 宽:" + rect.Width + " 高:" + rect.Height + " X:" + rect.X + " Y:" + rect.Y);
            }

            return ListMat;


        }


        // 去柳钉
        public static Mat ClearMaoding(Mat threshold, int num)
        {
            List<float> jumps = new List<float>();

            Mat jump = new Mat(threshold.Rows, 1, MatType.CV_32F);

            for (int rowIndex = num; rowIndex < threshold.Rows - num; rowIndex++)
            {
                int jumpCount = 0;
                for (int colIndex = num; colIndex < threshold.Cols - num; colIndex++)
                {
                    if (threshold.At<byte>(rowIndex, colIndex) != threshold.At<byte>(rowIndex, colIndex + 1)) jumpCount++;
                }
                jump.Set<float>(rowIndex, 0, (float)jumpCount);
            }

            int x = 7;
            Mat result = threshold.Clone();
            for (int rowIndex = 0; rowIndex < threshold.Rows; rowIndex++)
            {
                if (jump.At<float>(rowIndex) <= x)
                {
                    for (int colIndex = 0; colIndex < threshold.Cols; colIndex++)
                    {
                        result.Set<byte>(rowIndex, colIndex, 0);
                    }
                }
            }

            return result;
        }
        //去边框
        public static Mat ClearBorder(Mat threshold)
        {
            int rows = threshold.Rows;
            int cols = threshold.Cols;

            int noJumpCountThresh = (int)(0.15f * cols);

            Mat border = new Mat(rows, 1, MatType.CV_8UC1);

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                int noJumpCount = 0;
                byte isBorder = 0;

                for (int colIndex = 1; colIndex < cols - 7; colIndex++)
                {
                    if (threshold.At<byte>(rowIndex, colIndex) == threshold.At<byte>(rowIndex, colIndex + 1)) noJumpCount++;

                    if (noJumpCount > noJumpCountThresh)
                    {
                        noJumpCount = 0;
                        isBorder = 1;
                        break;
                    }
                }
                border.Set<byte>(rowIndex, 0, isBorder);
            }

            int minTop = (int)(0.1f * rows);
            int maxTop = (int)(0.9f * rows);

            Mat result = threshold.Clone();

            for (int rowIndex = 0; rowIndex < minTop; rowIndex++)
            {
                if (border.At<byte>(rowIndex, 0) == 1)
                {
                    for (int colIndex = 0; colIndex < cols; colIndex++)
                    {
                        result.Set<byte>(rowIndex, colIndex, 0);
                    }
                }
            }

            for (int rowIndex = rows - 1; rowIndex > maxTop; rowIndex--)
            {
                if (border.At<byte>(rowIndex, 0) == 1)
                {
                    for (int colIndex = 0; colIndex < cols; colIndex++)
                    {
                        result.Set<byte>(rowIndex, colIndex, 0);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 比较排序
        /// </summary>
        /// <param name="rects"></param>
        public static void SortRectsByLeft_ASC(List<Rect> rects)
        {
            rects.Sort(new RectLeftComparer());
        }


        private class RectLeftComparer : IComparer<Rect>
        {
            public int Compare(Rect x, Rect y)
            {
                return x.X.CompareTo(y.X);
            }
        }

    }
}

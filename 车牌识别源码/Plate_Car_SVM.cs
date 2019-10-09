using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.ML;


namespace 车牌识别
{
    /// <summary>
    /// 训练车牌
    /// </summary>
    class Plate_Car_SVM
    {

        public static bool IsReady = false;
        private static OpenCvSharp.Size WIN_SIZE_CAR = new Size(96, 32);
        private static OpenCvSharp.Size CELL_SIZE = new Size(8, 8);
        private static OpenCvSharp.Size BLOCK_SIZE = new Size(16, 16);
        private static OpenCvSharp.Size BLOCK_STRIDE = new Size(8, 8);

        private static SVM svm = null;

        static Plate_Car_SVM()
        {
            svm = SVM.Create();
            svm.Type = SVM.Types.CSvc;
            svm.KernelType = SVM.KernelTypes.Linear;
        }

        /// <summary>
        /// 车牌
        /// </summary>
        /// <param name="matPlate"></param>
        /// <returns></returns>
        public static float[] GetHogCar(Mat matPlate)
        {
            Mat matTemp = matPlate.Resize(WIN_SIZE_CAR);

            HOGDescriptor hogDescriptor = new HOGDescriptor(
                                                                    WIN_SIZE_CAR,
                                                                    BLOCK_SIZE,
                                                                    BLOCK_STRIDE,
                                                                    CELL_SIZE);
            float[] hogcar = hogDescriptor.Compute(
                matTemp,
                new OpenCvSharp.Size(1, 1),
                new OpenCvSharp.Size(0, 0));

            return hogcar;
        }

        // 车牌保存     PlateCategory plateCate , 
        public static void SaveCharSample(Mat charMat, string libPath, string shortFileNameNoExt)
        {
            string fileName = string.Format(@"{0}\Mychars\新建\{1}.jpg", libPath, shortFileNameNoExt);

            charMat = charMat.Resize(WIN_SIZE_CAR);

            charMat.SaveImage(fileName);
        }

        public static void Train(Mat sample, Mat label)
        {
            svm.Train(sample, SampleTypes.RowSample, label);
            svm.TermCriteria = new TermCriteria(CriteriaType.MaxIter, 10000, 1e-10);
            IsReady = true;
        }

        public static void Load(string fileName)
        {
            try
            {
                svm = SVM.Load(fileName);
                IsReady = true;
            }
            catch (Exception)
            {
                throw new Exception("字符识别库加载异常，请检查存放路径");
            }

        }

        public static void Save(string fileName)
        {
            svm.Save(fileName);
        }

        /// <summary>
        /// 车牌
        /// </summary>
        /// <param name="matPlate"></param>
        /// <returns></returns>
        public static PlateCar TestCar(Mat matPlate)
        {


            float[] hogcar = GetHogCar(matPlate);
            Mat matTest = new Mat(1, hogcar.Length, MatType.CV_32FC1);

            for (int i = 0; i < hogcar.Length; i++)
            {
                matTest.Set<float>(0, i, hogcar[i]);
            }

            PlateCar result = (PlateCar)((int)svm.Predict(matTest));
            return result;
        }

    }
}
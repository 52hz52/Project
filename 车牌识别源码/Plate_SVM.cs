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
    class Plate_SVM
    {

        private static OpenCvSharp.Size WIN_SIZE = new Size(16, 32);
        private static OpenCvSharp.Size CELL_SIZE = new Size(8, 8);
        private static OpenCvSharp.Size BLOCK_SIZE = new Size(16, 16);
        private static OpenCvSharp.Size BLOCK_STRIDE = new Size(8, 8);

        private static SVM svm = null;

        static Plate_SVM()
        {
            svm = SVM.Create();
            svm.Type = SVM.Types.CSvc;
            svm.KernelType = SVM.KernelTypes.Linear;
        }

        public static float[] GetHog(Mat matPlate)
        {
            Mat matTemp = matPlate.Resize(WIN_SIZE);

            HOGDescriptor hogDescriptor = new HOGDescriptor(
                                                                    WIN_SIZE,
                                                                    BLOCK_SIZE,
                                                                    BLOCK_STRIDE,
                                                                    CELL_SIZE);
            float[] hog = hogDescriptor.Compute(
                matTemp,
                new OpenCvSharp.Size(1, 1),
                new OpenCvSharp.Size(0, 0));

            return hog;
        }
        // 字符保存  
        public static void SaveCharSample(Mat charMat, PlateCategory plateCate , string libPath, string shortFileNameNoExt)
        {
                string fileName = string.Format(@"{0}\Mychars\{1}\{2}.jpg", libPath, plateCate , shortFileNameNoExt);

            charMat = charMat.Resize(WIN_SIZE);

            charMat.SaveImage(fileName);
        }

        public static void Train(Mat sample, Mat label)
        {
            svm.Train(sample, SampleTypes.RowSample, label);
        }

        public static void Load(string fileName)
        {
            svm = SVM.Load(fileName);
        }

        public static void Save(string fileName)
        {
            svm.Save(fileName);
        }



        public static PlateCategory Test(Mat matPlate)
        {
            
       
                float[] hog = GetHog(matPlate);
                Mat matTest = new Mat(1, hog.Length, MatType.CV_32FC1);

                for (int i = 0; i < hog.Length; i++)
                {
                    matTest.Set<float>(0, i, hog[i]);
                }

                PlateCategory result = (PlateCategory)((int)svm.Predict(matTest));           
                return result;
        }


        public static List<PlateCategory> TestList(List<Mat> matPlateList)
        {
            List<PlateCategory> resultList =  new List<PlateCategory>();
            PlateCategory  result = 0;
            foreach (var matPlate in matPlateList)
            {
                float[] hog = GetHog(matPlate);
                Mat matTest = new Mat(1, hog.Length, MatType.CV_32FC1);

                for (int i = 0; i < hog.Length; i++)
                {
                    matTest.Set<float>(0, i, hog[i]);
                }

                result = (PlateCategory)((int)svm.Predict(matTest));
                resultList.Add(result);
   
            }

            return resultList;
        }
    }
}

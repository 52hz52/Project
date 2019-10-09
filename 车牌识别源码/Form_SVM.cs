using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace 车牌识别
{
    public partial class Form_SVM : Form
    {
        public Form_SVM()
        {
            InitializeComponent();
        }

        // 打开训练图片路径
        private string samplePath = string.Empty;
        //测试文件路径
        private string testPath = string.Empty;

        //     private List<string> ImageList = new List<string>();

        private void ListImageFilesInTreeview(string path, TreeView tvFiles)
        {
            tvFiles.Nodes.Clear();

            string[] subDirecotries = Directory.GetDirectories(path);
            for (int index = 0; index < subDirecotries.Length; index++)
            {
                string subDirectory = subDirecotries[index];
                string shortDirectory = subDirectory.Substring(subDirectory.LastIndexOf(@"\") + 1);

                TreeNode tvNode_SubDirectry = tvFiles.Nodes.Add(shortDirectory);
                tvNode_SubDirectry.Tag = subDirectory;

                string[] imageFileNames = Directory.GetFiles(subDirectory, "*.jpg");
                for (int indexTemp = 0; indexTemp < imageFileNames.Length; indexTemp++)
                {
                    string fileName = imageFileNames[indexTemp];
                    string shortFileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);

                    TreeNode tvNodeImage = tvNode_SubDirectry.Nodes.Add(shortFileName);
                    tvNodeImage.Tag = fileName;
                }
            }

        }


        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilePath_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = @"C:\Users\Myself\Desktop\车牌识别训练资源库--a\chars";

            DialogResult dlgResult = folderDlg.ShowDialog();
            if (dlgResult != DialogResult.OK) return;

            this.samplePath = folderDlg.SelectedPath;

            this.tsShowFile.Text = this.samplePath;

            this.ListImageFilesInTreeview(this.samplePath, this.tvSrc);
            this.tabControl1.SelectedIndex = 0;

        }
        /// <summary>
        /// 打开测试数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestFile_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = @"C:\Users\Myself\Desktop\车牌识别训练资源库--a\chars";

            DialogResult dlgResult = folderDlg.ShowDialog();
            if (dlgResult != DialogResult.OK) return;

            this.testPath = folderDlg.SelectedPath;

            this.ListImageFilesInTreeview(this.testPath, this.tvTest);

            this.tabControl1.SelectedIndex = 1;
        }
        /// <summary>
        /// 开始训练
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.samplePath == "") return;

            List<PlateInfo> plateSamples = new List<PlateInfo>();

            string[] subDirectories = Directory.GetDirectories(this.samplePath);
            for (int index = 0; index < subDirectories.Length; index++)
            {
                string subDirectory = subDirectories[index];
                string shortDirectory = subDirectory.Substring(subDirectory.LastIndexOf(@"\") + 1);

                PlateCategory category = (PlateCategory)Enum.Parse(typeof(PlateCategory), shortDirectory);

                string[] fileNames = Directory.GetFiles(subDirectory, "*.jpg");

                for (int i = 0; i < fileNames.Length; i++)
                {
                    string fileName = fileNames[i];
                    this.txtinfo.AppendText(string.Format("{0}  类型：{1}\r\n", fileName, category));

                    Mat matPlate = Cv2.ImRead(fileName);

                    PlateInfo plateInfo = new PlateInfo();
                    plateInfo.PlateMat = matPlate;
                    plateInfo.Category = category;

                    plateSamples.Add(plateInfo);
                }
            }

            //将样本的元数据转化为SVM的样品数据和标签数据
            Mat trainData = new Mat();
            Mat trainLabel = new Mat(plateSamples.Count, 1, MatType.CV_32SC1);

            for (int index = 0; index < plateSamples.Count; index++)
            {
                PlateInfo plateInfo = plateSamples[index];
                float[] hog = Plate_SVM.GetHog(plateInfo.PlateMat);

                if (index == 0)
                {
                    trainData = Mat.Zeros(plateSamples.Count, hog.Length, MatType.CV_32FC1);
                }

                for (int colIndex = 0; colIndex < hog.Length; colIndex++)
                {
                    trainData.Set<float>(index, colIndex, hog[colIndex]);
                }

                trainLabel.Set<int>(index, 0, (int)plateInfo.Category);

                this.txtinfo.AppendText(hog.Length.ToString() + "\r\n");
            }

            Plate_SVM.Train(trainData, trainLabel);

            this.txtinfo.AppendText("训练已完成\r\n");

        }

        /// <summary>
        /// 保存训练数据XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveXML_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "XML文件|*.xml";

            DialogResult dlgResult = saveDlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                Plate_SVM.Save(saveDlg.FileName);
                this.txtinfo.AppendText("保存-训练数据XML成功 \r\n ");
            }

        }

        private void tvTest_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0) return;
            string fileName = e.Node.Tag as string;
            if (fileName == null) return;

            Mat matPreview = Cv2.ImRead(fileName);
            this.picImage.Image = matPreview.ToBitmap();

            PlateCategory category = Plate_SVM.Test(matPreview);
            this.txtinfo.AppendText(string.Format("\r\n预测结果：{0}\r\n", category));
        }

        private void tvSrc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0) return;
            string fileName = e.Node.Tag as string;
            if (fileName == null) return;

            Mat matPreview = Cv2.ImRead(fileName);
            this.picImage.Image = matPreview.ToBitmap();
        }

        //车牌训练
        private void Car_svm_Click(object sender, EventArgs e)
        {
            if (this.samplePath == "") return;

            List<PlateCarInfo> plateSamples = new List<PlateCarInfo>();

            string[] subDirectories = Directory.GetDirectories(this.samplePath);
            for (int index = 0; index < subDirectories.Length; index++)
            {
                string subDirectory = subDirectories[index];
                string shortDirectory = subDirectory.Substring(subDirectory.LastIndexOf(@"\") + 1);

                PlateCar categorycar = (PlateCar)Enum.Parse(typeof(PlateCar), shortDirectory);

                string[] fileNames = Directory.GetFiles(subDirectory, "*.jpg");

                for (int i = 0; i < fileNames.Length; i++)
                {
                    string fileName = fileNames[i];
                    this.txtinfo.AppendText(string.Format("{0}  类型：{1}\r\n", fileName, categorycar));

                    Mat matPlate = Cv2.ImRead(fileName);

                    PlateCarInfo plateCarInfo = new PlateCarInfo();
                    plateCarInfo.PlateMatCar = matPlate;
                    plateCarInfo.CategoryCar = categorycar;

                    plateSamples.Add(plateCarInfo);
                }
            }

            //将样本的元数据转化为SVM的样品数据和标签数据
            Mat trainData = new Mat();
            Mat trainLabel = new Mat(plateSamples.Count, 1, MatType.CV_32SC1);

            for (int index = 0; index < plateSamples.Count; index++)
            {
                PlateCarInfo plateCarInfo = plateSamples[index];
                float[] hog = Plate_Car_SVM.GetHogCar(plateCarInfo.PlateMatCar);

                if (index == 0)
                {
                    trainData = Mat.Zeros(plateSamples.Count, hog.Length, MatType.CV_32FC1);
                }

                for (int colIndex = 0; colIndex < hog.Length; colIndex++)
                {
                    trainData.Set<float>(index, colIndex, hog[colIndex]);
                }

                trainLabel.Set<int>(index, 0, (int)plateCarInfo.CategoryCar);

                this.txtinfo.AppendText(hog.Length.ToString() + "\r\n");
            }

            Plate_Car_SVM.Train(trainData, trainLabel);

            this.txtinfo.AppendText("训练已完成\r\n");
        }

        //保存车牌XML
        private void SavaCarSVM_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "XML文件|*.xml";

            DialogResult dlgResult = saveDlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                Plate_Car_SVM.Save(saveDlg.FileName);
                this.txtinfo.AppendText("保存-训练数据XML成功 \r\n ");
            }
        }
    }
}

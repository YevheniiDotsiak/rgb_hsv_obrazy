using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ApoEgz
{
    public partial class Main : Form
    {
        string colorModel = "RGB";
        public Main()
        {
            InitializeComponent();
        }
        //**************************************************************************************************************
        // funkcja ktora pozwala wczytywac obrazki
        public void OpenImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.PNG;*.JPG|*.BMP;*.PNG;*.JPG|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxMain.Image = new Bitmap(ofd.FileName);
                    buttonHSV.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Can not open this file...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //**************************************************************************************************************
        // funkca pozwala konwertowac jeden model koloru na drugi i odwrotnie.
        public void ColorConverting(string Type)
        {
            if (pictureBoxMain.Image == null)
            {
                MessageBox.Show("Open the image before...");
                if (Type == "RGB")
                {
                    buttonHSV.Enabled = true;
                }
                else
                {
                    buttonRGB.Enabled = true;
                }
                return;
            }
            string fileName; ;
            if (Type == "RGB")
            {
                fileName = "RGBimage";
            }
            else
            {
                fileName = "HSVimage";
            }
            Bitmap bmp;
            while (File.Exists(@"TempImages\\" + fileName + ".bmp")) { fileName += "1"; }
            pictureBoxMain.Image.Save(@"TempImages\\" + fileName + ".bmp");
            var imgOryginal = CvInvoke.Imread(@"TempImages\\" + fileName + ".bmp");
            Image<Hsv, byte> imgHSV = new Image<Hsv, byte>(pictureBoxMain.Image.Width, pictureBoxMain.Image.Height);
            Image<Bgr, byte> imgRGB = new Image<Bgr, byte>(pictureBoxMain.Image.Width, pictureBoxMain.Image.Height);
            Emgu.CV.CvEnum.ColorConversion convertType;
            if (Type == "RGB")
            {
                convertType = Emgu.CV.CvEnum.ColorConversion.Hsv2Bgr;
                CvInvoke.CvtColor(imgOryginal, imgRGB, convertType);
                CvInvoke.Imwrite(@"TempImages\\" + fileName + ".bmp", imgRGB);
            }
            else
            {
                convertType = Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv;
                CvInvoke.CvtColor(imgOryginal, imgHSV, convertType);
                CvInvoke.Imwrite(@"TempImages\\" + fileName + ".bmp", imgHSV);
            }
            bmp = new Bitmap(@"TempImages\\" + fileName + ".bmp");
            pictureBoxMain.Image = bmp;

            if (Type == "RGB")
            {
                buttonHSV.Enabled = true;
                buttonRGB.Enabled = false;
            }
            else
            {
                buttonHSV.Enabled = false;
                buttonRGB.Enabled = true;
            }
        }
        //**************************************************************************************************************
        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            OpenImage();
        }
        private void buttonHSV_Click(object sender, EventArgs e)
        {
            ColorConverting("HSV");
            colorModel = "HSV";
            buttonRGB.Enabled = true;
        }
        private void buttonRGB_Click(object sender, EventArgs e)
        {
            ColorConverting("RGB");
            colorModel = "RGB";
        }
        //**************************************************************************************************************
        // funkca linii profilu
        private void buttonProfileLine_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image == null)
            {
                MessageBox.Show("Open the image before...");
                return;
            }
            else
            {
                Image img = pictureBoxMain.Image;
                PlotProfileForm plotForm = new PlotProfileForm(img,colorModel);
                plotForm.Text = this.Text;
                plotForm.Width = pictureBoxMain.Image.Width + 16;
                plotForm.Height = pictureBoxMain.Image.Height + 39;
                plotForm.Show();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"TempImages");
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
        }
    }
}

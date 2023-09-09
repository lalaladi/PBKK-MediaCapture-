using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Diagnostics.Tracing;

namespace Web_Capture
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSource;  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo deviceList in captureDevice)
            {
                comboBoxCam.Items.Add(deviceList.Name);
            }
            comboBoxCam.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                picBox1.Image = null;
                picBox1.Invalidate();
            }
            videoSource = new VideoCaptureDevice(captureDevice[comboBoxCam.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            picBox2.Image = (Bitmap)picBox1.Image.Clone();
        }

        private void BtnSaveImg_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save Image As";
            saveFile.Filter = "Image files (*.jpg, *.png) | *.jpg, *.png" ;
            ImageFormat imageFormat = ImageFormat.Png;

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFile.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg; 
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                }
                picBox2.Image.Save(saveFile.FileName, imageFormat);
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                picBox1.Image = null;
                picBox1.Invalidate();
            }
            Application.Exit(null);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

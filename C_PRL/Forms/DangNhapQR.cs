using AForge.Video.DirectShow;
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
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using ZXing.Client;
using ZXing.QrCode;
using ZXing.Rendering;
using A_DAL.Repositories;

namespace C_PRL.Forms
{
    public partial class DangNhapQR : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        DangNhapRepos _repos = new DangNhapRepos();
        public DangNhapQR()
        {
            InitializeComponent();
        }
        private void DangNhapQR_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                comboBox1.Items.Add(Device.Name);

            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            button2.Enabled=true;
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
               BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox1.Image);
                try
                {
                    string decoded = result.ToString().Trim();
                    if (decoded == "CuXuanHop" || decoded =="NguyenXuanDung")
                    {
                    timer1.Stop();
                    MessageBox.Show(decoded);



                    TrangChu tt = new TrangChu(null);
                    tt.Show();
                    tt.FormClosed += DangNhapQR_FormClosed;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("mã này không thể đăng nhập");
                }


            }
            catch (Exception ex)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

       

      

        private void DangNhapQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning != true)
                
                FinalFrame.Stop();
        }

        private void DangNhapQR_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DangNhap tt = new DangNhap();
            tt.Show();
            tt.FormClosed += DangNhapQR_FormClosed;
            this.Hide();
        }
    }
}

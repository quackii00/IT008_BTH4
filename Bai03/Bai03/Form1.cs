using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class MainForm : Form
    {
      
        public MainForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + "-" + "Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file để mở";
            openFileDialog.Filter = "Media files (*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3)|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }


        private void Form_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += Timer_Tick;
            timer.Start();

            axWindowsMediaPlayer1.uiMode = "full";
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + "-" + "Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
        }

       
    }
}

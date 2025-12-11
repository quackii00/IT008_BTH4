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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      

        private void btnDestAddress_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDestAddress.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSourceAddress_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSourceAddress.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            string sourcePath = textBoxSourceAddress.Text;
            string destPath = textBoxDestAddress.Text;

            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại!");
                return;
            }
            if (!Directory.Exists(destPath))
            {
                MessageBox.Show("Thư mục đích không tồn tại!");
                return;
            }

            btnCopy.Enabled = false;

            string[] files = Directory.GetFiles(sourcePath);
            progressBar1.Value = 0;
            progressBar1.Maximum = files.Length;

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(destPath, fileName);
                string destpathfile = Path.Combine(destPath, fileName);
                toolStripStatusCopy.Text = "Đang sao chép: " + destpathfile;
                toolTip1.SetToolTip(progressBar1, destpathfile);


                await Task.Run(() => File.Copy(file, destFile, true));

                progressBar1.Value++;
                await Task.Delay(50); 
            }

            toolStripStatusCopy.Text = "Hoàn tất!";
            btnCopy.Enabled = true;
            MessageBox.Show("Sao chép hoàn thành!");
        }
    }
}

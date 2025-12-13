using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (files.Length == 0)
                MessageBox.Show("Không có tập tin nào để sao chép!");
            else
            {
                await Task.Run(() =>
                {
                    int count = 0;
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(destPath, fileName);
                        string destpathfile = Path.Combine(destPath, fileName);
                        File.Copy(file, destFile, true);

                        count++;
                        this.Invoke(new Action(() =>
                        {
                            progressBar1.Value = count;
                            toolStripStatusCopy.Text = $"Đang sao chép: {destpathfile}";
                            toolTip1.SetToolTip(progressBar1, destpathfile);
                        }));
                    }
                });

                toolStripStatusCopy.Text = "Hoàn tất!";
                MessageBox.Show("Sao chép hoàn thành!");
            
            }
            toolTip1.SetToolTip(progressBar1, "Không có tập tin nào đang sao chép");
            toolStripStatusCopy.Text = "Đang sao chép: ";
            progressBar1.Value = 0;
            btnCopy.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show($"Chuột trái được nhấn. Tọa độ ({e.X},{e.Y})", "Thông báo");
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show($"Chuột phải được nhấn. Tọa độ ({e.X},{e.Y})","Thông báo");
            }
            else if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show($"Chuột giữa được nhấn. Tọa độ ({e.X},{e.Y})","Thông báo");
            }
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            int keyCode = e.KeyValue;
            string keyName = e.KeyCode.ToString();
            char asciiChar = (char)keyCode;
            string keyData= e.KeyData.ToString();
            MessageBox.Show($"Phím được nhấn:\nCó mã: {keyName}\nKeyCode: {keyCode}\nASCII: {(int)asciiChar}\nKeydata:{keyData}","Thông báo");
        }
    }
}

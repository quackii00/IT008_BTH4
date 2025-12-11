using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVienDAL dal = new SinhVienDAL();
                dal.ThemSinhVien(textBoxMaSV.Text, textBoxHoTen.Text, comboBoxKhoa.Text, double.Parse(textBoxDiemTB.Text));

                MessageBox.Show("Thêm thành công!");
                this.DialogResult = DialogResult.OK; // báo cho MainForm biết đã thêm
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

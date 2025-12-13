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
            if (textBoxMaSV == null || textBoxMaSV.Text.Trim() == "" ||
                textBoxHoTen == null || textBoxHoTen.Text.Trim() == "" ||
                comboBoxKhoa == null || comboBoxKhoa.Text.Trim() == "" ||
                textBoxDiemTB == null || textBoxDiemTB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            if (!double.TryParse(textBoxDiemTB.Text, out double diemTB) || diemTB < 0 || diemTB > 10)
            {
                MessageBox.Show("Điểm trung bình phải là một số từ 0 đến 10.");
                return;
            }
            try
            {
                SinhVienDAL dal = new SinhVienDAL();
                dal.AddSinhVien(textBoxMaSV.Text, textBoxHoTen.Text, comboBoxKhoa.Text, double.Parse(textBoxDiemTB.Text));

                MessageBox.Show("Thêm thành công!");
                this.DialogResult = DialogResult.OK; 
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

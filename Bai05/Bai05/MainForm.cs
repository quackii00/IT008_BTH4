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
    public partial class MainForm : Form
    {
        private SinhVienDAL dal = new SinhVienDAL();
        BindingSource bs = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
           
 

        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            var frm = new AddForm();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData(); 

            }
        }
        public void LoadData()
        {
            bs.DataSource = dal.LayDanhSachSinhVien();
            dataGridView1.DataSource = bs;          
            dataGridView1.Columns["DiemTB"].HeaderText = "Điểm TB";
            dataGridView1.Columns["MaSV"].HeaderText = "Mã Số SV";
            dataGridView1.Columns["HoTen"].HeaderText = "Tên Sinh Viên";
            dataGridView1.Columns["Khoa"].HeaderText = "Khoa";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(toolstripFindbox.Text))
            {
                bs.RemoveFilter();
            }
            else
            {
               
                
                bs.Filter = $"HoTen LIKE '%%%{toolstripFindbox.Text}%'";
            }
        }

        private void RowPostPaintStt(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];

            if (row.IsNewRow || row.Cells["MaSV"].Value == null || string.IsNullOrWhiteSpace(row.Cells["MaSV"].Value.ToString()))
                return;

            row.Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
    }


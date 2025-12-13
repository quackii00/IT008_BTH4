namespace Bai05
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDiemTB = new System.Windows.Forms.TextBox();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDiemTB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHoTen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMaSV, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxKhoa, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 69);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1092, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxDiemTB
            // 
            this.textBoxDiemTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiemTB.Location = new System.Drawing.Point(279, 330);
            this.textBoxDiemTB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.textBoxDiemTB.Name = "textBoxDiemTB";
            this.textBoxDiemTB.Size = new System.Drawing.Size(261, 37);
            this.textBoxDiemTB.TabIndex = 7;
            // 
            // textBoxHoTen
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxHoTen, 3);
            this.textBoxHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHoTen.Location = new System.Drawing.Point(279, 110);
            this.textBoxHoTen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(807, 37);
            this.textBoxHoTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm TB";
            // 
            // textBoxMaSV
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxMaSV, 2);
            this.textBoxMaSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMaSV.Location = new System.Drawing.Point(279, 0);
            this.textBoxMaSV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(534, 37);
            this.textBoxMaSV.TabIndex = 4;
            // 
            // comboBoxKhoa
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxKhoa, 3);
            this.comboBoxKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Items.AddRange(new object[] {
            "Khoa học máy tính",
            "Kỹ thuật máy tính",
            "Hệ thống thông tin",
            "Công nghệ phần mềm",
            "Mạng máy tính & Truyền thông dữ liệu",
            "Công nghệ thông tin"});
            this.comboBoxKhoa.Location = new System.Drawing.Point(279, 220);
            this.comboBoxKhoa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(807, 38);
            this.comboBoxKhoa.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.9763F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0237F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonExit, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(694, 521);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(422, 75);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(6, 6);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(219, 63);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Thêm Mới";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Location = new System.Drawing.Point(237, 6);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(179, 63);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.Exit);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 669);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sinh Viên";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDiemTB;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
    }
}
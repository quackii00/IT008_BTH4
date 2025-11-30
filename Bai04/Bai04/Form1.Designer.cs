namespace Bai04
{
    partial class MainForm
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taoVanBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.luuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DinhDangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBottom = new System.Windows.Forms.ToolStrip();
            this.newtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.savetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ItoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStripTop.SuspendLayout();
            this.toolStripBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.DinhDangToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1568, 52);
            this.menuStripTop.TabIndex = 2;
            this.menuStripTop.Text = "menuStrip2";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoVanBanToolStripMenuItem,
            this.moToolStripMenuItem,
            this.toolStripSeparator1,
            this.luuToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(157, 44);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // taoVanBanToolStripMenuItem
            // 
            this.taoVanBanToolStripMenuItem.Image = global::Bai04.Properties.Resources.blank_page;
            this.taoVanBanToolStripMenuItem.Name = "taoVanBanToolStripMenuItem";
            this.taoVanBanToolStripMenuItem.Size = new System.Drawing.Size(431, 48);
            this.taoVanBanToolStripMenuItem.Text = "Tạo văn bản mới";
            this.taoVanBanToolStripMenuItem.Click += new System.EventHandler(this.new_click);
            // 
            // moToolStripMenuItem
            // 
            this.moToolStripMenuItem.Image = global::Bai04.Properties.Resources.open_folder;
            this.moToolStripMenuItem.Name = "moToolStripMenuItem";
            this.moToolStripMenuItem.Size = new System.Drawing.Size(431, 48);
            this.moToolStripMenuItem.Text = "Mở tập tin";
            this.moToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(428, 6);
            // 
            // luuToolStripMenuItem
            // 
            this.luuToolStripMenuItem.Image = global::Bai04.Properties.Resources.diskette;
            this.luuToolStripMenuItem.Name = "luuToolStripMenuItem";
            this.luuToolStripMenuItem.Size = new System.Drawing.Size(431, 48);
            this.luuToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.luuToolStripMenuItem.Click += new System.EventHandler(this.save_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(431, 48);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DinhDangToolStripMenuItem
            // 
            this.DinhDangToolStripMenuItem.Name = "DinhDangToolStripMenuItem";
            this.DinhDangToolStripMenuItem.Size = new System.Drawing.Size(169, 44);
            this.DinhDangToolStripMenuItem.Text = "Định dạng";
            this.DinhDangToolStripMenuItem.Click += new System.EventHandler(this.DinhDang_click);
            // 
            // toolStripBottom
            // 
            this.toolStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtoolStripButton,
            this.savetoolStripButton,
            this.toolStripSeparator2,
            this.toolStripComboBoxFont,
            this.toolStripComboBoxSize,
            this.toolStripSeparator3,
            this.BtoolStripButton,
            this.ItoolStripButton,
            this.UtoolStripButton});
            this.toolStripBottom.Location = new System.Drawing.Point(0, 52);
            this.toolStripBottom.Name = "toolStripBottom";
            this.toolStripBottom.Size = new System.Drawing.Size(1568, 50);
            this.toolStripBottom.TabIndex = 4;
            this.toolStripBottom.Text = "toolStrip1";
            // 
            // newtoolStripButton
            // 
            this.newtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newtoolStripButton.Image = global::Bai04.Properties.Resources.blank_page;
            this.newtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newtoolStripButton.Name = "newtoolStripButton";
            this.newtoolStripButton.Size = new System.Drawing.Size(46, 36);
            this.newtoolStripButton.Text = "newtoolStripButton";
            this.newtoolStripButton.Click += new System.EventHandler(this.Open_Click);
            // 
            // savetoolStripButton
            // 
            this.savetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savetoolStripButton.Image = global::Bai04.Properties.Resources.diskette;
            this.savetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savetoolStripButton.Name = "savetoolStripButton";
            this.savetoolStripButton.Size = new System.Drawing.Size(46, 36);
            this.savetoolStripButton.Text = "savetoolStripButton";
            this.savetoolStripButton.Click += new System.EventHandler(this.save_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(121, 42);
            this.toolStripComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.FontOrSize_Changed);
            // 
            // toolStripComboBoxSize
            // 
            this.toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            this.toolStripComboBoxSize.Size = new System.Drawing.Size(121, 42);
            this.toolStripComboBoxSize.SelectedIndexChanged += new System.EventHandler(this.FontOrSize_Changed);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // BtoolStripButton
            // 
            this.BtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtoolStripButton.Image = global::Bai04.Properties.Resources.document;
            this.BtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtoolStripButton.Name = "BtoolStripButton";
            this.BtoolStripButton.Size = new System.Drawing.Size(46, 36);
            this.BtoolStripButton.Text = "BtoolStripButton";
            this.BtoolStripButton.Click += new System.EventHandler(this.Bold_Click);
            // 
            // ItoolStripButton
            // 
            this.ItoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItoolStripButton.Image = global::Bai04.Properties.Resources.italic;
            this.ItoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItoolStripButton.Name = "ItoolStripButton";
            this.ItoolStripButton.Size = new System.Drawing.Size(46, 36);
            this.ItoolStripButton.Text = "ItoolStripButton";
            this.ItoolStripButton.Click += new System.EventHandler(this.Italic_Click);
            // 
            // UtoolStripButton
            // 
            this.UtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UtoolStripButton.Image = global::Bai04.Properties.Resources.text;
            this.UtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UtoolStripButton.Name = "UtoolStripButton";
            this.UtoolStripButton.Size = new System.Drawing.Size(46, 36);
            this.UtoolStripButton.Text = "UtoolStripButton";
            this.UtoolStripButton.Click += new System.EventHandler(this.Underline_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 102);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1568, 977);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1079);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStripBottom);
            this.Controls.Add(this.menuStripTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.toolStripBottom.ResumeLayout(false);
            this.toolStripBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taoVanBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem luuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DinhDangToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripBottom;
        private System.Windows.Forms.ToolStripButton newtoolStripButton;
        private System.Windows.Forms.ToolStripButton savetoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtoolStripButton;
        private System.Windows.Forms.ToolStripButton ItoolStripButton;
        private System.Windows.Forms.ToolStripButton UtoolStripButton;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}


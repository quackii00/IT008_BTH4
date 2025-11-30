using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class MainForm : Form
    {
      
        public MainForm()
        {
            InitializeComponent();
            toolStripBottom.ImageScalingSize = new Size(16, 16);
            BtoolStripButton.CheckOnClick = true;
            ItoolStripButton.CheckOnClick = true;
            UtoolStripButton.CheckOnClick = true;
         
            taoVanBanToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            luuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;

            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                toolStripComboBoxFont.Items.Add(font.Name);
            }
            toolStripComboBoxFont.SelectedItem = "Tahoma";
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach(int size in sizes)
            {
                toolStripComboBoxSize.Items.Add(size);
            }
            toolStripComboBoxSize.SelectedItem = 14;

            richTextBox.Font = new Font("Tahoma", 14, FontStyle.Regular);

         
        }
        
        
        private void DinhDang_click(object sender, EventArgs e)
        {
            FontDialog fontdialog = new FontDialog();
            fontdialog.Font = richTextBox.SelectionFont;
            if (fontdialog.ShowDialog()==DialogResult.OK)
            {
                richTextBox.SelectionFont = fontdialog.Font;
                toolStripComboBoxFont.SelectedItem = fontdialog.Font.Name;
                toolStripComboBoxSize.SelectedItem = (int)Math.Round(fontdialog.Font.Size);
            }
           
           
        }

        private void new_click(object sender, EventArgs e)
        {
            this.richTextBox.Clear();
            toolStripComboBoxFont.SelectedItem = "Tahoma";
            toolStripComboBoxSize.SelectedItem = 14;
            richTextBox.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fidialog = new OpenFileDialog();
            fidialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf"; ;
            if (fidialog.ShowDialog() == DialogResult.OK)
            {
                if (fidialog.FileName.EndsWith(".rtf"))
                {
                    richTextBox.LoadFile(fidialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox.LoadFile(fidialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName.EndsWith(".rtf"))
                    richTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ToggleFontStyle(FontStyle style)
        {
            Font currentFont = richTextBox.SelectionFont ?? richTextBox.Font;
            FontStyle newStyle = currentFont.Style ^ style;
            richTextBox.SelectionFont = new Font(currentFont, newStyle);
        }
        private void Bold_Click(object sender, EventArgs e)
        {
            if (BtoolStripButton.Checked)
            {
                BtoolStripButton.BackColor = Color.LightGray;
            }
            else
            {
                BtoolStripButton.BackColor = SystemColors.Control;
            }    
                ToggleFontStyle(FontStyle.Bold);
            
            
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
           
        }

        

        private void FontOrSize_Changed(object sender, EventArgs e)
        {
            Font CurrentFont = richTextBox.SelectionFont ?? richTextBox.Font;
            string fontName = toolStripComboBoxFont.SelectedItem.ToString();
            float fontsize;
            if (toolStripComboBoxSize.SelectedItem != null)
            {
                fontsize = Convert.ToInt32(toolStripComboBoxSize.SelectedItem);
            }
            else
            {
                fontsize = CurrentFont.Size;
            }
            FontStyle style = CurrentFont.Style;
            richTextBox.SelectionFont = new Font(fontName, fontsize, style);
        }
    }
}

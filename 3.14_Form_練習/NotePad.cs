using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._14_Form_練習
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString("T");
        }
        void Open()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "開啟";
            open.FileName = "openFileDialog1";
            if (open.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(open.FileName);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void toolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void toolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void toolStripMenuItemSelectAll_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void toolStripMenuItemColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = color.Color;
            }
        }

        private void toolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = font.Font;
            }
        }

        private void toolStripMenuItemToUpper_Click(object sender, EventArgs e)
        {
            richTextBox.Text = richTextBox.Text.ToUpper();
        }

        private void toolStripMenuItemToLower_Click(object sender, EventArgs e)
        {
            richTextBox.Text = richTextBox.Text.ToLower();
        }

        private void toolStripMenuItemEnter_Click(object sender, EventArgs e)
        {
            if (richTextBox.WordWrap == false)
            {
                richTextBox.WordWrap = true;
                richTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            }
            else
            {
                richTextBox.WordWrap = false;
                richTextBox.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            }
        }

        private void toolStripMenuItemRed_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionColor = Color.Red;
        }

        private void toolStripMenuItemGreen_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionColor = Color.Green;
        }

        private void toolStripMenuItemBlue_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionColor = Color.Blue;
        }

        private void toolStripMenuItemBlack_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionColor = Color.Black;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            NotePad2 notepad2 = new NotePad2();
            notepad2.Show();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            NotePad2 notepad2 = new NotePad2();
            notepad2.Show();
        }

        private void toolStripMenuItemOver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

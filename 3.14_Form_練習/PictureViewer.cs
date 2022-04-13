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
    public partial class PictureViewer : Form
    {
        PictureBox[] picture = new PictureBox[22];
        public PictureViewer()
        {
            InitializeComponent();
            for (int i = 0; i < picture.Length; i++)
            {
                picture[i] = new PictureBox();
                picture[i].Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\" + i.ToString() + ".jpg");
                picture[i].SizeMode = PictureBoxSizeMode.Zoom;
                picture[i].Click += new EventHandler(pictureClick);
                picture[i].Size = new Size(70, 50);
                picture[i].Anchor = AnchorStyles.Left;
                if (i < 8)
                    picture[i].Location = new Point(10 + i * 80, 5);
                else if (i >= 8 && i < 16)
                    picture[i].Location = new Point(10 + (i - 8) * 80, 75);
                else
                    picture[i].Location = new Point(10 + (i - 16) * 80, 150);

                this.Controls.Add(picture[i]);
            }
        }

        public void pictureClick(object sender, EventArgs e)
        {
            PictureBox selectedPic = (PictureBox)sender;
            PictureViewer2 pictureViewer2 = new PictureViewer2(selectedPic);
            pictureViewer2.Show();
        }

        private void PictureViewer_Resize(object sender, EventArgs e)
        {
            int h = 5;
            int w = 10;
            for (int i = 0; i < picture.Length; i++)
            {
                if (w > this.Width - 80)
                {
                    w = 10;
                    h += 70;
                }
                picture[i].Location = new Point(w, h);
                w += 80;
            }
        }
    }
}

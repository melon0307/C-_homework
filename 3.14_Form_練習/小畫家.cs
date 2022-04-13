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
    public partial class 小畫家 : Form
    {
        Pen pen;
        int X0, Y0;
        public 小畫家()
        {
            InitializeComponent();
            pictureboxCanvas.Image = new Bitmap(800, 500);
            pen = new Pen(Color.Black, 1);
            labPen.Text = "1";
            labColor.Text = "      ";
        }

        private void pictureboxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics paint = Graphics.FromImage(pictureboxCanvas.Image);
                paint.DrawLine(pen, X0, Y0, e.X, e.Y);
                X0 = e.X;
                Y0 = e.Y;

                pictureboxCanvas.Refresh();

            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog penColor = new ColorDialog();
            if (penColor.ShowDialog() == DialogResult.OK)
            {
                pen.Color = penColor.Color;
                labColor.BackColor = penColor.Color;
                labColor.Text = "      ";
            }
        }

        private void trackPen_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackPen.Value;
            labPen.Text = trackPen.Value.ToString();
        }

        private void pictureboxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            X0 = e.X;
            Y0 = e.Y;
        }
    }
}

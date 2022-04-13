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
    public partial class Screen_Saver : Form
    {
        int screenX, screenY;
        int x, y=0;
        int speed = 7;
        int xx=1, yy = 1;
        int mstartx = Cursor.Position.X;
        int mstarty = Cursor.Position.Y;
        public Screen_Saver()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            Rectangle screenSize = Screen.GetWorkingArea(this);
            screenX = screenSize.Width;
            screenY = screenSize.Height;            
            Cursor.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += speed * xx;
            y += speed * yy;

            if (x + pictureBox.Width > screenX || x < 0)
            {
                xx = -xx;                
            }
            else { };            
            
            if (y  > screenY || y < 0)
            {
                yy = -yy;               
            }
            else { };

            pictureBox.Location = new Point(x,y);

            if (mstartx != Cursor.Position.X || mstarty != Cursor.Position.Y)
            {
                this.Close();
                Cursor.Show();
            }
        }
    }
}

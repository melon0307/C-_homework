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
    public partial class XOGame : Form
    {
        bool XO = true;
        int count = 0;
        public XOGame()
        {
            InitializeComponent();
            button2.Click += new System.EventHandler(button1_Click);
            button3.Click += new System.EventHandler(button1_Click);
            button4.Click += new System.EventHandler(button1_Click);
            button5.Click += new System.EventHandler(button1_Click);
            button6.Click += new System.EventHandler(button1_Click);
            button7.Click += new System.EventHandler(button1_Click);
            button8.Click += new System.EventHandler(button1_Click);
            button9.Click += new System.EventHandler(button1_Click);
            button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (XO)
            {
                button.Text = "X";
                button.ForeColor = Color.Aqua;
                XO = false;
            }
            else
            {
                button.Text = "O";
                button.ForeColor = Color.Aqua;
                XO = true;
            }
            button.Enabled = false;
            ++count;
            Winner();
        }
        private void ButtonEnable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Winner()
        {
            bool winnerConfirm = false;
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
                winnerConfirm = true;
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
                winnerConfirm = true;
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
                winnerConfirm = true;
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
                winnerConfirm = true;
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
                winnerConfirm = true;
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
                winnerConfirm = true;
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
                winnerConfirm = true;
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
                winnerConfirm = true;
            else { }
            if (winnerConfirm)
            {
                ButtonEnable();
                string winner = "";
                if (XO)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show(winner + "手獲勝!", "完局!");
                Reset();
            }
            else if (count >= 9)
            {
                DialogResult result = MessageBox.Show("平手! 按下確定重新開始", "完局!");
                switch (result)
                {
                    case DialogResult.OK:
                        Reset();
                        break;
                }
            }
            else { };
        }
        private void Reset()
        {
            XO = true;
            count = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {           
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void XOGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();              
            }
        }
    }
}

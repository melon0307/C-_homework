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
    public partial class 考試_Alarm : Form
    {
        string alarm="";
        string Date = DateTime.Now.ToString("HH:mm:ss");
        bool flash = true;
        
        public 考試_Alarm()
        {
            InitializeComponent();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date = DateTime.Now.ToString("HH:mm:ss");
            labTime.Text = Date;
            if (alarm == Date)
            {
                DialogResult result;
                timer2.Enabled = true;
                result=MessageBox.Show( "鬧鐘響了 ! ","嗶嗶嗶 ! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
                txtHH.Enabled = true;
                txtHH.Text = "";
                txtmm.Enabled = true;
                txtmm.Text = "";
                txtss.Enabled = true;
                txtss.Text = "";
                alarm = "";
                checkbxSet.Checked = false;
                if (result == DialogResult.OK)
                {
                    timer2.Enabled = false;
                    this.BackColor = Color.LemonChiffon;
                }
            }
        }

        private void checkbxSet_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkbxSet.Checked)
            {
                int HH, mm , ss ;
                if (int.TryParse(txtHH.Text, out HH) && int.TryParse(txtmm.Text, out mm) && int.TryParse(txtss.Text, out ss))
                {
                    if (HH >= 0 || HH <= 24 || mm >= 0 || mm <= 60 || ss >= 0 || ss <= 60)
                    {
                        txtHH.Enabled = false;
                        txtmm.Enabled = false;
                        txtss.Enabled = false;
                        alarm = HH.ToString() + ":" + mm.ToString() + ":" + ss.ToString();
                    }
                    else
                    {
                        error();
                        return;
                    }
                }
                else 
                {
                    error();
                    return;
                }
            }
            else 
            {
                txtHH.Enabled = true;
                txtmm.Enabled = true;
                txtss.Enabled = true;
                alarm = "";
            }
        }
        public void error()
        {
            MessageBox.Show("請輸入正確時間格式！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            checkbxSet.Checked = false;
            txtHH.Text = "";
            txtmm.Text = "";
            txtss.Text = "";
            txtHH.Focus();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.BackColor = flash ? Color.LemonChiffon : Color.MistyRose;
            flash = !flash;
        }
    }
}

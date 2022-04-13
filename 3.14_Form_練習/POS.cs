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
    public partial class POS : Form
    {
        double total = 0;
        int countapple, countbanana, countgrape, countpineapple, timeapple, timebanana, timegrape, timepineapple = 0;
        string[] fruit = new string[] { "蘋果apple x ", "香蕉banana x ", "葡萄grape x ", "鳳梨pineapple x " };
        string a, b, c, d;
        public POS()
        {
            InitializeComponent();
        }

        private void btnapple_Click(object sender, EventArgs e)
        {
            ++countapple;
            timeapple = timeapple + 30;
            total = total + 30;
            txtTotalPrice.Text = "NT$: " + total;
            a = fruit[0] + countapple + ", 共NT$" + timeapple + "元" + "\r\n";
            txtlist.Text = a + b + c + d;

        }

        private void btnbanana_Click(object sender, EventArgs e)
        {
            ++countbanana;
            timebanana = timebanana + 50;
            total = total + 50;
            txtTotalPrice.Text = "NT$: " + total;
            b = fruit[1] + countbanana + ", 共NT$" + timebanana + "元" + "\r\n";
            txtlist.Text = a + b + c + d;
        }

        private void btngrape_Click(object sender, EventArgs e)
        {
            ++countgrape;
            timegrape = timegrape + 100;
            total = total + 100;
            txtTotalPrice.Text = "NT$: " + total;
            c = fruit[2] + countgrape + ", 共NT$" + timegrape + "元" + "\r\n";
            txtlist.Text = a + b + c + d;
        }

        private void btnpineapple_Click(object sender, EventArgs e)
        {
            ++countpineapple;
            timepineapple = timepineapple + 150;
            total = total + 150;
            txtTotalPrice.Text = "NT$: " + total;
            d = fruit[3] + countpineapple + ", 共NT$" + timepineapple + "元";
            txtlist.Text = a + b + c + d;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show(" 尚未點餐 !", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("總金額 : NT$" + total, "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show(" 尚未點餐 !", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                double x = total * 0.9;
                MessageBox.Show("總金額 : NT$" + total + "\n" + "折扣後金額 : NT$" + x, "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
                total = 0;
                txtTotalPrice.Text = "NT$: " + total;
                countapple = 0; timeapple = 0; countbanana = 0; timebanana = 0; countgrape = 0; timegrape = 0; countpineapple = 0;
                timepineapple = 0;
                a = null; b = null; c = null; d = null;
                txtlist.Clear();
                txtlist.Text = "尚未點餐";
            }
    }
}

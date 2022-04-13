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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        
        private void btnmonthlypmt_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txttotal.Text);
            double year = Convert.ToDouble(txtyear.Text);
            double rate = Convert.ToDouble(txtrate.Text);
            double dwnpmt = Convert.ToDouble(txtdownpayment.Text);
            double r = rate / 100 / 12;
            double n = year * 12;
            total = total - dwnpmt;
            double pay = total * (r * Math.Pow((1 + r), n) / (Math.Pow((1 + r), n) - 1));
            pay = Math.Floor(pay);
            MessageBox.Show("月付額: " + pay + "元");
        }
        
        private void btntotalpayment_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txttotal.Text);
            double year = Convert.ToDouble(txtyear.Text);
            double rate = Convert.ToDouble(txtrate.Text);
            double dwnpmt = Convert.ToDouble(txtdownpayment.Text);
            double r = rate / 100 / 12;
            double n = year * 12;
            total = total - dwnpmt;
            double pay = total * (r * Math.Pow((1 + r), n) / (Math.Pow((1 + r), n) - 1));
            pay = Math.Floor(pay);
            double totalpay = pay * n;

            MessageBox.Show("總付款: " +totalpay  + "元");
        }              

        private void btnReport_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txttotal.Text);
            double year = Convert.ToDouble(txtyear.Text);
            double rate = Convert.ToDouble(txtrate.Text);
            double dwnpmt = Convert.ToDouble(txtdownpayment.Text);
            double r = rate / 100 / 12;
            double n = year * 12;
            total = total - dwnpmt;
            double pay = total * (r * Math.Pow((1 + r), n) / (Math.Pow((1 + r), n) - 1));
            pay = Math.Floor(pay);
            double totalpay = pay * n;
            LoanReport loanReport = new LoanReport(txttotal.Text,txtyear.Text,txtrate.Text,pay.ToString(),totalpay.ToString());
            loanReport.Show();
        }
        

    }
}

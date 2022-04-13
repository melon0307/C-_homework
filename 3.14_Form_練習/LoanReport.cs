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
    public partial class LoanReport : Form
    {
        public LoanReport(string LR1, string LR2, string LR3, string LR4, string LR5)
        {
            InitializeComponent();
            txttotal.Text = LR1;
            txtyear.Text = LR2;
            txtrate.Text = LR3;
            txtmonthlypmt.Text = LR4;
            txttotalpayment.Text = LR5;
        }
    }
}

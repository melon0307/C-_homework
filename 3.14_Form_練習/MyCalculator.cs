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
    public partial class MyCalculator : Form
    {
        public MyCalculator()
        {
            InitializeComponent();
        }

        double num1 ,num2,answer= 0;      

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtNum1.Text);
                num2 = double.Parse(txtNum2.Text);
                answer = num1 + num2;
                txtAnswer.Text = answer.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtNum1.Text);
                num2 = double.Parse(txtNum2.Text);
                answer = num1 - num2;
                txtAnswer.Text = answer.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtNum1.Text);
                num2 = double.Parse(txtNum2.Text);
                answer = num1 * num2;
                txtAnswer.Text = answer.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void btnDevided_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtNum1.Text);
                num2 = double.Parse(txtNum2.Text);
                answer = num1 / num2;
                txtAnswer.Text = answer.ToString("f3");
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值。");
            }
        }
    }
}

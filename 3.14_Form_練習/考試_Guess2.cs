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
    public partial class 考試_Guess2 : Form
    {
        Random rd = new Random();
        int answer, guess;
        bool newAnswer = false;
        int[] range = { 1, 100 };
             
        public 考試_Guess2(int answerFromA)
        {
            InitializeComponent();
            answer = answerFromA;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            考試_Guess A = (考試_Guess)this.Owner;
            if (newAnswer)
            {
                answer = rd.Next(1, 101);
                newAnswer = false;
                A.newAnswer = newAnswer;
                A.answer = answer;
            }
            else { }
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInput.Text, out guess) || guess < range[0] || guess > range[1])
            {
                MessageBox.Show("請輸入" + range[0] + "~" + range[1] + "之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else 
            {
                考試_Guess A = (考試_Guess)this.Owner;
                if (guess > answer)
                {
                    range[1] = guess;
                    A.lab.Text = "Too Large !\r\nBetween " + range[0] + " and " + range[1];
                }
                else if (guess < answer)
                {
                    range[0] = guess;
                    A.lab.Text = "Too Small !\r\nBetween " + range[0] + " and " + range[1];
                }
                else
                {
                    MessageBox.Show("congradulations!!! You got " + answer + " !");
                    newAnswer = true;
                }
            }
            txtInput.Focus();
            txtInput.SelectAll();
        }
    }
}

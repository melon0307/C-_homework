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
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }
        int[] arr0771 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arr0771_Str = { "mother張", "emma", "迪克蕭", "J40", "Motherfacker", "Candy", "Cindy", "Coconut" };
        StringBuilder s = new StringBuilder();

        bool 偶數(int n)
        {
            return n % 2 == 0 ? true : false;
        }

        string Starr0771()
        {
            s.Clear();
            s.Append("int陣列arr0711[ ");
            foreach (int n in arr0771)
                s.Append(n + " ,");
            s.Remove(s.Length - 2, 2);
            s.Append("]\r\n");

            return s.ToString();
        }

        string 二維陣列(int n)
        {
            s.Clear();
            s.Append(" ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (二維陣列判斷(n, i, j))
                        s.Append("1");
                    else
                        s.Append("0");
                    s.Append(" ");
                }
                s.Append("\r\n ");
            }
            return s.ToString();
        }

        bool 二維陣列判斷(int n, int i, int j)
        {
            if (n == 0)
                return i == 0 || i == 9 || j == 0 || j == 9;
            else if (n == 1)
                return !(i == 0 || i == 9 || j == 0 || j == 9);
            else
                return (i + j) % 2 == 1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int even = 0;
            int odd = 0;
            foreach (int n in arr0771)
            {
                if (偶數(n))
                    even++;
                else
                    odd++;
            }
            labResult.Text = Starr0771() + "奇數共  " + odd + "\r\n偶數共  " + even;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labResult.Text = 二維陣列(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            int x;
            string a = "換位前n1=" + n1 + " , n2=" + n2 + "\r\n";
            x = n1;
            n1 = n2;
            n2 = x;
            string b = "換位後n1=" + n1 + " , n2=" + n2 ;
            labResult.Text = a + b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtNum.Text, out n))
            {
                if (偶數(n))
                    labResult.Text = "輸入的數 " + n + "為  偶數。";
                else
                    labResult.Text = "輸入的數 " + n + "為  奇數。";
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int max = arr0771_Str[0].Length;
            int index = 0;
            for (int i = 0; i < arr0771_Str.Length; i++)
            {
                if (max <= arr0771_Str[i].Length)
                {
                    max = arr0771_Str[i].Length;
                    index = i;
                }
                else { }
                labResult.Text = "陣列arr0771_Str  [ mother張, emma, 迪克蕭, J40, Motherfacker, Candy, Cindy, Coconut ]\r\n最長名字為" + arr0771_Str[index];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labResult.Text = 二維陣列(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s.Clear();
            int sum = arr0771.Sum();
            labResult.Text = Starr0771() + "加總為 " + sum.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int max = arr0771.Max();
            int min = arr0771.Min();
            labResult.Text = Starr0771() + "最大值為 " + max + "\r\n最小值為 " + min.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labResult.Text = 二維陣列(2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int max = arr0771.Max();
            labResult.Text = Starr0771() + "最大值為" + max.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int min = arr0771.Min();
            labResult.Text = Starr0771() + "最小值為" + min.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int Cc = 0;
            for (int i =0;i<arr0771_Str.Length;i++)
            {
                foreach (char c in arr0771_Str[i])
                {
                    if (c == 'C' || c == 'c')
                    {
                        Cc++;
                        break;   //不加break,Coconut 中2個C會使變數Cc++2次
                    }
                    else { }
                }
            }
            labResult.Text = "arr0711_Str陣列： mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker" +
                  "\r\n" + "有C 及 c的名字共有 " + Cc + " 個";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }
    }
}

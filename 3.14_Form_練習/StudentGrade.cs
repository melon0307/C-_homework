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
    public partial class StudentGrade : Form
    {
        string name;
        string[] subject = { "國文", "英文", "數學" };
        StudentData[] arrStudent = new StudentData[100];
        int i = -1;
        int count = 0;
        int[] sum = new int[3];
        double[] ave = new double[3];
        int[] max = new int[3];
        int[] min = new int[3];
        Random rd = new Random();

        public StudentGrade()
        {
            InitializeComponent();
            labData.Text = "姓名           " + "國文           " + "英文             " + "數學              " + "總分            " + "平均                 " + "最低             " + "最高";
            btnresult.Enabled = false;
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                MessageBox.Show("請輸入姓名。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtChinese.Text == "")
                MessageBox.Show("請輸入國文成績。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtEnglish.Text == "")
                MessageBox.Show("請輸入英文成績。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtMath.Text == "")
                MessageBox.Show("請輸入數學成績。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Add(false);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (i >= 99)
            {
                MessageBox.Show("記憶體空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Add(true);
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            if (i >= 99)
            {
                MessageBox.Show("記憶體空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            for (int i = 0; i < 20; i++)
            {
                Add(true);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAddData.Enabled = btnRandom.Enabled = btnRandom20.Enabled = btnReset.Enabled = true;
            btnresult.Enabled = false;
            txtResult.Text = null;
            txtData.Text = null;
            i = -1;
            txtName.Text = txtChinese.Text = txtEnglish.Text = txtMath.Text = null;
            Array.Clear(arrStudent, 0, arrStudent.Length);
            Array.Clear(min, 0, min.Length);
            Array.Clear(max, 0, max.Length);
            for (int x = 0; x < 3; x++)
            {
                sum[x] = 0;
                ave[x] = 0;
            }
        }

        private void Add(bool isRandom)
        {
            if (i >= 99)
            {
                MessageBox.Show("記憶體空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            btnresult.Enabled = true;

            arrStudent[++i] = new StudentData();
            arrStudent[i].Name = isRandom ? (i + 1).ToString() : txtName.Text;
            arrStudent[i].grade[0] = isRandom ? rd.Next(0, 101) : int.Parse(txtChinese.Text);
            arrStudent[i].grade[1] = isRandom ? rd.Next(0, 101) : int.Parse(txtEnglish.Text);
            arrStudent[i].grade[2] = isRandom ? rd.Next(0, 101) : int.Parse(txtMath.Text);
            int tempH = arrStudent[i].grade.Max();
            int tempL = arrStudent[i].grade.Min();
            int tempI = Array.IndexOf(arrStudent[i].grade, tempH);
            int tempO = Array.IndexOf(arrStudent[i].grade, tempL);
            string MaxS = subject[tempI];
            string MinS = subject[tempO];
            int total = arrStudent[i].grade[0] + arrStudent[i].grade[1] + arrStudent[i].grade[2];
            double average = total / 3;
            count++;
            txtData.Text += "  " + "\r\n" + arrStudent[i].Name + "\t" + arrStudent[i].grade[0] + "\t" + arrStudent[i].grade[1]
                                      + "\t" + arrStudent[i].grade[2] + "\t" + total + "\t" + average + "\t" + MinS + tempL + "\t" + MaxS + tempH;
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            btnAddData.Enabled = btnRandom.Enabled = btnRandom20.Enabled = btnresult.Enabled = false;
            btnReset.Enabled = true;
            min[0] = arrStudent[0].grade[0];
            min[1] = arrStudent[0].grade[1];
            min[2] = arrStudent[0].grade[2];

            for (int j = 0; j < 3; j++)
            {
                for (int x = 0; x <= i; x++)
                {
                    sum[j] += arrStudent[x].grade[j];

                    if (max[j] < arrStudent[x].grade[j])
                        max[j] = arrStudent[x].grade[j];

                    if (min[j] > arrStudent[x].grade[j])
                        min[j] = arrStudent[x].grade[j];

                }

                ave[j] = Math.Round((double)sum[j] / (i + 1), 1);
            }
            txtResult.Text = "總分\t" + sum[0].ToString() + "\t" + sum[1].ToString() + "\t" + sum[2].ToString()
                + "\r\n平均\t" + ave[0].ToString() + "\t" + ave[1].ToString() + "\t" + ave[2].ToString()
                + "\r\n最高分\t" + max[0].ToString() + "\t" + max[1].ToString() + "\t" + max[2].ToString()
                + "\r\n最低分\t" + min[0].ToString() + "\t" + min[1].ToString() + "\t" + min[2].ToString();
        }
    }
}

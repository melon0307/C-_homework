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
    public partial class StudentGrade_List : Form
    {
        List<stgrList> list = new List<stgrList>();
        int[] sum = new int[3];
        double[] ave = new double[3];
        int[] max = new int[3];
        int[] min = new int[3];
        int count = 0;
        public StudentGrade_List()
        {
            InitializeComponent();
            labData.Text = "姓名           " + "國文           " + "英文             " + "數學              " + "總分            " + "平均                 " + "最低             " + "最高";
        }

        bool isNull()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("請輸入姓名。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtChinese.Text == "")
            {
                MessageBox.Show("請輸入國文。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtEnglish.Text == "")
            {
                MessageBox.Show("請輸入英文。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtMath.Text == "")
            {
                MessageBox.Show("請輸入數學。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else 
            {
                return true;
            }                
        }

        private void Add(bool isInsert)
        {
            btnresult.Enabled = btnDelete.Enabled = btnReset.Enabled = btnSearch.Enabled = true;
            stgrList st = new stgrList();
            st.Name = txtName.Text;
            st.grade[0] = int.Parse(txtChinese.Text);
            st.grade[1] = int.Parse(txtEnglish.Text);
            st.grade[2] = int.Parse(txtMath.Text);
            if (isInsert)
            {
                list.Insert(0, st);
            }
            else
            {
                list.Add(st);
            }
            Show();
        }

        private void Show()
        {
            txtData.Text = "";
            for (int i = 0; i < list.Count; i++)
            {
                txtData.Text += "\r\n" + list[i].Name + "\t" + list[i].grade[0] + "\t" + list[i].grade[1] + "\t" 
                                              + list[i].grade[2] + "\t" + list[i].總分()+"\t"+list[i].平均分數()+"\t"
                                              +list[i].最小分數科目()+"\t"+list[i].最大分數科目();
            }
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (isNull())
            {
                Add(false);
            }            
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            btnAddData.Enabled = btnInsert.Enabled = btnDelete.Enabled = btnSearch.Enabled = false;
            btnReset.Enabled = true;
            for(int i = 0; i < sum.Length; i++)
            {
                sum[i] = 0;
                ave[i] = 0;
                max[i] = 0;
                min[i] = 999;
            }

            for(int j = 0; j < 3; j++)
            {
                for(int i =0; i < list.Count; i++)
                {
                    sum[j] += list[i].grade[j];
                    if (min[j] > list[i].grade[j])
                        min[j] = list[i].grade[j];
                    if (max[j] < list[i].grade[j])
                        max[j] = list[i].grade[j];
                }
                ave[j] = Math.Round((double)sum[j] / list.Count , 1);
            }
            txtResult.Text = "總分\t" + sum[0].ToString() + "\t" + sum[1].ToString() + "\t" + sum[2].ToString()
               + "\r\n平均\t" + ave[0].ToString() + "\t" + ave[1].ToString() + "\t" + ave[2].ToString()
               + "\r\n最高分\t" + max[0].ToString() + "\t" + max[1].ToString() + "\t" + max[2].ToString()
               + "\r\n最低分\t" + min[0].ToString() + "\t" + min[1].ToString() + "\t" + min[2].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAddData.Enabled = btnInsert.Enabled = btnReset.Enabled = true;
            btnDelete.Enabled  = btnresult.Enabled = btnSearch.Enabled = false;
            txtResult.Text = null;
            txtData.Text = null;
            list.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            list.RemoveAt(0);
            Show();
            if (list.Count == 0)
            {
                btnDelete.Enabled =  btnresult.Enabled = btnSearch.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (isNull())
            {
                Add(true);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                btnresult.Enabled = false;
                int range1 = int.Parse(txtRange1.Text);
                int range2 = int.Parse(txtRange2.Text);
                int max = (range1 > range2) ? range1 : range2;
                int min = (range1 < range2) ? range1 : range2;
                txtData.Text = "";
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].grade[0] >= min && list[i].grade[0] <= max)
                    {
                        txtData.Text += "\r\n" + list[i].Name + "\t" + list[i].grade[0] + "\t" + list[i].grade[1] + "\t"
                                                  + list[i].grade[2] + "\t" + list[i].總分() + "\t" + list[i].平均分數() + "\t"
                                                  + list[i].最小分數科目() + "\t" + list[i].最大分數科目();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

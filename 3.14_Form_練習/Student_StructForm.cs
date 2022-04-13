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
    public partial class Student_StructForm : Form
    {
        string studentName = "";
        int studentChi = 0;
        int studentEng = 0;
        int studentMath = 0;
        public Student_StructForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            studentName = txtName.Text;
            studentChi = int.Parse(txtChinese.Text);
            studentEng = int.Parse(txtEnglish.Text);
            studentMath = int.Parse(txtMath.Text);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            labScoreName.Text = "姓名: " + studentName;
            labScoreChi.Text = "國文: " + studentChi;
            labScoreEng.Text = "英文: " + studentEng;
            labScoreMath.Text = "數學: " + studentMath;

        }

        private void btnHighestLowest_Click(object sender, EventArgs e)
        {
            int[] subject = { studentChi, studentEng, studentMath };
            int max;
            int low;
            max = subject.Max();
            low = subject.Min();

            if (max == studentMath)
            {
                labHighestScore.Text = "最高成績為 : 數學" + studentMath + "分";                
            }
            else if (max == studentChi)
            {
                labHighestScore.Text = "最高成績為 : 國文" + studentChi + "分";
            }
            else
            {
                labHighestScore.Text = "最高成績為 : 英文" + studentEng + "分";
            }
            if (low == studentMath)
            {
                labLowestScore.Text = "最低成績為 : 數學" + studentMath + "分";
            }
            else if (low == studentChi)
            {
                labLowestScore.Text = "最低成績為 : 國文" + studentChi + "分";
            }
            else
            {
                labLowestScore.Text = "最低成績為 : 英文" + studentEng + "分";
            }



        }
    }
}

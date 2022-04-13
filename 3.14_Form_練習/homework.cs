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
    public partial class homework : Form
    {
        public homework()
        {
            InitializeComponent();
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer2.Panel1.AutoScroll = true;
            splitContainer2.Panel2.AutoScroll = true;
        }

        private void btnhello_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
           HelloForm hellofrm = new HelloForm();
            hellofrm.TopLevel = false;
            hellofrm.Visible = true;
            splitContainer2.Panel2.Controls.Add(hellofrm);
        }

        private void btnloan_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Loan loan = new Loan();
            loan.TopLevel = false;
            loan.Visible = true;
            splitContainer2.Panel2.Controls.Add(loan);
        }

        private void btnStudentStructForm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Student_StructForm studentStructForm = new Student_StructForm();
            studentStructForm.TopLevel = false;
            studentStructForm.Visible = true;
            splitContainer2.Panel2.Controls.Add(studentStructForm);
        }

        private void btnMyCalculator_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            MyCalculator myCalculator = new MyCalculator();
            myCalculator.TopLevel = false;
            myCalculator.Visible = true;
            splitContainer2.Panel2.Controls.Add(myCalculator);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            POS pos = new POS();
            pos.TopLevel = false;
            pos.Visible = true;
            splitContainer2.Panel2.Controls.Add(pos);
        }

        private void btn小畫家_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            小畫家 小畫家 = new 小畫家();
            小畫家.TopLevel = false;
            小畫家.Visible = true;
            splitContainer2.Panel2.Controls.Add(小畫家);
        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            StudentGrade studentgrade = new StudentGrade();
            studentgrade.TopLevel = false;
            studentgrade.Visible = true;
            splitContainer2.Panel2.Controls.Add(studentgrade);
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            XOGame xogame = new XOGame();
            xogame.TopLevel = false;
            xogame.Visible = true;
            splitContainer2.Panel2.Controls.Add(xogame);
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Screen_Saver screen_Saver = new Screen_Saver();
            screen_Saver.Show();
            
        }

        private void btnNotePad_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            NotePad notePad = new NotePad();
            notePad.TopLevel = false;
            notePad.Visible = true;
            splitContainer2.Panel2.Controls.Add(notePad);
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Method method = new Method();
            method.TopLevel = false;
            method.Visible = true;
            splitContainer2.Panel2.Controls.Add(method);
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            ForDoWhile forDoWhile = new ForDoWhile();
            forDoWhile.TopLevel = false;
            forDoWhile.Visible = true;
            splitContainer2.Panel2.Controls.Add(forDoWhile);
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            PictureViewer pictureViewer = new PictureViewer();
            pictureViewer.TopLevel = false;
            pictureViewer.Visible = true;
            splitContainer2.Panel2.Controls.Add(pictureViewer);
        }

        private void btn考試Guess_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            考試_Guess guess = new 考試_Guess();
            guess.TopLevel = false;
            guess.Visible = true;
            splitContainer2.Panel2.Controls.Add(guess);
        }

        private void btn考試Alarm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            考試_Alarm alarm = new 考試_Alarm();
            alarm.TopLevel = false;
            alarm.Visible = true;
            splitContainer2.Panel2.Controls.Add(alarm);
        }

        private void btnStudentGradeList_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            StudentGrade_List list = new StudentGrade_List();
            list.TopLevel = false;
            list.Visible = true;
            splitContainer2.Panel2.Controls.Add(list);
        }
    }
}

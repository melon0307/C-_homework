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
    public partial class 考試_Guess : Form
    {
        Random rd = new Random();
        public int answer;
        public bool newAnswer;
        public Label lab;
        public 考試_Guess()
        {
            InitializeComponent();            
            answer = rd.Next(0, 101);
            newAnswer = false;
            lab = new Label();
            this.lab.Text = "Please Select A Number Between 1 to 100!";
            this.lab.AutoSize = true;
            this.lab.Font = new Font("微軟正黑體", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(136)));
            this.lab.Location = new Point(50, 100);
            this.Controls.Add(lab);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (newAnswer)
            {
                answer = rd.Next(1, 101);
            }
            else { }
            考試_Guess2 B = new 考試_Guess2(answer);
            B.Owner = this;
            B.ShowDialog();
        }

        private void btnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer : "+answer.ToString());
            newAnswer = true;
        }
    }
}

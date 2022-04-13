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
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }
                      

        private void btmSayHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Sex = txtSex.Text;
            string Conste = txtConstellation.Text;
            MessageBox.Show("hello!,我是," + Name
                + "\n"+"英文名字是,"+EngName
                + "\n"+"性別是,"+Sex
                + "\n"+"星座是"+Conste
                + "\n"+"很高興認識你!") ;
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Sex = txtSex.Text;
            string Conste = txtConstellation.Text;
            MessageBox.Show("hi,我是," + Name
                + "\n" + "英文名字是," + EngName
                + "\n" + "性別是," + Sex
                + "\n" + "星座是" + Conste
                + "\n" + "很高興認識你!");
        }
    }
}

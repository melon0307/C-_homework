﻿using System;
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
    public partial class PictureViewer2 : Form
    {
        public PictureViewer2(PictureBox p)
        {
            InitializeComponent();
           pictureBox1.Image = p.Image;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCreoView
{
    public partial class FormPicture : Form
    {
        public FormPicture()
        {
            InitializeComponent();
            InitializePic();
        }

        protected void InitializePic()
        {
            this.pictureBox1.Load(@"..\..\image\GB5786-A.jpg");
        }
    }
}
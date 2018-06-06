﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace TestCreoView
{
    public partial class FormListEquipment : ToolWindow
    {
        public string toolWindowName
        {
            set
            {
                this.Text = value;
                this.TabText = value;
            }
            get { return this.TabText; }
        }
        public FormListEquipment()
        {
            InitializeComponent();
            toolWindowName = "工具工装清单";
        }
    }
}

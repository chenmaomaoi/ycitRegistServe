﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistServe.DB.Domain;

namespace RegistServe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //todo:新建用户
            FormAdd add = new FormAdd();

            if (add.ShowDialog(this) == DialogResult.OK)
            {
                
            }
            else
            {

            }

        }
    }
}
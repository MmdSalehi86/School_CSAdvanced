﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoool
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudent frm = new FrmStudent();
            frm.StudentInserted += Frm_StudentInserted;
        }

        private void Frm_StudentInserted(School.BLL.StudentDto studentDto)
        {
            button1.Text = studentDto.FirstName + " ثبت شد ";
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperationQADDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
            if (checkBox3.Checked)
                MessageBox.Show("OK");
            MessageBox.Show("123《");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

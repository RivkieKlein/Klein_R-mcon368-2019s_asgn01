﻿using EligibilityLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
          Boolean eligible=  Class1.eligible(checkBox1.Checked, Convert.ToInt16(textBox1.Text) , Convert.ToInt16(textBox2.Text), checkBox2.Checked);

            if (eligible)
            {
                label3.Text = "You are eligible to run for president";
            }
            else
            {
                label3.Text = "You are not eligible to run for president";
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double resistance1 = double.Parse(textBox1.Text);
                double resistance2 = double.Parse(textBox2.Text);
                double resistance3 = double.Parse(textBox3.Text);
                double resistance4 = double.Parse(textBox4.Text);
                double resistance5 = double.Parse(textBox5.Text);

                double Total_Resistance = resistance1 + resistance2 + resistance3 + resistance4 + resistance5;
                MessageBox.Show("Total_Resistance = " + Total_Resistance.ToString("0.00") + "ohms");

            }
            catch
            {
                MessageBox.Show("Error interpreting values");
            }
        }
  



        }
    }


  
  




﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Display Form1
            form1.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void right_Click(object sender, EventArgs e)
        {

        }

        private void left_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

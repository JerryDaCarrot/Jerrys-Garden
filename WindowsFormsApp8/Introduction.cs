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
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation();

            // Display Form1
            navigation.Show();

            // Hide the current form (optional)
            this.Hide();
        }
    }
}
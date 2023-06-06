using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible= false;
            button3.Visible= false;
            button4.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible= false;
            button2.Visible = true;

            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Display Form2
            form2.Show();

            // Hide the current form (optional)
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible=false;
            button3.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible= false;
            button4.Visible= true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {

        }
    }
}

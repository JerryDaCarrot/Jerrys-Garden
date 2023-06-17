using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            int count = 1;
            if (count != 1)
            {
                button1.Visible = false;
                button2.Visible = true;
            }
                

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

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            int stepSize = 10; // Define the distance to move the label on each key press

            // Check which arrow key is pressed
            switch (e.KeyCode)
            {
                case Keys.Up:
                    carrot.Top -= stepSize;
                    break;
                case Keys.Down:
                    carrot.Top += stepSize;
                    break;
                case Keys.Left:
                    carrot.Left -= stepSize;
                    break;
                case Keys.Right:
                    carrot.Left += stepSize;
                    break;
            }
        }

    }
}

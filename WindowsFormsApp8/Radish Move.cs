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
    public partial class Radish_Move : Form
    {
        public Radish_Move()
        {
            InitializeComponent();

            // Create a picture box and add it to the form
            JerryRadish = new PictureBox
            {
                Image = Properties.Resources.jerryRadish, // Set your desired image
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new System.Drawing.Point(100, 100) // Set initial position
            };
            Controls.Add(JerryRadish);

            // Register the KeyDown event handler
            KeyDown += RadishMove_KeyDown;
        }

      

        private void RadishMove_KeyDown(object sender, KeyEventArgs e)
        {
            const int moveAmount = 10; // Amount to move the picture box

            // Update the location of the picture box based on the arrow key pressed
            switch (e.KeyCode)
            {
                case Keys.Left:
                    JerryRadish.Left -= moveAmount;
                    break;
                case Keys.Right:
                    JerryRadish.Left += moveAmount;
                    break;
                case Keys.Up:
                    JerryRadish.Top -= moveAmount;
                    break;
                case Keys.Down:
                    JerryRadish.Top += moveAmount;
                    break;
            }
        }



        private void PictureBox1_LocationChanged(object sender, EventArgs e)
        {
            if (JerryRadish.Location == new Point(408, 101))
            {
                // Create an instance of Form2
                Radish_Seeds radishSeeds = new Radish_Seeds();

                // Display Form2
                radishSeeds.Show();

                // Hide the current form (optional)
                this.Hide();
            }
        }

       


        private void RadishSeeds_Click(object sender, EventArgs e)
        {

        }

    }
}

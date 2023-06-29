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
    public partial class RadishMove : Form
    {
        public RadishMove()
        {
            InitializeComponent();

            // Create a picture box and add it to the form
            jerryRadish = new PictureBox();
            jerryRadish.Image = Properties.Resources.CarrotS; // Set your desired image
            jerryRadish.SizeMode = PictureBoxSizeMode.AutoSize;
            jerryRadish.Location = new System.Drawing.Point(100, 100); // Set initial position
            Controls.Add(jerryRadish);

            // Register the KeyDown event handler
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            const int moveAmount = 10; // Amount to move the picture box

            // Update the location of the picture box based on the arrow key pressed
            switch (e.KeyCode)
            {
                case Keys.Left:
                    jerryRadish.Left -= moveAmount;
                    break;
                case Keys.Right:
                    jerryRadish.Left += moveAmount;
                    break;
                case Keys.Up:
                    jerryRadish.Top -= moveAmount;
                    break;
                case Keys.Down:
                    jerryRadish.Top += moveAmount;
                    break;
            }

            Radish_Seeds radishSeeds = new Radish_Seeds();


            // Check if the carrot reaches the target rectangular area
            if (IsCarrotSInTargetArea())
            {
                // Display the new form
                radishSeeds.Show();

            }
        }

        private bool IsCarrotSInTargetArea()
        {
            Rectangle targetRectangle = new Rectangle(407, 182, 139, 74); // Define the target rectangular area

            // Check if the carrot's bounds intersect with the target rectangle
            return targetRectangle.IntersectsWith(jerryRadish.Bounds);
        }

        private void RadishMove_Load(object sender, EventArgs e)
        {

        }
    }
}

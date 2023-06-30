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
            
            jerryRadish.Image = Properties.Resources.CarrotS; // Set your desired image
            jerryRadish.Size = new Size(50, 100);
            jerryRadish.SizeMode = PictureBoxSizeMode.AutoSize;
            jerryRadish.Location = new Point(100, 100);
            jerryRadish.BackColor = Color.Transparent;
            Controls.Add(jerryRadish);

            seeds.Location = new Point(407, 182);
            seeds.Paint += PictureBox_Paint;
            Controls.Add(seeds);

            // Register the KeyDown event handler
            KeyDown += Form1_KeyDown;
            this.Focus();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.MediumSpringGreen, 0, 0, seeds.Width - 1, seeds.Height - 1);
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

            if (seeds.Bounds.Contains(jerryRadish.Location))
            {
                radishSeeds.Show();
                this.Hide();
            }


        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using WindowsFormsApp8;

namespace WindowsFormsApp8
{
    public partial class Cucumber_Move : Form
    {
        public Cucumber_Move()
        {
            InitializeComponent();
            // Create a picture box and add it to the form

            jerryCucumber.Image = Properties.Resources.CarrotT; // Set your desired image
            jerryCucumber.Size = new Size(50, 100); //Set size
            jerryCucumber.SizeMode = PictureBoxSizeMode.AutoSize;
            jerryCucumber.Location = new Point(100, 100); //where carrot starts
            jerryCucumber.BackColor = Color.Transparent;
            Controls.Add(jerryCucumber);

            seeds.Location = new Point(407, 182); //location of seeds
            seeds.Paint += PictureBox_Paint;
            Controls.Add(seeds);

            // Register the KeyDown event handler
            KeyDown += Form1_KeyDown;
            this.Focus();
            this.KeyPreview = true;

            Load += CucumberMove_Load;

            cucumberSeedsForm = new Cucumber_Seeds(this); // Initialize cucumberSeedsForm
        }

        private Cucumber_Seeds cucumberSeedsForm;

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.DarkSeaGreen, 0, 0, seeds.Width - 1, seeds.Height - 1); //put box around seeds
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            const int moveAmount = 10; // Amount to move the picture box

            // Update the location of the picture box based on the arrow key pressed
            switch (e.KeyCode)
            {
                case Keys.Left:
                    jerryCucumber.Left -= moveAmount;
                    CheckButtonCollision(); //see if jerryCucumber has collided with the picturebox
                    break;
                case Keys.Right:
                    jerryCucumber.Left += moveAmount;
                    CheckButtonCollision(); //see if jerryCucumber has collided with the picturebox
                    break;
                case Keys.Up:
                    jerryCucumber.Top -= moveAmount;
                    CheckButtonCollision(); //see if jerryCucumber has collided with the picturebox
                    break;
                case Keys.Down:
                    jerryCucumber.Top += moveAmount;
                    CheckButtonCollision(); //see if jerryCucumber has collided with the picturebox
                    break;
            }
        }

        private void CheckButtonCollision()
        {
            Cucumber_Seeds cucumber = new Cucumber_Seeds();

            if (seeds.Visible && jerryCucumber.Bounds.IntersectsWith(new Rectangle(new Point(407, 182), new Size(139, 167))))
            {
                Cucumber_Seeds cucumberSeeds = new Cucumber_Seeds(this); // Pass the instance of CucumberMove

                //open the seeds page
                cucumberSeeds.Show();
                this.Hide();

                //update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = true;
                grow.Visible = false;
                grown.Visible = false;
            }
            else if (maintain.Visible && jerryCucumber.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                cucumberSeedsForm.Show();
                Cucumber_Seeds cucumberSeeds = new Cucumber_Seeds(this); // Pass the instance of CucumberMove

                //open the seeds page
                cucumberSeeds.Show();
                this.Hide();

                //update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = true;
                grown.Visible = false;
            }
            else if (grow.Visible && jerryCucumber.Bounds.IntersectsWith(new Rectangle(new Point(146, 500), new Size(182, 167))))
            {
                cucumberSeedsForm.Show();
                Cucumber_Seeds cucumberSeeds = new Cucumber_Seeds(this); // Pass the instance of CucumberMove

                //open the seeds page
                cucumberSeeds.Show();
                this.Hide();

                //update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = true;
            }
            else if (grown.Visible && jerryCucumber.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                cucumberSeedsForm.Show();
                Cucumber_Seeds cucumberSeeds = new Cucumber_Seeds(this); // Pass the instance of CucumberMove

                //open the seeds page
                cucumberSeeds.Show();
                this.Hide();

                //update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = false;
            }
        }

        public void CucumberMove_Load(object sender, EventArgs e)
        {
            Cucumber_Seeds cucumberSeeds = new Cucumber_Seeds();

            // Check if the carrot reaches the target rectangular area
            if (IsCarrotSInTargetArea())
            {
                // Display the new form
                cucumberSeeds.Show();
                this.Hide();
            }

            this.KeyDown += Form1_KeyDown;
        }

        public bool IsCarrotSInTargetArea()
        {
            Rectangle seedsRegion = new Rectangle(407, 182, 139, 74);

            // Check if the carrot's bounds intersect with the target rectangle
            return seedsRegion.IntersectsWith(jerryCucumber.Bounds);
        }

        private void Cucumber_Move_Load(object sender, EventArgs e)
        {

        }
    }
}

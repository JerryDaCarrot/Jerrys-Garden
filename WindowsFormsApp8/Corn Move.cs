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
    public partial class Corn_Move : Form
    {
        public Corn_Move()
        {
            InitializeComponent();
            // Create a picture box and add it to the form

            jerryCorn.Image = Properties.Resources.CarrotS; // Set your desired image
            jerryCorn.Size = new Size(50, 100); //Set size
            jerryCorn.SizeMode = PictureBoxSizeMode.AutoSize;
            jerryCorn.Location = new Point(100, 100); //where carrot starts
            jerryCorn.BackColor = Color.Transparent;
            Controls.Add(jerryCorn);

            seeds.Location = new Point(407, 182); //location of seeds
            seeds.Paint += PictureBox_Paint;
            Controls.Add(seeds);

            // Register the KeyDown event handler
            KeyDown += Form1_KeyDown;
            this.Focus();
            this.KeyPreview = true;

            Load += CornMove_Load;

            cornSeedsForm = new Corn_Seeds(this); // Initialize cornSeedsForm
        }

        private Corn_Seeds cornSeedsForm;

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
                    jerryCorn.Left -= moveAmount;
                    CheckButtonCollision(); //see if jerryCorn has collided with the picturebox
                    break;
                case Keys.Right:
                    jerryCorn.Left += moveAmount;
                    CheckButtonCollision(); //see if jerryCorn has collided with the picturebox
                    break;
                case Keys.Up:
                    jerryCorn.Top -= moveAmount;
                    CheckButtonCollision(); //see if jerryCorn has collided with the picturebox
                    break;
                case Keys.Down:
                    jerryCorn.Top += moveAmount;
                    CheckButtonCollision(); //see if jerryCorn has collided with the picturebox
                    break;
            }
        }

        private void CheckButtonCollision()
        {
            if (jerryCorn.Bounds.IntersectsWith(new Rectangle(new Point(1215, 614), new Size(139, 167))))
            {
                Corn_Seeds cornSeedsForm = new Corn_Seeds();
                // Open the seeds page
                cornSeedsForm.Show();
                this.Visible = false;

                // Update which picture box is visible
                seeds.Visible = false;
                maintain.Visible = true;
                grow.Visible = false;
                grown.Visible = false;

                // Reset the location of jerryCorn
                jerryCorn.Location = new Point(100, 100);
            }
            else if (maintain.Visible && jerryCorn.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                cornSeedsForm.Show();
                this.Visible = false;

                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = true;
                grown.Visible = false;

                jerryCorn.Location = new Point(100, 100);
            }
            else if (grow.Visible && jerryCorn.Bounds.IntersectsWith(new Rectangle(new Point(146, 500), new Size(182, 167))))
            {
                cornSeedsForm.Show();
                this.Visible = false;

                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = true;

                jerryCorn.Location = new Point(100, 100);
            }
            else if (grown.Visible && jerryCorn.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                cornSeedsForm.Show();
                this.Visible = false;

                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = false;

                jerryCorn.Location = new Point(100, 100);
            }
        }


        public void CornMove_Load(object sender, EventArgs e)
        {
            Corn_Seeds cornSeeds = new Corn_Seeds();

            // Check if the carrot reaches the target rectangular area
            if (IsCarrotSInTargetArea())
            {
                // Display the new form
                cornSeeds.Show();
                this.Hide();
            }

            this.KeyDown += Form1_KeyDown;
        }

        public bool IsCarrotSInTargetArea()
        {
            Rectangle seedsRegion = new Rectangle(407, 182, 139, 74);

            // Check if the carrot's bounds intersect with the target rectangle
            return seedsRegion.IntersectsWith(jerryCorn.Bounds);
        }

        private void Corn_Move_Load(object sender, EventArgs e)
        {
        }


    }
}

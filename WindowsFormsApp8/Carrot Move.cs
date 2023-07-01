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
    public partial class Carrot_Move : Form
    {
        public Carrot_Move()
        {
            InitializeComponent();

            jerryCarrot.Image = Properties.Resources.CarrotT; // Set your desired image
            jerryCarrot.Size = new Size(50, 100); //Set size
            jerryCarrot.SizeMode = PictureBoxSizeMode.AutoSize;
            jerryCarrot.Location = new Point(100, 100); //where carrot starts
            jerryCarrot.BackColor = Color.Transparent;
            Controls.Add(jerryCarrot);

            seeds.Location = new Point(407, 182); //location of seeds
            seeds.Paint += PictureBox_Paint;
            Controls.Add(seeds);

            // Register the KeyDown event handler
            KeyDown += CarrotMove_KeyDown;
            this.Focus();
            this.KeyPreview = true;

            Load += CarrotMove_Load;

            carrotSeedsForm = new Carrot_Seeds(this); // Initialize carrotSeedsForm
        }

        private Carrot_Seeds carrotSeedsForm;

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.DarkSeaGreen, 0, 0, seeds.Width - 1, seeds.Height - 1); //put box around seeds
        }

        private void CarrotMove_KeyDown(object sender, KeyEventArgs e)
        {
            const int moveAmount = 10; // Amount to move the picture box

            // Update the location of the picture box based on the arrow key pressed
            switch (e.KeyCode)
            {
                case Keys.Left:
                    jerryCarrot.Left -= moveAmount;
                    CheckButtonCollision(); //see if jerryCarrot has collided with the picturebox
                    break;
                case Keys.Right:
                    jerryCarrot.Left += moveAmount;
                    CheckButtonCollision(); //see if jerryCarrot has collided with the picturebox
                    break;
                case Keys.Up:
                    jerryCarrot.Top -= moveAmount;
                    CheckButtonCollision(); //see if jerryCarrot has collided with the picturebox
                    break;
                case Keys.Down:
                    jerryCarrot.Top += moveAmount;
                    CheckButtonCollision(); //see if jerryCarrot has collided with the picturebox
                    break;
            }
        }

        private void CheckButtonCollision()
        {
            Carrot_Seeds carrot = new Carrot_Seeds();

            if (seeds.Visible && jerryCarrot.Bounds.IntersectsWith(new Rectangle(new Point(407, 182), new Size(139, 167))))
            {
                Carrot_Seeds carrotSeeds = new Carrot_Seeds(this); // Pass the instance of CarrotMove

                // Open the seeds page
                carrotSeeds.Show();
                this.Hide();

                // Update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = true;
                grow.Visible = false;
                grown.Visible = false;
            }
            else if (maintain.Visible && jerryCarrot.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                carrotSeedsForm.Show();
                Carrot_Seeds carrotSeeds = new Carrot_Seeds(this); // Pass the instance of CarrotMove

                // Open the seeds page
                carrotSeeds.Show();
                this.Hide();

                // Update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = true;
                grown.Visible = false;
            }
            else if (grow.Visible && jerryCarrot.Bounds.IntersectsWith(new Rectangle(new Point(146, 500), new Size(182, 167))))
            {
                carrotSeedsForm.Show();
                Carrot_Seeds carrotSeeds = new Carrot_Seeds(this); // Pass the instance of CarrotMove

                // Open the seeds page
                carrotSeeds.Show();
                this.Hide();

                // Update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = true;
            }
            else if (grown.Visible && jerryCarrot.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                carrotSeedsForm.Show();
                Carrot_Seeds carrotSeeds = new Carrot_Seeds(this); // Pass the instance of CarrotMove

                // Open the seeds page
                carrotSeeds.Show();
                this.Hide();

                // Update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = false;
            }
        }

        public void CarrotMove_Load(object sender, EventArgs e)
        {
            Carrot_Seeds carrotSeeds = new Carrot_Seeds();

            // Check if the carrot reaches the target rectangular area
            if (IsCarrotInTargetArea())
            {
                // Display the new form
                carrotSeeds.Show();
                this.Hide();
            }

            this.KeyDown += CarrotMove_KeyDown;
        }

        public bool IsCarrotInTargetArea()
        {
            Rectangle seedsRegion = new Rectangle(407, 182, 139, 74);

            // Check if the carrot's bounds intersect with the target rectangle
            return seedsRegion.IntersectsWith(jerryCarrot.Bounds);
        }
    }
}

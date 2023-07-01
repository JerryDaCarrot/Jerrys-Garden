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
    public partial class Tomato_Move : Form
    {
        public Tomato_Move()
        {
            InitializeComponent();

            jerryTomato.Image = Properties.Resources.CarrotT; // Set your desired image
            jerryTomato.Size = new Size(50, 100); // Set size
            jerryTomato.SizeMode = PictureBoxSizeMode.AutoSize;
            jerryTomato.Location = new Point(100, 100); // Where tomato starts
            jerryTomato.BackColor = Color.Transparent;
            Controls.Add(jerryTomato);

            seeds.Location = new Point(407, 182); // Location of seeds
            seeds.Paint += PictureBox_Paint;
            Controls.Add(seeds);

            // Register the KeyDown event handler
            KeyDown += TomatoMove_KeyDown;
            this.Focus();
            this.KeyPreview = true;

            Load += TomatoMove_Load;

            tomatoSeedsForm = new Tomato_Seeds(this); // Initialize tomatoSeedsForm
        }

        private Tomato_Seeds tomatoSeedsForm;

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.DarkSeaGreen, 0, 0, seeds.Width - 1, seeds.Height - 1); // Put box around seeds
        }

        private void TomatoMove_KeyDown(object sender, KeyEventArgs e)
        {
            const int moveAmount = 10; // Amount to move the picture box

            // Update the location of the picture box based on the arrow key pressed
            switch (e.KeyCode)
            {
                case Keys.Left:
                    jerryTomato.Left -= moveAmount;
                    CheckButtonCollision(); // See if jerryTomato has collided with the picturebox
                    break;
                case Keys.Right:
                    jerryTomato.Left += moveAmount;
                    CheckButtonCollision(); // See if jerryTomato has collided with the picturebox
                    break;
                case Keys.Up:
                    jerryTomato.Top -= moveAmount;
                    CheckButtonCollision(); // See if jerryTomato has collided with the picturebox
                    break;
                case Keys.Down:
                    jerryTomato.Top += moveAmount;
                    CheckButtonCollision(); // See if jerryTomato has collided with the picturebox
                    break;
            }
        }

        private void CheckButtonCollision()
        {
            Tomato_Seeds tomato = new Tomato_Seeds();

            if (seeds.Visible && jerryTomato.Bounds.IntersectsWith(new Rectangle(new Point(407, 182), new Size(139, 167))))
            {
                Tomato_Seeds tomatoSeeds = new Tomato_Seeds(this); // Pass the instance of Tomato_Move

                // Open the seeds page
                tomatoSeeds.Show();
                this.Hide();

                // Update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = true;
                grow.Visible = false;
                grown.Visible = false;
            }
            else if (maintain.Visible && jerryTomato.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                tomatoSeedsForm.Show();
                Tomato_Seeds tomatoSeeds = new Tomato_Seeds(this); // Pass the instance of Tomato_Move

                // Open the seeds page
                tomatoSeeds.Show();
                this.Hide();

                // Update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = true;
                grown.Visible = false;
            }
            else if (grow.Visible && jerryTomato.Bounds.IntersectsWith(new Rectangle(new Point(146, 500), new Size(182, 167))))
            {
                tomatoSeedsForm.Show();
                Tomato_Seeds tomatoSeeds = new Tomato_Seeds(this); // Pass the instance of Tomato_Move

                // Open the seeds page
                tomatoSeeds.Show();
                this.Hide();

                // Update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = true;
            }
            else if (grown.Visible && jerryTomato.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                tomatoSeedsForm.Show();
                Tomato_Seeds tomatoSeeds = new Tomato_Seeds(this); // Pass the instance of Tomato_Move

                // Open the seeds page
                tomatoSeeds.Show();
                this.Hide();

                // Update which picturebox is visible
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = false;
            }
        }

        public void TomatoMove_Load(object sender, EventArgs e)
        {
            Tomato_Seeds tomatoSeeds = new Tomato_Seeds();

            // Check if the tomato reaches the target rectangular area
            if (IsTomatoInTargetArea())
            {
                // Display the new form
                tomatoSeeds.Show();
                this.Hide();
            }

            this.KeyDown += TomatoMove_KeyDown;
        }

        public bool IsTomatoInTargetArea()
        {
            Rectangle seedsRegion = new Rectangle(407, 182, 139, 74);

            // Check if the tomato's bounds intersect with the target rectangle
            return seedsRegion.IntersectsWith(jerryTomato.Bounds);
        }
    }
}

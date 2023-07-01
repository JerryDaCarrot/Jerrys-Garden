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

            Load += RadishMove_Load;

            radishSeedsForm = new Radish_Seeds(this); // Initialize radishSeedsForm

        }

        private Radish_Seeds radishSeedsForm;

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.DarkSeaGreen, 0, 0, seeds.Width - 1, seeds.Height - 1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            const int moveAmount = 10; // Amount to move the picture box

            // Update the location of the picture box based on the arrow key pressed
            switch (e.KeyCode)
            {
                case Keys.Left:
                    jerryRadish.Left -= moveAmount;
                    CheckButtonCollision();
                    break;
                case Keys.Right:
                    jerryRadish.Left += moveAmount;
                    CheckButtonCollision();
                    break;
                case Keys.Up:
                    jerryRadish.Top -= moveAmount;
                    CheckButtonCollision();
                    break;
                case Keys.Down:
                    jerryRadish.Top += moveAmount;
                    CheckButtonCollision();
                    break;
            }

        }

        

        private void CheckButtonCollision()

        {
            

            Radish_Seeds radish = new Radish_Seeds();

            if (seeds.Visible && jerryRadish.Bounds.IntersectsWith(new Rectangle(new Point(407, 182), new Size(139, 167))))
            {
                radishSeedsForm.Show();
                Radish_Seeds radishSeeds = new Radish_Seeds(this); // Pass the instance of RadishMove
                radishSeeds.Show();
                this.Hide();
                seeds.Visible = false;
                maintain.Visible = true;
                grow.Visible = false;
                grown.Visible = false;
            }
            else if (maintain.Visible && jerryRadish.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                radishSeedsForm.Show();
                Radish_Seeds radishSeeds = new Radish_Seeds(this); // Pass the instance of RadishMove
                radishSeeds.Show();
                this.Hide();
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = true;
                grown.Visible = false;
            }
            else if (grow.Visible && jerryRadish.Bounds.IntersectsWith(new Rectangle(new Point(146, 500), new Size(182, 167))))
            {
                radishSeedsForm.Show();
                Radish_Seeds radishSeeds = new Radish_Seeds(this); // Pass the instance of RadishMove
                radishSeeds.Show();
                this.Hide();
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = true;
            }
            else if (grown.Visible && jerryRadish.Bounds.IntersectsWith(new Rectangle(new Point(953, 626), new Size(139, 167))))
            {
                radishSeedsForm.Show();
                Radish_Seeds radishSeeds = new Radish_Seeds(this); // Pass the instance of RadishMove
                radishSeeds.Show();
                this.Hide();
                seeds.Visible = false;
                maintain.Visible = false;
                grow.Visible = false;
                grown.Visible = false;
            }
        }


        public void RadishMove_Load(object sender, EventArgs e)
        {
            Radish_Seeds radishSeeds = new Radish_Seeds();

            // Check if the carrot reaches the target rectangular area
            if (IsCarrotSInTargetArea())
            {
                // Display the new form
                radishSeeds.Show();
                this.Hide();

            }
        }

        public bool IsCarrotSInTargetArea()
        {
            Rectangle seedsRegion = new Rectangle(407, 182, 139, 74);

            // Check if the carrot's bounds intersect with the target rectangle
            return seedsRegion.IntersectsWith(jerryRadish.Bounds);
        }

    }
}


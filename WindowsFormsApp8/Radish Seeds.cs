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
    public partial class Radish_Seeds : Form

        //private PictureBox ;
        //private List<Image> "" = new List<Image>();
        //private int currentImageIndex = 0;


    {



        public Radish_Seeds(RadishMove radishMoveForm)
        {
            this.radishMoveForm = radishMoveForm;
            InitializeComponent();
        }

        public Radish_Seeds()
        {
            
            InitializeComponent();
            LoadImages();
            UpdatePictureBox();
        }

        private void Radish_Seeds_Load(object sender, EventArgs e)
        {

        }

        private List<Image> images = new List<Image>();  // List to hold the images
        private int currentImageIndex = 0;  // Index of the currently displayed image

        private void LoadImages()
        {
            images = new List<Image>
            {
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\RadishSeeds.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\RadishMaintain.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\RadishGrow.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\RadishGrown.png")
            };
        }

        private void left_Click(object sender, EventArgs e)
        {
            currentImageIndex--;
            if (currentImageIndex < 0)
            {
                currentImageIndex = images.Count - 1;
            }

            UpdatePictureBox();
        }

        private void right_Click(object sender, EventArgs e)
        {
            currentImageIndex++;
            if (currentImageIndex >= images.Count)
            {
                currentImageIndex = 0; // Wrap around to the first image if at the end of the list
            }

            // Display the new image
            Information.Image = images[currentImageIndex];
        }

        private void UpdatePictureBox()
        {
            Information.Image = images[currentImageIndex];
        }

        RadishMove radishMoveForm = new RadishMove();
        private void exit_Click(object sender, EventArgs e)
        {

            radishMoveForm.Show();
            this.Hide();

        }



    }
}

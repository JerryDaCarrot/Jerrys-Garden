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
    {
        public Radish_Seeds()
        {
            InitializeComponent();
        }

        private void Radish_Seeds_Load(object sender, EventArgs e)
        {

        }

        private List<Image> images = new List<Image>();  // List to hold the images
        private int currentIndex = 0;  // Index of the currently displayed image

        private void LoadImages()
        {
            // Load your images and add them to the list
            images.Add(Image.FromFile("image1.jpg"));
            images.Add(Image.FromFile("image2.jpg"));
            images.Add(Image.FromFile("image3.jpg"));
            // Add as many images as needed

            // Set the initial image to be displayed
            Information.Image = images[currentIndex];
        }

        private void left_Click(object sender, EventArgs e)
        {
            // Decrement the index to display the previous image
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = images.Count - 1; // Wrap around to the last image if at the beginning of the list
            }

            // Display the new image
            Information.Image = images[currentIndex];
        }

        private void right_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Count)
            {
                currentIndex = 0; // Wrap around to the first image if at the end of the list
            }

            // Display the new image
            Information.Image = images[currentIndex];
        }

        private void exit_Click(object sender, EventArgs e)
        {

        }
    }
}

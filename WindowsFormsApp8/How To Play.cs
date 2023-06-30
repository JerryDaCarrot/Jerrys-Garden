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
    public partial class How_To_Play : Form
    {
        public How_To_Play()
        {
            InitializeComponent();
            LoadImages();
            UpdatePictureBox();
        }
        private void How_To_Play_Load(object sender, EventArgs e)
        {

        }

        private List<Image> images = new List<Image>();  // List to hold the images
        private int currentImageIndex = 0;  // Index of the currently displayed image

        private void LoadImages()
        {
            images = new List<Image>
            {
                //Images that will fill the picturebox
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\HTP1.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\HTP2.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\HTP3.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\HTP4.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\HTP5.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\HTP6.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\HTP7.png")
            };
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            
            currentImageIndex--;
            if (currentImageIndex < 0)
            {
                currentImageIndex = images.Count - 1;
            }

            UpdatePictureBox();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            currentImageIndex++;
            if (currentImageIndex >= images.Count)
            {
                currentImageIndex = 0; // Wrap around to the first image if at the end of the list
            }

            // Display the new image
            HowToPlay.Image = images[currentImageIndex];
        }

        private void UpdatePictureBox()
        {
            HowToPlay.Image = images[currentImageIndex];
        }


        private void Finish_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation();

            // Display Form1
            navigation.Show();

            // Hide the current form (optional)
            this.Hide();
        }
    }
}

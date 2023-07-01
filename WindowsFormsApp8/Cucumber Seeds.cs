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

namespace WindowsFormsApp8
{
    public partial class Cucumber_Seeds : Form
    {
        private Cucumber_Move cucumberMoveForm;


        public Cucumber_Seeds(Cucumber_Move cucumberMoveForm)
        {
            this.cucumberMoveForm = cucumberMoveForm;
            InitializeComponent();
            LoadImages();
            UpdatePictureBox();
        }

        public Cucumber_Seeds(string progressFilePath)
        {
        }

        public Cucumber_Seeds()
        {
        }

        private void Cucumber_Seeds_Load(object sender, EventArgs e)
        {

        }

        private List<Image> images = new List<Image>();  // List to hold the images
        private int currentImageIndex = 0;  // Index of the currently displayed image

        private void LoadImages()
        {
            images = new List<Image>
            {
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\CucumberSeeds.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\CucumberMaintain.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\CucumberGrow.png"),
                Image.FromFile("C:\\Users\\pc\\source\\repos\\WindowsFormsApp8\\WindowsFormsApp8\\Resources\\CucumberGrown.png")
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

        public bool IsExitButtonPressed { get; private set; }
        private void exit_Click(object sender, EventArgs e)
        {
            Levels levels = new Levels();
            IsExitButtonPressed = true;
            levels.Show();
            this.Hide();

            // Set the level 1 as completed in the player_progress.txt file
            string progressFilePath = "player_progress.txt";
            File.AppendAllText(progressFilePath, "Level2" + Environment.NewLine);

            if (!string.IsNullOrEmpty(progressFilePath))
            {
                File.AppendAllText(progressFilePath, "Level2" + Environment.NewLine);
            }

        }
    }
}

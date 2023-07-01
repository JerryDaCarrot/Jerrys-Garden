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
    public partial class Levels : Form
    {
        private List<string> completedLevels;
        private string progressFilePath = "player_progress.txt";

        public Levels()
        {
            InitializeComponent();
            completedLevels = new List<string>();
            LoadPlayerProgress();
            UpdateLevelSelectionUI();
        }

        private void LevelSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePlayerProgress();
        }

        private void LoadPlayerProgress()
        {
            if (File.Exists(progressFilePath))
            {
                try
                {
                    string[] progressData = File.ReadAllLines(progressFilePath);
                    completedLevels.AddRange(progressData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading player progress: " + ex.Message);
                }
            }
        }


        private void SavePlayerProgress()
        {
            try
            {
                File.WriteAllLines(progressFilePath, completedLevels);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving player progress: " + ex.Message);
            }
        }

        private void UpdateLevelSelectionUI()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    int levelNumber;
                    if (int.TryParse(button.Text.Replace("Level", ""), out levelNumber))
                    {
                        bool isLevelUnlocked = completedLevels.Contains("Level" + levelNumber);
                        button.Enabled = isLevelUnlocked;
                    }
                }
            }
        }

        private void LevelButton_Click(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;
            int selectedLevel;
            if (int.TryParse(selectedButton.Text.Replace("Level", ""), out selectedLevel))
            {
                if (!completedLevels.Contains("Level" + selectedLevel))
                {
                    MessageBox.Show("Please complete the earlier levels first.", "Level Locked");
                }
                else
                {
                    MessageBox.Show("Loading Level: " + selectedLevel);
                    // Code to load and display the selected level
                    RadishMove radish = new RadishMove();
                    radish.Show();


                    // Example: Move character to the level
                    MoveCharacterToLevel("Level" + selectedLevel);
                }
            }
        }

        private void MoveCharacterToLevel(string levelName)
        {
            // Code to move the character to the specified level
            // Example: Update character's position, animations, etc.
        }


        private void LoadLevel(string levelName)
        {
            // Code to load and display the selected level
            MessageBox.Show("Loading Level: " + levelName);
            MoveCharacterToLevel(levelName);
        }

        private void level1_Click(object sender, EventArgs e)
        {
            LoadLevel("Level1");
            Radish_Move radishMoveForm = new Radish_Move();
            radishMoveForm.ShowDialog();
            this.Close();
        }

        private void level2_Click(object sender, EventArgs e)
        {
            if (completedLevels.Contains("Level1"))
            {
                LoadLevel("Level2");
                Corn_Move corn = new Corn_Move();
                corn.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Level 2 is locked. Complete the earlier levels first.", "Level Locked");
            }
        }

        private void level3_Click(object sender, EventArgs e)
        {
            if (completedLevels.Contains("Level2"))
            {
                LoadLevel("Level3");
                Cabbage_Move cabbage = new Cabbage_Move();
                cabbage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Level 2 is locked. Complete the earlier levels first.", "Level Locked");
            }
        }

        private void level4_Click(object sender, EventArgs e)
        {
            if (completedLevels.Contains("Level3"))
            {
                LoadLevel("Level4");
                Cucumber_Move cucumber = new Cucumber_Move();
                cucumber.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Level 2 is locked. Complete the earlier levels first.", "Level Locked");
            }
        }

        private void level5_Click_1(object sender, EventArgs e)
        {
            if (completedLevels.Contains("Level4"))
            {
                LoadLevel("Level5");
                Tomato_Move tomato = new Tomato_Move();
                tomato.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Level 2 is locked. Complete the earlier levels first.", "Level Locked");
            }
        }

        private void level6_Click_1(object sender, EventArgs e)
        {
            if (completedLevels.Contains("Level5"))
            {
                LoadLevel("Level6");
                Carrot_Move carrot = new Carrot_Move();
                carrot.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Level 2 is locked. Complete the earlier levels first.", "Level Locked");
            }
        }

        private void Levels_Load_1(object sender, EventArgs e)
        {
            // Set the background images for the buttons
            level1.BackgroundImage = Properties.Resources.Radish;
            level2.BackgroundImage = Properties.Resources.Corn;
            level3.BackgroundImage = Properties.Resources.Cabbage;
            level4.BackgroundImage = Properties.Resources.Cucumber;
            level5.BackgroundImage = Properties.Resources.Tomato;
            level6.BackgroundImage = Properties.Resources.Carrot;
            // Set other buttons' background images in a similar way

            // Set the layout mode for the background images
            level1.BackgroundImageLayout = ImageLayout.Stretch;
            level2.BackgroundImageLayout = ImageLayout.Stretch;
            level3.BackgroundImageLayout = ImageLayout.Stretch;
            level4.BackgroundImageLayout = ImageLayout.Stretch;
            level5.BackgroundImageLayout = ImageLayout.Stretch;
            level6.BackgroundImageLayout = ImageLayout.Stretch;
            // Set other buttons' background image layout modes in a similar way

            // Enable or disable the buttons based on the completed levels
            UpdateLevelSelectionUI();
        }
    }
}
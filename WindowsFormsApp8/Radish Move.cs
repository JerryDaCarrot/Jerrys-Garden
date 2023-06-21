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
    public partial class Radish_Move : Form
    {
        public Radish_Move()
        {
            InitializeComponent();
        }

        private void Radish_Move_Load(object sender, EventArgs e)
        {
            
        }
        public void Radish_Move_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    JerryRadish.Left -= 10;
                    break;
                case Keys.Right:
                    JerryRadish.Left += 10;
                    break;
                case Keys.Up:
                    JerryRadish.Top -= 10;
                    break;
                case Keys.Down:
                    JerryRadish.Top += 10;
                    break;

            }
        }

        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {
            if (JerryRadish.Location == new Point(121, 121))
            {
                // Create an instance of Form2
                Radish_Seeds radishSeeds = new Radish_Seeds();

                // Display Form2
                radishSeeds.Show();

                // Hide the current form (optional)
                this.Hide();
            }
        }

    }
}

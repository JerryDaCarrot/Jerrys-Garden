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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }

        private void Radish_Click(object sender, EventArgs e)
        {
            
            Radish_Move radish = new Radish_Move();

            // Display Form1
            radish.Show();

            // Hide the current form (optional)
            this.Hide();

        }
    }
}

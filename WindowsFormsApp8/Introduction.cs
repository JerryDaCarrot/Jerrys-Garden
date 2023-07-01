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
    public partial class Introduction : Form
    {
        

        public Introduction()
        {
            InitializeComponent();

            
            

            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(689, 191);

            How_To_Play htp = new How_To_Play();

            // Display Form1
            htp.Show();

            // Hide the current form (optional)
            this.Hide();

        }


        private RadishMove radishMoveForm;

        private void radishMoveButton_Click(object sender, EventArgs e)
        {
            if (radishMoveForm == null)
            {
                radishMoveForm = new RadishMove();
            }

            Radish_Seeds radishSeedsForm = new Radish_Seeds(radishMoveForm);
            radishMoveForm.Show();
            radishSeedsForm.Show();
            this.Hide();
        }

        private void Introduction_Load(object sender, EventArgs e)
        {
            
    }
    }
}
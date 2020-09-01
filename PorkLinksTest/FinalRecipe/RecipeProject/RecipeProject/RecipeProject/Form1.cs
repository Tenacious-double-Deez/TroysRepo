using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Code to take you to a specific form within the Project, Just rename form1 to desired location, also hides
            PorkRecipes f1 = new PorkRecipes(); // Going back to the "home page"
            f1.Show();
        }

        private void PorkLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BeefLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BeefBox_Click(object sender, EventArgs e)
        {
            this.Hide(); // Code to take you to a specific form within the Project, Just rename form1 to desired location, also hides
            BeefForm f1 = new BeefForm(); // Going back to the "home page"
            f1.Show();
        }

    }
}

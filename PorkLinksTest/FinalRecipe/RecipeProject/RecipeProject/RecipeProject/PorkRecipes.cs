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
    public partial class PorkRecipes : Form
    {
        public PorkRecipes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PorkLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            this.Hide(); // Code to take you to a specific form within the Project, Just rename form1 to desired location, also hides
            Form1 f1 = new Form1(); // Going back to the "home page"
            f1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PorkLinkOne(object sender, EventArgs e)
        {
            
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Code to take you to a specific form within the Project, Just rename form1 to desired location, also hides
            PorkLinkOne f1 = new PorkLinkOne(); // Going back to the "home page"
            f1.Show();
        }

        private void PorkOne_Click(object sender, EventArgs e)
        {
             // Code to take you to a specific form within the Project, Just rename form1 to desired location, also hides
            PorkLinkOne f1 = new PorkLinkOne(); // Going back to the "home page"
            f1.Show();
        }
    }
}

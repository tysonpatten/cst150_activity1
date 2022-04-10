// tyson patten
// cst 150
// topic 1 // activity 1
//this is my work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // creates the string variable name and assigns it to World
        String name = "World";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // changes name variable to user input
        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            name = nameInput.Text;
        }

        // displays a phrase when the button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            displayMessage.Text = "Hello " + name + ".";
        }

        
    }
}

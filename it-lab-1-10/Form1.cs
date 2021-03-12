using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_1_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void asteriskButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = asteriskButton.Text;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = plusButton.Text;
        }

        private void zeroesButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = zeroesButton.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.PeachPuff;
            textBox1.Text = "Ready";
        }
    }
}

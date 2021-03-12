using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace it_lab_1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("+"))
                textBox1.Clear();

            while (TextRenderer.MeasureText(textBox1.Text, textBox1.Font).Width < textBox1.Width)
            {
                textBox1.AppendText("*");
                Thread.Sleep(50);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkCyan;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            while (TextRenderer.MeasureText(textBox1.Text, textBox1.Font).Width <= textBox1.Width)
            {
                textBox1.AppendText("+");
                Thread.Sleep(50);
            }
        }
    }
}

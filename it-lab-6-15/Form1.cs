using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_6_15
{
    public partial class Form1 : Form
    {
        int[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void fillArrayButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            var size = (int)numericUpDown1.Value;
            array = new int[size];
            var rnd = new Random();
            arrayTextBox.Clear();

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(-100, 100);
                arrayTextBox.Text += $"Array[{i}] = {array[i]}" + Environment.NewLine;
            }

            resultButton.Enabled = true;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            int positives = 0;
            foreach(var i in array)
            {
                if (i > 0)
                    positives++;
            }
            var result = Math.Round((double)positives / array.Length * 100, 2);
            resultTextBox.Text = $"{result}% elements of array are positive";
            resultButton.Enabled = false;
        }
    }
}

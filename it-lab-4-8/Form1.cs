using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_4_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputTextBox.Text))
            {
                MessageBox.Show("No input provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            if (!String.IsNullOrEmpty(resultTextBox.Text))
                resultTextBox.Clear();


            double result;
            if (sumRadioButton.Checked)
            {
                result = Calculations.Sum(inputTextBox.Text);
                resultTextBox.AppendText($"For eps = {inputTextBox.Text}:" + Environment.NewLine);
                resultTextBox.AppendText($"Sum equals S = {result}");
            }
            else
            {
                result = Calculations.Product(inputTextBox.Text);
                resultTextBox.AppendText($"For m = {inputTextBox.Text}:" + Environment.NewLine);
                resultTextBox.AppendText($"Product equals P = {result}");
            }
        }
    }
}

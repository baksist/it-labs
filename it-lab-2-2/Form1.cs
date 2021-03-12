using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(argTextBox.Text))
            {
                double arg;
                Double.TryParse(argTextBox.Text, out arg);
                double res = Function.Calculate(arg);
                if (double.IsNaN(res) || double.IsInfinity(res))
                    resTextBox.AppendText("Invalid argument");
                else
                    resTextBox.AppendText($"If x is {arg}, then y is {res}");
                resTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}

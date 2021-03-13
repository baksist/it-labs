using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_3_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(resultTextBox.Text))
                resultTextBox.Clear();

            var x = Convert.ToDouble(textBoxX.Text);
            string funcName;
            if (shRadioButton.Checked)
                funcName = shRadioButton.Text;
            else if (chRadioButton.Checked)
                funcName = chRadioButton.Text;
            else
                funcName = expRadioButton.Text;

            var result = calculateFunction(x, funcName);
            resultTextBox.AppendText($"For X = {x}");
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText($"Y = {result}");
        }

        private double calculateFunction(double x, string functionName)
        {
            double func;
            switch(functionName)
            {
                case "sh":
                    func = Math.Sinh(x);
                    break;
                case "ch":
                    func = Math.Cosh(x);
                    break;
                case "exp":
                    func = Math.Exp(x);
                    break;
                default:
                    func = Math.Sinh(x);
                    break;
            }

            if (x > 0)
                return Math.Sqrt(func);
            else if (-3 < x && x <= 0)
                return func;
            else
                return -5;
        }
    }
}

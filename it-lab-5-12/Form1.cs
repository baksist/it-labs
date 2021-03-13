using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_5_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please choose a string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var input = (string)listBox1.SelectedItem;
            var output = String.Concat(input.Split());
            resultLabel.Text = $"Result: {output}";
        }
    }
}

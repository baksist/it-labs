using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_dnd_dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sidesTextBox.Text) && !String.IsNullOrEmpty(diceTextBox.Text))
            {
                ushort sides, dice;

                UInt16.TryParse(sidesTextBox.Text, out sides);
                UInt16.TryParse(diceTextBox.Text, out dice);

                var res = Roll(sides, dice);

                resultTextBox.AppendText($"Rolled {dice} dice with {sides} sides. Result:");
                resultTextBox.AppendText(Environment.NewLine);

                var sum = 0;
                foreach (var item in res)
                {
                    resultTextBox.AppendText(item.ToString() + " ");
                    sum += item;
                }
                resultTextBox.AppendText(Environment.NewLine);
                resultTextBox.AppendText($"Sum is {sum}");
                resultTextBox.AppendText(Environment.NewLine);
            }
        }

        public List<int> Roll(ushort sides, ushort dice)
        {
            var results = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < dice; i++)
            {   
                results.Add(rnd.Next(1, sides + 1));
            }
            return results;
        }
    }
}

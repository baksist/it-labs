using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_7_11
{
    public partial class Form1 : Form
    {
        private const int size = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = size;
            dataGridView1.ColumnCount = size;
            int[,] array = new int[size, size];
            var rnd = new Random();

            for (var i = 0; i < size; i++)
            { 
                for (var j = 0; j < size; j++)
                {
                    array[i, j] = rnd.Next(-50, 50);
                    dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                }
            }

            for (var j = 0; j < size; j++)
            {
                int result;
                if (j % 2 == 0)
                    result = int.MinValue;              
                else                
                    result = int.MaxValue;

                for (var i = 0; i < size; i++)
                {
                    if (j % 2 == 0 && array[i, j] > result)
                        result = array[i, j];
                    else if (j % 2 != 0 && array[i, j] < result)
                        result = array[i, j];
                }
                textBox1.Text += $"Column {j}: {result}" + Environment.NewLine;
            }
        }
    }
}

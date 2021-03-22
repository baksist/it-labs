using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
//andrey.ladynin@hotmail.com
namespace it_lab_7_11
{
    public partial class Form1 : Form
    {
        private const int size = 9;
        private static int[,] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = size;
            dataGridView1.ColumnCount = size;
            array = new int[size, size];
            var rnd = new Random();

            for (var i = 0; i < size; i++)
            { 
                for (var j = 0; j < size; j++)
                {
                    array[i, j] = rnd.Next(-50, 50);
                    dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                }
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (size % 2 == 0 || size < 3)
            {
                MessageBox.Show("Invalid matrix", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var upper_matrix = Matrix<double>.Build.Dense(size / 2, size / 2);
            var lower_matrix = Matrix<double>.Build.Dense(size / 2, size / 2);

            for (var i = 0; i < size / 2; i++)
            {
                for (var j = 0; j < size / 2; j++)
                {
                    upper_matrix[i, j] = array[i, j + size / 2 + 1];
                    dataGridView1.Rows[i].Cells[j + size / 2 + 1].Style.BackColor = Color.Red;

                    lower_matrix[i, j] = array[i + size / 2 + 1, j];
                    dataGridView1.Rows[i + size / 2 + 1].Cells[j].Style.BackColor = Color.Blue;
                }
            }

            var det_up = upper_matrix.Determinant();
            var det_low = lower_matrix.Determinant();

            textBox1.Clear();
            textBox1.Text += $"Upper matrix DET: {det_up}" + Environment.NewLine;
            textBox1.Text += $"Lower matrix DET: {det_low}" + Environment.NewLine;
            textBox1.Text += $"{det_up} - {det_low} = {det_up - det_low}" + Environment.NewLine;         
        }
    }
}

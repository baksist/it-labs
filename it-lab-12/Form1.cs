using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_12
{
    public partial class Form1 : Form
    {
        public static List<Tuple<double, double>> points = new List<Tuple<double, double>>();

        public Form1()
        {      
            InitializeComponent();
            fillTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            points.Clear();

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null || String.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()) || 
                    row.Cells[1].Value == null || String.IsNullOrWhiteSpace(row.Cells[1].Value.ToString()))
                    continue;
                var x = Convert.ToDouble(row.Cells[0].Value);
                var y = Convert.ToDouble(row.Cells[1].Value);
                points.Add(new Tuple<double, double>(x, y));
            }

            Console.WriteLine(LinearRegression.GetPrecisePolynomial(1));
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            var a = LinearRegression.GetPolynomial(1);
            MessageBox.Show($"{a[0]}+{a[1]}x", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = LinearRegression.GetPolynomial(2);
            MessageBox.Show($"{a[0]}+{a[1]}x+{a[2]}x^2", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fillTable()
        {
            dataGridView1.RowCount = 6;
            dataGridView1.ColumnCount = 2;

            dataGridView1.Rows[0].Cells[0].Value = 0.0;
            dataGridView1.Rows[1].Cells[0].Value = 0.2;
            dataGridView1.Rows[2].Cells[0].Value = 0.4;
            dataGridView1.Rows[3].Cells[0].Value = 0.6;
            dataGridView1.Rows[4].Cells[0].Value = 0.8;
            dataGridView1.Rows[5].Cells[0].Value = 1.0;

            dataGridView1.Rows[0].Cells[1].Value = 3.0;
            dataGridView1.Rows[1].Cells[1].Value = 6.0;
            dataGridView1.Rows[2].Cells[1].Value = 3.0;
            dataGridView1.Rows[3].Cells[1].Value = 6.0;
            dataGridView1.Rows[4].Cells[1].Value = 4.0;
            dataGridView1.Rows[5].Cells[1].Value = 3.0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var order = LinearRegression.GetPrecisePolynomial(1);
            var a = LinearRegression.GetPolynomial(order);
            var res = "";
            for (var i = 0; i < a.Count; i++)
            {
                res += $"{a[i]} * x^{i} + ";
            }
            MessageBox.Show($"{res}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

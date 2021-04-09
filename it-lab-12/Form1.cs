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
            for(var i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                var x = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                var y = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                points.Add(new Tuple<double, double>(x, y));
            }

           /* points = points.OrderByDescending(x => x.Item1).ToList();
            chart1.ChartAreas[0].AxisX.Maximum = points[0].Item1;
            chart1.ChartAreas[0].AxisX.Minimum = points.Last().Item2;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = (points[0].Item1 - points.Last().Item1) / points.Count;

            chart1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series() { Name = "points", BorderWidth = 1, ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline});
            chart1.Series[0].Points.DataBindXY(points.Select(x => x.Item1).ToArray(), points.Select(x => x.Item2).ToArray());*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*var a = LinearRegression.FirstOrderPolynomial();
            var a_0 = Math.Round(a.Item1, 3);
            var a_1 = Math.Round(a.Item2, 3);*/
            var a = LinearRegression.GetPolynomial(1);
            MessageBox.Show($"{a[0]}+{a[1]}x", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*var a = LinearRegression.SecondOrderPolynomial();
            var a_0 = Math.Round(a[0], 3);
            var a_1 = Math.Round(a[1], 3);
            var a_2 = Math.Round(a[2], 3);*/
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
    }
}

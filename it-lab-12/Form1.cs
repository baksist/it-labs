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

            points = points.OrderByDescending(x => x.Item1).ToList();
            chart1.ChartAreas[0].AxisX.Maximum = points[0].Item1;
            chart1.ChartAreas[0].AxisX.Minimum = points.Last().Item2;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = (points[0].Item1 - points.Last().Item1) / points.Count;

            chart1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series() { Name = "points", BorderWidth = 1, ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline});
            chart1.Series[0].Points.DataBindXY(points.Select(x => x.Item1).ToArray(), points.Select(x => x.Item2).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = LinearRegression.FirstOrderPolynomial();
            MessageBox.Show($"{a.Item1}+{a.Item2}x", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = LinearRegression.SecondOrderPolynomial();
            MessageBox.Show($"{a[0]}+{a[1]}x+{a[2]}x^2", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

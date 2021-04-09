using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
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

        private void button5_Click(object sender, EventArgs e)
        {
            double[] x = points.Select(_ => _.Item1).ToArray();
            double[] y = points.Select(_ => _.Item2).ToArray();
           
            double Xmin = x.Min();
            double Xmax = x.Max();
            double Ymin = y.Min();
            double Ymax = y.Max();
            double step_x = (Xmax - Xmin) / x.Length;
            double step_y = (Ymax - Ymin) / y.Length;

            double[] y_1 = LinearRegression.CalculateY(1);
            double[] y_2 = LinearRegression.CalculateY(2);
            double[] y_p = LinearRegression.CalculateY(LinearRegression.GetPrecisePolynomial(1));

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            ChartArea area = new ChartArea();
            area.Name = "myGraph";
            area.AxisX.Minimum = Xmin;
            area.AxisY.Maximum = Xmax;
            area.AxisX.MajorGrid.Interval = step_x;
            area.AxisY.Minimum = Ymin;
            area.AxisY.Maximum = Ymax;
            area.AxisY.MajorGrid.Interval = step_y;
            chart1.ChartAreas.Add(area);

            Series series_0 = new Series();
            series_0.ChartArea = "myGraph";
            series_0.ChartType = SeriesChartType.Point;
            series_0.MarkerSize = 10;
            series_0.LegendText = "p(x)_0";
            chart1.Series.Add(series_0);

            Series series_1 = new Series();
            series_1.ChartArea = "myGraph";
            series_1.ChartType = SeriesChartType.Spline;
            series_1.BorderWidth = 3;
            series_1.LegendText = "p(x)_1";
            chart1.Series.Add(series_1);

            Series series_2 = new Series();
            series_2.ChartArea = "myGraph";
            series_2.ChartType = SeriesChartType.Spline;
            series_2.BorderWidth = 3;
            series_2.LegendText = "p(x)_2";
            chart1.Series.Add(series_2);

            Series series_p = new Series();
            series_p.ChartArea = "myGraph";
            series_p.ChartType = SeriesChartType.Spline;
            series_p.BorderWidth = 3;
            series_p.LegendText = "p(x)_precise";
            chart1.Series.Add(series_p);

            Legend legend = new Legend();
            chart1.Legends.Add(legend);

            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Series[1].Points.DataBindXY(x, y_1);
            chart1.Series[2].Points.DataBindXY(x, y_2);
            chart1.Series[3].Points.DataBindXY(x, y_p);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }
    }
}

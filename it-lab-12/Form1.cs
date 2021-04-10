using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
            //fillTable();   // uncomment for automatic table fill (variant 1)
        }

        private void resultButton_click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                CopyPointsToList();
                CreateChart();
                FillTextBox();
            }
            else            
                MessageBox.Show("Please provide at least six value pairs",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                      
        }

        private void FillTextBox()
        {
            textBox1.Clear();

            textBox1.Text += $"P_1(x) = {LinearRegression.BeautifyPolynomial(1)}";
            textBox1.Text += Environment.NewLine;

            textBox1.Text += $"P_2(x) = {LinearRegression.BeautifyPolynomial(2)}";
            textBox1.Text += Environment.NewLine;

            var prec = LinearRegression.GetPrecisePolynomial(1);
            textBox1.Text += $"P_{prec}(x) = {LinearRegression.BeautifyPolynomial(prec)}";
        }

        private void CopyPointsToList()
        {
            if (points.Count > 0)
                points.Clear();

            for (var i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    if (ValidateCell(i, 0) && ValidateCell(i, 1))
                    {
                        var x = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                        var y = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                        points.Add(new Tuple<double, double>(x, y));
                    }
                    else if (!ValidateCell(i, 0) && !ValidateCell(i, 1) && dataGridView1.RowCount != 1)
                        continue;
                    else
                    {
                        MessageBox.Show("There are invalid cells in the table. Please enter again.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        points.Clear();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There are invalid cells in the table. Please enter again.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    points.Clear();
                    break;
                }
            }
        }

        private bool ValidateCell(int i, int j)
        {
            var cell = dataGridView1.Rows[i].Cells[j].Value;
            if (cell == null || String.IsNullOrWhiteSpace(cell.ToString()))
                return false;
            else
                return true;
        }

        private void CreateChart()
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
            series_0.LegendText = "P(x)_0";
            chart1.Series.Add(series_0);

            Series series_1 = new Series();
            series_1.ChartArea = "myGraph";
            series_1.ChartType = SeriesChartType.Spline;
            series_1.BorderWidth = 3;
            series_1.LegendText = "P(x)_1";
            chart1.Series.Add(series_1);

            Series series_2 = new Series();
            series_2.ChartArea = "myGraph";
            series_2.ChartType = SeriesChartType.Spline;
            series_2.BorderWidth = 3;
            series_2.LegendText = "P(x)_2";
            chart1.Series.Add(series_2);

            Series series_p = new Series();
            series_p.ChartArea = "myGraph";
            series_p.ChartType = SeriesChartType.Spline;
            series_p.BorderWidth = 3;
            series_p.LegendText = "P(x)_precise";
            chart1.Series.Add(series_p);

            Legend legend = new Legend();
            chart1.Legends.Add(legend);

            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Series[1].Points.DataBindXY(x, y_1);
            chart1.Series[2].Points.DataBindXY(x, y_2);
            chart1.Series[3].Points.DataBindXY(x, y_p);
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

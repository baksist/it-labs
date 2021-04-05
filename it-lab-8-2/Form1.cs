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

namespace it_lab_8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Xmin;
        private double Xmax;
        private double Step;
        private double[] x;
        private double[] y;
        Chart chart;

        private double Function(double x)
        {
            var y = (0.5 * x * x - 1) / Math.Sqrt(x) + Math.Abs(10 - Math.Exp(0.5 * x * x + 1)) / (Math.Log(2 * x) - 1);
            return y;
        }


        private void CalculatePoints()
        {
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step);
            x = new double[count];
            y = new double[count];

            for (var i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                y[i] = Function(x[i]);
            }
        }

        private void CreateChart()
        {
            chart = new Chart();
            chart.Parent = this;
            chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            ChartArea area = new ChartArea();
            area.Name = "graph";
            area.AxisX.Minimum = Xmin;
            area.AxisX.Maximum = Xmax;
            area.AxisX.MajorGrid.Interval = Step;
            chart.ChartAreas.Add(area);

            var series = new Series();
            series.ChartArea = "graph";
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 3;
            series.LegendText = "f(x)";
            chart.Series.Add(series);
            Legend legend = new Legend();
            chart.Legends.Add(legend);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateChart();
            CalculatePoints();
            chart.Series[0].Points.DataBindXY(x, y);
        }
    }
}

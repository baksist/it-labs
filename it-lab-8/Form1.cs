using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_lab_8
{
    public partial class Form1 : Form
    {
        private static double minX = - Math.PI;
        private static double maxX = Math.PI;
        private static double step = 0.1;

        public Form1()
        {
            InitializeComponent();
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var points = Calculate();
            var p = new Pen(Brushes.Black, 2);
            g.DrawCurve(p, points.ToArray());
        }

        private static List<PointF> Calculate()
        {
            var curX = minX;
            var list = new List<PointF>();

            while (curX < maxX)
            {
                list.Add(new PointF((float) curX, (float) Math.Sin(curX)));
                curX += step;
            }

            return list;
        }
    }
}

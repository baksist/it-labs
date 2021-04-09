using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace it_lab_12
{
    static class LinearRegression
    {
        private static double CalculateS(int m)
        {
            double s = 0;
            for (var i = 0; i < Form1.points.Count; i++)
            {
                if (Form1.points[i].Item1 == 0 && m == 0)
                    s += 1;
                else
                    s += Math.Pow(Form1.points[i].Item1, m);
            }
            return s;
        }

        private static double CalculateB(int m)
        {
            double s = 0;
            for (var i = 0; i < Form1.points.Count; i++)
            {
                if (Form1.points[i].Item1 == 0 && m == 0)
                    s += Form1.points[i].Item2;
                else
                    s += Math.Pow(Form1.points[i].Item1, m) * Form1.points[i].Item2;
            }
            return s;
        }

        public static List<double> GetPolynomial(int order)
        {            
            var s = new double[order + 1, order + 1];
            for (var i = 0; i < s.GetLength(0); i++)
                for (var j = 0; j < s.GetLength(1); j++)                
                    s[i, j] = CalculateS(i + j);
            
            var b = new double[order + 1];
            for (var i = 0; i < b.Length; i++)
                b[i] = CalculateB(i);

            var system = Matrix<double>.Build.DenseOfArray(s);
            var vect = Vector<double>.Build.Dense(b);
            var a = system.Solve(vect).ToList();

            for (var i = 0; i < a.Count; i++)
                a[i] = Math.Round(a[i], 3);

            return a;
        }

       /* public static Tuple<double, double> FirstOrderPolynomial()
        {
            var s_0 = CalculateS(0);
            var s_1 = CalculateS(1);
            var s_2 = CalculateS(2);

            var b_0 = CalculateB(0);
            var b_1 = CalculateB(1);
            Console.WriteLine($"{s_0}, {s_1}, {s_2}, {b_0}, {b_1}");
            var system = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                {s_0, s_1 },
                {s_1, s_2 }
            });
            var vect = Vector<double>.Build.Dense(new double[] { b_0, b_1 });

            var a = system.Solve(vect);
            Console.WriteLine($"{a[0]}, {a[1]}");

            var result = new Tuple<double, double>(a[0], a[1]);
            return result;
        }

        public static List<double> SecondOrderPolynomial()
        {
            var s_0 = CalculateS(0);
            var s_1 = CalculateS(1);
            var s_2 = CalculateS(2);
            var s_3 = CalculateS(3);
            var s_4 = CalculateS(4);

            var b_0 = CalculateB(0);
            var b_1 = CalculateB(1);
            var b_2 = CalculateB(2);

            var system = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                {s_0, s_1, s_2 },
                {s_1, s_2, s_3 },
                {s_2, s_3, s_4 }
            });
            var vect = Vector<double>.Build.Dense(new double[] { b_0, b_1, b_2 });

            var a = system.Solve(vect);
            var result = new List<double>(a);

            return result;
        }*/
    }
}

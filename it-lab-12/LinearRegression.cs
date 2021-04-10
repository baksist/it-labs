using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.LinearAlgebra;

namespace it_lab_12
{
    static class LinearRegression
    {
        private static double CalculateS(int m)
        {
            double sum = 0;
            for (var i = 0; i < Form1.points.Count; i++)
            {
                if (Form1.points[i].Item1 == 0 && m == 0)
                    sum += 1;
                else
                    sum += Math.Pow(Form1.points[i].Item1, m);
            }
            return sum;
        }

        private static double CalculateB(int m)
        {
            double sum = 0;
            for (var i = 0; i < Form1.points.Count; i++)
            {
                if (Form1.points[i].Item1 == 0 && m == 0)
                    sum += Form1.points[i].Item2;
                else
                    sum += Math.Pow(Form1.points[i].Item1, m) * Form1.points[i].Item2;
            }
            return sum;
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

        public static double CalculatePolynomial(int order, int index)
        {   
            var a = GetPolynomial(order);
            double y = 0;
            for (var i = 0; i < a.Count; i++)
                y += a[i] * Math.Pow(Form1.points[index].Item1, i);
            return y;
        }

        public static double[] CalculateY(int order)
        {
            double[] y = new double[Form1.points.Count];
            for (var i = 0; i < y.Length; i++)
                y[i] = CalculatePolynomial(order, i);
            return y;
        }

        public static int GetPrecisePolynomial(int order)
        {
            var current_prec = CalculatePrecision(order);
            if (current_prec < CalculatePrecision(order + 1) && current_prec < CalculatePrecision(order + 2))
                return order;
            else
                return GetPrecisePolynomial(order + 1);
        }

        private static double CalculatePrecision(int order)
        {
            var a = GetPolynomial(order);
            double e = 0;
            for (var i = 0; i < Form1.points.Count; i++)
            {
                double p = CalculatePolynomial(order, i);
                e += Math.Pow((Form1.points[i].Item2 - p), 2);
            }
            return e;
        }

        public static string BeautifyPolynomial(int order)
        {
            var a = GetPolynomial(order);
            string result = $"{a[0]} ";
            for(var i = 1; i <= order; i++)
            {
                if (a[i] >= 0)
                    result += $"+ {a[i]} x^{i} ";
                else
                    result += $"- {a[i] * (-1)} x^{i} ";
            }
            return result;
        }
    }
}

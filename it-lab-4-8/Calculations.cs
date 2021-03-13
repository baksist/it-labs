using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_lab_4_8
{
    static class Calculations
    {
        public static double Sum(string input)
        {
            var eps = Convert.ToDouble(input);
            double sum = 0;
            var n = 2;
            double term;
            do
            {
                term = (double)(n - 1) / (double)(2 * Factorial(n) - 2);
                Console.WriteLine(term);
                sum += term;
                n++;
            } while (term > eps);
            return sum;
        }

        public static double Product(string input)
        {
            var m = Convert.ToInt32(input);
            var n = 1;
            double product = 1;
            while (n <= m)
            {
                product *= Math.Sqrt((double)(Factorial(n) + 10 * n) / (double)(3 * n - 2));
                n++;
            }
            return product;
        }

        private static int Factorial(int x)
        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(x - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_lab_2_2
{
    static class Function
    {
        public static double Calculate(double x)
        {
            var y = (0.5 * x * x - 1) / Math.Sqrt(x) + Math.Abs(10 - Math.Exp(0.5 * x * x + 1)) / (Math.Log(2*x) - 1);
            return y;
        }
    }
}

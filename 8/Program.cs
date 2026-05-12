using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static double PowerSeries(double x)
        {
            double sum = 0;
            for (int i = 1; i <= 11; i += 2)
                sum += Math.Pow(x, i) / i;
            return sum;
        }
    }
}

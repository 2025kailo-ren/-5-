using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static double AlternatingSum(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum += (i % 2 == 1 ? 1.0 : -1.0) / i;
            return sum;
        }
    }
}

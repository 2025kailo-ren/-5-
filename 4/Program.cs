using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static double SumReciprocalFactorials(int n)
        {
            double sum = 1.0;
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += 1.0 / fact;
            }
            return sum;
        }
    }
}

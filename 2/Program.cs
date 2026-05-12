using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static int Factorial(int k)
        {
            int res = 1;
            for (int i = 2; i <= k; i++) res *= i;
            return res;
        }

    }
}


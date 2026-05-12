using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static int Factorial(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++) sum += Factorial(i);
            return sum;
        }
    }
}

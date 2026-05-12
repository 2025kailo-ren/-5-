using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static int Square(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++) sum += Square(i);
            return sum;
        }
    }
}

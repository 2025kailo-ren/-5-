using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static int Square(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++) s += 2 * i - 1;
            return s;
        }
    }
}

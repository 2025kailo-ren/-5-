using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static int Min(int a, int b, int c)
        {
            int m = a;
            if (b < m) m = b;
            if (c < m) m = c;
            return m;
        }
    }
}

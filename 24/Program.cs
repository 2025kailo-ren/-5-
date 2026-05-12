using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static int Min(int a, int b, int c, int d)
        {
            return Min(Min(a, b, c), d);
        }
        static int Min(int a, int b, int c, int d, int e)
        {
            return Min(Min(a, b, c, d), e);
        }
    }
}

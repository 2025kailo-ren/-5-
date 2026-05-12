using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static int GetPow(int num, int power)
        {
            int res = 1;
            for (int i = 0; i < power; i++) res *= num;
            return res;
        }
    }
}

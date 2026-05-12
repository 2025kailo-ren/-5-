using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static int FromBaseToDecimal(string num, int baseFrom)
        {
            int res = 0;
            int pow = 1;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                res += (num[i] - '0') * pow;
                pow *= baseFrom;
            }
            return res;
        }
    }
}

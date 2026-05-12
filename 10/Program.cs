using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static string ConvertBase(int num, int baseTo)
        {
            if (num == 0) return "0";
            string res = "";
            while (num > 0)
            {
                res = (num % baseTo) + res;
                num /= baseTo;
            }
            return res;
        }
    }
}

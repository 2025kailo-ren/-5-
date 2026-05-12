using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void PrintDigits(int n)
        {
            while (n > 0)
            {
                Console.Write(n % 10 + " ");
                n /= 10;
            }
            Console.WriteLine();
        }
    }
}

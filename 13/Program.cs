using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void PrintFibonacci(int M)
        {
            int a = 0, b = 1;
            while (a <= M)
            {
                Console.Write(a + " ");
                int c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static int GetNumberInRange()
        {
            int x;
            do
            {
                Console.Write("Введите число от 1 до 100: ");
                x = int.Parse(Console.ReadLine());
            } while (x < 1 || x > 100);
            return x;
        }
    }
}

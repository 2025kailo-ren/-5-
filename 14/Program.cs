using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static double AverageGrade()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Оценка: ");
                sum += double.Parse(Console.ReadLine());
            }
            return sum / 10;
        }
    }
}

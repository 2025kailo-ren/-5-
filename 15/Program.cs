using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static double AverageMass()
        {
            Console.Write("Количество предметов: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Масса: ");
                sum += double.Parse(Console.ReadLine());
            }
            return sum / n;
        }
    }
}

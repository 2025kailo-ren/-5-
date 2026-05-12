using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {   // 19a
        static double YieldForYear(int year)
        {
            double y = 20;
            for (int i = 2; i <= year; i++) y *= 1.02;
            return y;
        }
        // 19b
        static double AreaForYear(int year)
        {
            double a = 100;
            for (int i = 2; i <= year; i++) a *= 1.05;
            return a;
        }
        // 19c
        static double HarvestForYears(int years) 
        {
            double total = 0;
            double area = 100, yield = 20;
            for (int i = 1; i <= years; i++)
            {
                total += area * yield;
                if (i < years)
                {
                    area *= 1.05;
                    yield *= 1.02;
                }
            }
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        // 17a
        static double DailyRun(int day)
        {
            double run = 10;
            for (int i = 2; i <= day; i++) run *= 1.1;
            return run;
        }

        // 17b
        static double TotalRun(int days)
        {
            double sum = 0;
            double run = 10;
            for (int i = 1; i <= days; i++)
            {
                sum += run;
                run *= 1.1;
            }
            return sum;
        }

    }
}

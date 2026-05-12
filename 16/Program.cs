using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        
        
            static int MonthsToSave(double start, double percent, double target)
       {
        int months = 0;
        double sum = start;
        while (sum < target)
        {
            sum *= (1 + percent / 100);
            months++;
        }
        return months;
       }
        
    }
}

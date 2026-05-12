using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void StrangeMan(int N, out double distance, out double path)
        {
            distance = 0;
            path = 0;
            for (int i = 1; i <= N; i++)
            {
                path += 1.0 / i;
                if (i == 1)
                    distance += 1.0;
                else if (i % 2 == 0)
                    distance -= 1.0 / i;
                else
                    distance += 1.0 / i;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n243, k243, i243, count;
            Console.Write("Nhap n: ");
            n243 = int.Parse(Console.ReadLine());
            k243 = 2;
            count = 0;
            while (count < n243)
            {
                for (i243 = 2; i243 * i243 <= k243; ++i243)
                    if (k243 % i243 == 0)
                        break;
                if (i243 * i243 > k243)
                {
                    Console.Write("{0} ",+k243);
                    count++;
                }
                k243++;
                Console.ReadKey();
            }

        }
    }
}


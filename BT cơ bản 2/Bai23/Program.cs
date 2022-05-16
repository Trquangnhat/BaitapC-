using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n243, i243, j243, sum243;
            Console.Write("Nhap n: ");
            n243 = int.Parse(Console.ReadLine());
            Console.Write("Cac so hoan hao nho hon {0} : ", + n243);
            for(i243 = 1;i243<n243;i243++)
            {
                for (sum243 = 0, j243 = 1; sum243 <= i243 && j243 < i243; j243++)
                    if (i243 % j243 == 0)
                        sum243 += j243;
                if (sum243 == i243)
                    Console.Write("{0} ",+i243);
            }    
            Console.ReadKey();

        }
    }
}

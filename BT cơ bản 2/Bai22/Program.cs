using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n243, i243, count, sum;
            Console.Write("Nhap n: ");
            n243 = int.Parse(Console.ReadLine());
            Console.Write("Cac uoc so: ");
            for (count = sum = 0, i243 = 1; i243 <= n243; ++i243)
                if (n243 % i243 == 0)
                {  
                    Console.Write("{0} ", +i243);
                    count++;
                    sum += i243;
                }
            Console.Write("\nCo {0} uoc so, tong la: {1} ", +count, +sum);
            Console.ReadKey();
        }
    }
}

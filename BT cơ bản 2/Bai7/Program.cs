using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a243, b243;
            Console.Write("Nhap a: ");
            a243 = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b243 = float.Parse(Console.ReadLine());
            if (a243 == 0)
                if (b243 == 0)
                    Console.Write("Phuong trinh vo so nghiem!");
                else
                    Console.Write("Phuong trinh vo nghiem!");
            else
                Console.Write("Phuong trinh co nghiem la: "+ -b243/a243);

            Console.ReadKey();

        }
    }
}

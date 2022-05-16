using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a243, b243, c243, t243;

            Console.Write("Nhap so nguyen thu 1: ");
            a243 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen thu 2: ");
            b243 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen thu 3: ");
            c243 = Convert.ToInt32(Console.ReadLine());

            if(a243<b243)
            { t243 = a243;
                a243 = b243;
                b243 = c243;                    
            }    
            if(a243<c243)
            {
                t243 = a243;
                a243 = c243;
                c243 = t243;
            }
            if (b243 < c243)
            {
                t243 = b243;
                b243 = c243;
                c243 = t243;
            }
            Console.WriteLine("Thu tu tang dan: "+c243+", "+b243+", "+a243 );
            Console.ReadKey();
        }
    }
}

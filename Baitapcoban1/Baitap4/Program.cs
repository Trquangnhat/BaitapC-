using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a243, b243, c243;
            Console.Write("Nhap so thuc thu 1: ");
            a243 = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc thu 1: ");
            b243 = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc thu 1: ");
            c243 = double.Parse(Console.ReadLine());
            if (a243*a243 + b243*b243 == c243*c243 || a243*a243 + c243*c243 == b243*b243 || b243*b243 + c243*c243 == a243*a243)
                Console.WriteLine("Day la 3 canh cua tam giac vuong.\n");
            else
                Console.WriteLine("Day khong phai la ba canh cua tam giac vuong.\n");
            Console.ReadKey();
        }
    }
}

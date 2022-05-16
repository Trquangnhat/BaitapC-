using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141593;
            double s243, v243;
            Console.Write("Nhap dien tich khoi cau: ");
            s243 = Double.Parse(Console.ReadLine());

            v243 = (4 * pi * Math.Pow(Math.Sqrt(s243 / (4 * pi)), 3)) / 3 ;

            Console.WriteLine("The tich cua khoi cau la: " + v243);
            Console.ReadKey();

        }
    }
}

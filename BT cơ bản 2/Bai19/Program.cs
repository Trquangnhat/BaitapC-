using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h243, m243, s243;
            long t243;
            Console.Write("Nhap gio, phut, giay [1]: ");
            h243 =  int.Parse(Console.ReadLine());
            m243 = int.Parse(Console.ReadLine());   
            s243 = int.Parse(Console.ReadLine());

            t243 = 3600 * h243 + 60 * m243 + s243;

            Console.Write("Nhap gio, phut, giay [2]: ");
            h243 = int.Parse(Console.ReadLine());
            m243 = int.Parse(Console.ReadLine());
            s243 = int.Parse(Console.ReadLine());

            t243 -= 3600 * h243 + 60 * m243 + s243;

            if(t243 < 0)
                t243 = -t243;
            Console.Write("Hieu thoi gian: {0} gio, {1} phut, {2} giay", +t243 / 3600, +(t243 % 3600) / 60, +(t243 % 3600) % 60);
            Console.ReadKey();
        }
    }
}

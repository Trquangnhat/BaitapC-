using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long h243;
            Console.Write("Nhap so gio: ");
            h243 = long.Parse(Console.ReadLine());
            Console.Write("{0} tuan, {1} ngay, {2} gio\n", +h243 / (24 * 7), +(h243 % (24 * 7)) / 24, +(h243 % (24 * 7)) % 24);
            Console.ReadKey();
        }
    }
}

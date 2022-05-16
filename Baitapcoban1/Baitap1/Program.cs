using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int so243;
            Console.Write("Nhap so nguyen: ");
            so243 = Convert.ToInt32(Console.ReadLine());
            if (so243 > 0 )
               Console.WriteLine("Day la so nguyen duong.\n");
            else
                Console.WriteLine("Day la so nguyen am\n");
            Console.ReadKey();
        }
    }
}

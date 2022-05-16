using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float xA243, yA243, xB243, yB243;
            Console.Write("Nhap toa do A: ");
            xA243 = float.Parse(Console.ReadLine());
            yA243 = float.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem B: ");
            xB243 = float.Parse(Console.ReadLine());
            yB243 = float.Parse(Console.ReadLine());

            Console.WriteLine("|AB| = " + Math.Sqrt((xB243 - xA243) * (xB243 - xA243) + (yB243 - yA243) * (yB243 - yA243)));
            Console.ReadKey();
        }
    }
}

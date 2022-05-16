using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kw243;
            long money;
            Console.Write("Nhap so Kw tieu thu: ");
            kw243 = int.Parse(Console.ReadLine());

            money = kw243 * 500;
            if(kw243 > 100) 
                money += (kw243 - 100)*300;
            if (kw243 > 250)
                money += (kw243 - 250) * 200;
            if (kw243 > 350)
                money += (kw243 - 350) * 500;
            Console.Write("Chi phi: "+money);
            Console.ReadKey();
        }
    }
}

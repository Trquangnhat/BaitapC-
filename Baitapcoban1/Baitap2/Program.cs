using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int so243;
            Console.Write("Nhap so nguyen 0 - 9: ");
            so243 = Convert.ToInt32(Console.ReadLine());
            if (so243 == 0)
                Console.WriteLine("Khong.\n");
            else
                 if (so243 == 1)
                    Console.WriteLine("Mot.\n");
                 else
                     if (so243 == 2)
                        Console.WriteLine("Hai.\n");
                    else
                         if (so243 == 3)
                              Console.WriteLine("Ba.\n");
                         else
                                if (so243 == 4)
                                    Console.WriteLine("Bon.\n");
                                else
                                    if (so243 == 5)
                                        Console.WriteLine("Nam.\n");
                                    else
                                        if (so243 == 6)
                                            Console.WriteLine("Sau.\n");
                                        else
                                                if (so243 == 7)
                                                    Console.WriteLine("Bay.\n");
                                                 else
                                                    if (so243 == 8)
                                                         Console.WriteLine("Tam.\n");
                                                    else
                                                            Console.WriteLine("Chin.\n");
            Console.ReadKey();
        }
    }
}

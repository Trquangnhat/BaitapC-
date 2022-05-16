using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i243, j243;
            Console.WriteLine("Bang cuu chuong");
            for (i243 = 2; i243 <= 9; i243++)
            {
                for (j243 = 1; j243 <= 10; j243++)
                    Console.WriteLine("{0} * {1} = {2}", +i243, +j243, i243 * j243);
                Console.WriteLine("\n");
            }
            Console.ReadKey();  
        }
    }
}

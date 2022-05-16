using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x243, y243, z243;
            for (x243 = 1; x243 < 100 / 5; ++x243)
                for (y243 = 1; y243 < 100 / 3; ++y243)
                {
                    z243 = 100 - (x243 + y243);
                    if (300 == 15 * x243 + 9 * y243 + z243)
                        Console.Write("( {0} , {1} , {2} )\n", +x243, +y243, +z243);

                }
            Console.ReadKey();
        }
    }
}

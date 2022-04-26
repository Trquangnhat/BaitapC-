using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a243 = Int32.Parse(Console.ReadLine());
            double b243 = Int32.Parse(Console.ReadLine());
            double c243 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a243, b243, c243);

            double delta = pt.delta(a243, b243, c243);
            int check243 = pt.nghiem(delta);
            if (check243 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (check243 == 0)
            {
                double x = -b243 / (2 * a243);
                Console.WriteLine("pt co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b243 - Math.Sqrt(delta)) / (2 * a243);
                double x2 = (-b243 + Math.Sqrt(delta)) / (2 * a243);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
            Console.ReadKey();
        }
       
    }

    class ptb2
    {
        private double a243;
        private double b243;
        private double c243;

        public ptb2()
        {
        }

        public ptb2(double a243, double b243, double c243)
        {
            A = a243;
            B = b243;
            C = c243;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a243, double b243, double c243)
        {
            return b243 * b243 - 4 * a243 * c243;
        }

        public int nghiem(double delta243)
        {
            if (delta243 < 0)
            {
                return -1;
            }
            else if (delta243 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
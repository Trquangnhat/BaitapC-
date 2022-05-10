using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTdiemdanh10_5
{
    internal class Program
    {
     
            public static void Main()
            {

                int[] arr1 = new int[100];
                int i, mx243, mn243, n243;


                Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang trong C#:\n");
                Console.Write("-----------------------------------------------------------\n");

                Console.Write("Nhap so phan tu can luu giu trong mang: ");
                n243 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhap {0} phan tu vao trong mang:\n", n243);
                for (i = 0; i < n243; i++)
                {
                    Console.Write("Phan tu - {0}: ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }


                mx243 = arr1[0];
                mn243 = arr1[0];

                for (i = 1; i < n243; i++)
                {
                    if (arr1[i] > mx243)
                    {
                        mx243 = arr1[i];
                    }


                    if (arr1[i] < mn243)
                    {
                        mn243 = arr1[i];
                    }
                }
                Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx243);
                Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn243);

                Console.ReadKey();
            }
        }
    }


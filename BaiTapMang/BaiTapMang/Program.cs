using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMang
{
    class Program
    {
        static void Main(string[] args)
        {
            come:
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Bai 59");
            Console.WriteLine("Bai 60");
            Console.WriteLine("Bai 61");
            Console.WriteLine("Bai 62");
            Console.WriteLine("Bai 63");
            Console.WriteLine("---------------------------------");
            Console.Write("Chon bai toan: ");
            int bai = Int32.Parse(Console.ReadLine());
            switch (bai)
            {
                case 59:
                    Console.Clear();
                    Console.Write("Bai 59: \n");
                    Bai59();
                    goto come;
                    break;
                case 60:
                    Console.Clear();
                    Console.Write("Bai 60: \n");
                    Bai60();
                    goto come;
                    break;
                case 61:
                    Console.Clear();
                    Console.Write("Bai 61: \n");
                    Bai61();
                    goto come;
                    break;
                case 62:
                    Console.Clear();
                    Console.Write("Bai 62: \n");
                    Bai62();
                    goto come;
                    break;
                case 63:
                    Console.Clear();
                    Console.Write("Bai 63: \n");
                    Bai63();
                    goto come;
                    break;
                default:
                    Console.WriteLine("Chon sai.");
                    goto come;
                    break;
            }

            Console.ReadLine();
        }
         
        static void Bai59()
        {
            string[] can = {"Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky"};
            string[] chi = {"Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui"};
            Console.Write("Nhap mot nam bat ky: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nam {0} - {1} {2}", n, can[n % 10], chi[n % 12]);
            Console.WriteLine("Nam {0} - {1} {2}", n+60, can[n % 10], chi[n % 12]);
        }

        static void Bai60()
        {
            Console.Write("Nhap do dai cua mang: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] mang = new int[n];
            int[] mang2 = new int[n];
            int[] mang3 = new int[n];

            mang = taoMang(mang, n);
            xuatMang(mang, n);

            Console.WriteLine("\n");

            mang2 = shuffle(mang, n);
            xuatMang(mang2, n);

            int dem = 0;
            do
            {
                mang3 = shuffle(mang2, n);
                mang2 = mang3;
                dem++;
            } while (mang.SequenceEqual(mang3) == false);
            Console.WriteLine("\nCan " + (dem + 1) + " lan shuffle de mang tro ve ban dau");

        }

        static void Bai61()
        {
            Console.Write("Nhap do dai cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            mang = taoMang(mang, n);
            xuatMang(mang, n);

            Console.WriteLine("\nTong cac so nguyen duong = " + sum(mang));
            Console.Write("\nNhap p [0, " + (n - 1) + "]: ");
            int p = int.Parse(Console.ReadLine());

            mang = delete(mang, n, p);
            n--;
            xuatMang(mang, n);
        }

        static void Bai62()
        {
            Console.Write("Nhap do dai cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            mang = taoMang62(mang, n);
            xuatMang(mang, n);

            sum1(mang, n);

            capSo(mang, n);
        }

        static void Bai63()
        {
            Console.Write("Nhap do dai cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            mang = taoMang(mang, n);
            xuatMang(mang, n);

            int j = 0;
            for(int i = 0; i < n; i++)
            {
                if(mang[i] % 4 == 0 && mang[i] % 6 == 0)
                {
                    j++;
                }
            }
            Console.WriteLine("\nCo " + j + " phan tu chia het cho 4, tan cung 6");
            Console.WriteLine("Nhan doi phan tu le:");
            for (int i = 0; i < n; i++)
            {
                if (mang[i] % 2 != 0 )
                {
                    mang[i] *= 2;
                }
            }
            xuatMang(mang, n);
        }

        public static int[] taoMang(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(-100, 100);
            }
            return mang;
        }
        public static int[] taoMang62(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(10, 20);
            }
            return mang;
        }

        public static void xuatMang(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
        }

        public static int[] shuffle(int[] mangA, int n)
        {
            int[] mangB = new int[n];
            int a = n / 2;
            int b = a;
            int j = 0;
            for (int i = 0; i < a; i++)
            {
                mangB[j] = mangA[i];
                j++;
                mangB[j] = mangA[b];
                b++;
                j++;
            }
            return mangB;
        }

        public static int sum(int[] mang)
        {
            int sum = 0;
            foreach (int a in mang)
            {
                if (a > 0)
                    sum += a;
            }
            return sum;
        }

        public static int[] delete(int[] mang, int n, int p)
        {
            for (int i = p; i < n - 1; i++)
            {
                mang[i] = mang[i + 1];
            }
            return mang;
        }
        public static void sum1(int[] mang, int n)
        {
            int a = 0, b = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0 && mang[i] % 2 == 0)
                    a += mang[i];
                if (i % 2 == 0 && mang[i] % 2 != 0)
                    b += mang[i];
            }
            Console.Write("\nTong cac so chan o vi tri le: " + a + "\nTong cac so le o vi tri chan: " + b);
            if (a == b)
                Console.WriteLine("\n=> Bang nhau.");
            else
                Console.WriteLine("\n=> Khong bang nhau.");
        }

        public static int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        public static void capSo(int[] mang, int n)
        {
            Console.WriteLine("Cac cap nguyen to cũng nhau: ");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (i != j)
                    {
                        int uc = UCLN(mang[i], mang[j]);
                        if (uc == 1)
                            Console.WriteLine("(" + mang[i] + ", " + mang[j] + ")");
                    }
                }
            }
        }
    }
}

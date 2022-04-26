using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dahinh
{
    class HinhHoc
    {
        public virtual void xuat()
        {
            Console.WriteLine("day la hinh da giac");
        }
    }

    class TamGiac : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("hinh tam giac co 3 canh");
        }
    }
    class TuGiac : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("Hinh tu giac co 4 canh");
        }
    }
    class hinhBinhHanh : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("Hbh co 2 cap canh song song");
        }
    }
    class hinhVuong : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("hinh vuong co 4 canh bang nhau va 4 goc vuong");
        }
    }

    class hinhChuNhat : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("hinh chu nhat co 2 cap canh doi bang nhau va 4 goc vuong");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int hinhHoc;
            Console.WriteLine("1 - hinh tam giac");
            Console.WriteLine("2 - hinh tu giac");
            Console.WriteLine("3 - hinh binh hanh ");
            Console.WriteLine("4 - hinh chu nhat ");
            Console.WriteLine("5 - hinh vuong ");
            Console.WriteLine("Nhap hinh: ");
            Console.WriteLine("=========================================");
            hinhHoc = int.Parse(Console.ReadLine());

            switch (hinhHoc)
            {
                case 1:
                    {
                        TamGiac tg = new TamGiac();
                        tg.xuat();
                    }
                    break;
                case 2:
                    {
                        TuGiac tg = new TuGiac();
                        tg.xuat();
                    }
                    break;
                case 3:
                    {
                        hinhBinhHanh hbh = new hinhBinhHanh();
                        hbh.xuat();
                    }
                    break;
                case 4:
                    {
                        hinhChuNhat hcn = new hinhChuNhat();
                        hcn.xuat();
                    }
                    break;
                case 5:
                    {
                        hinhVuong hv = new hinhVuong();
                        hv.xuat();
                    }
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
    }
}
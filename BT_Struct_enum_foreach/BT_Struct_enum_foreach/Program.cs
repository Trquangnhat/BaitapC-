using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Struct_enum_foreach
{
    internal class Program
    {
        struct Sinhvien
        {
            public int MaSo243;
            public string Hoten243;
            public double DiemToan243;
            public double DiemLy243;
            public double DiemVan243;
        }
        static void NhapTTSinhVien(out Sinhvien sv)
        {
           
                Console.Write("Mã sinh viên: ");
                sv.MaSo243 = int.Parse(Console.ReadLine());
                Console.Write("Ten sinh vien: ");
                sv.Hoten243 = Console.ReadLine();
                Console.Write("Diem Toan: ");
                sv.DiemToan243 = Double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                sv.DiemLy243 = Double.Parse(Console.ReadLine());
                Console.Write("Diem Van: ");
                sv.DiemVan243 = Double.Parse(Console.ReadLine());
            
        }
        static void XuatThongTinSinhVien(Sinhvien sv)
        {
            Console.WriteLine(" Ma so: " + sv.MaSo243);
            Console.WriteLine(" Ho ten: " + sv.Hoten243);
            Console.WriteLine(" Diem toan:" + sv.DiemToan243);
            Console.WriteLine(" Diem ly: " + sv.DiemLy243);
            Console.WriteLine(" Diem van: " + sv.DiemVan243);

        }
        static double DiemTBSinhvien(Sinhvien sv)
        {
            return (sv.DiemToan243 + sv.DiemLy243 + sv.DiemVan243) / 3;
        }
            static void Main(string[] args)
        {
            Sinhvien sv1 = new Sinhvien();
            Console.WriteLine(" Nhap thong tin sinh vien: ");
            NhapTTSinhVien(out sv1);
            Console.WriteLine("*********");
            Console.WriteLine(" Thong tin sinh vien vua nhap la: ");
            XuatThongTinSinhVien(sv1);
            Console.WriteLine(" Diem TB cua sinh vien la: "+ DiemTBSinhvien(sv1));
            Console.ReadLine();


        }
    }
}

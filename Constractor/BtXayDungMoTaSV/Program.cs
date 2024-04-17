using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtXayDungMoTaSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            Console.WriteLine("Thong tin cua sinh vien thu nhat: ");
            sv1.Nhap();
            sv1.Xuat();
            Console.WriteLine("Thong tin cua sinh vien thu 2: ");
            string HoTen;
            double DiemTB;
            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap diem TB: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
            SinhVien sv2 = new SinhVien(HoTen, DiemTB);
            sv2.Xuat();
            Console.Read();
        }
    }
    
}


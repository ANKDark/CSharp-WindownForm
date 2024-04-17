using System;

namespace BtXayDungMoTaSV
{
    internal class SinhVien
    {
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public string XepLoai()
        {
            if (DiemTB >= 8.5)
            {
                return "Gioi";
            }
            else if (DiemTB >= 6.5)
            {
                return "Kha";
            }
            else if (DiemTB >= 5)
            {
                return "Trung binh";
            }
            else
            {
                return "Yeu";
            }
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap diem Tb: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0} \n {1} \n {2}", HoTen, DiemTB, XepLoai());
        }
        public SinhVien()
        { }
        public SinhVien(string hoTen, double DiemTB)
        {
            this.HoTen = HoTen;
            this.DiemTB = DiemTB;
        }
    }
}

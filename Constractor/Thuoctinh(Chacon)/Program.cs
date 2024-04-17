using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuoctinh_Chacon_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ketoan kt = new Ketoan();
            Console.WriteLine("Luong: " + kt.luong);
            Console.WriteLine("Phu cap: " + kt.phucap);
            Console.ReadLine();
            Laptrinh lt = new Laptrinh();
            Console.WriteLine("Luong: " + lt.luong);
            Console.WriteLine("Phu cap: " + lt.phucap);
        }
    }
    public class NhanVien
    {
        public long luong = 50000000;
    }
    public class Ketoan:NhanVien 
    {
        public long phucap = 1000000;
    }
    public class Laptrinh:NhanVien
    {
        public long phucap = 50000000000;
    }

}

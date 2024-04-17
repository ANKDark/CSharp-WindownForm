using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChuNhat cn1 = new ChuNhat(5, 2);
            Console.WriteLine("Dien tich hinh chu nhat: {0}", cn1.Dientich());
            ChuNhat cn2 = new ChuNhat(5);
            Console.WriteLine("Dien tich hinh vuong: {0}", cn2.Dientich());
            Console.Read();
        }
    }
    public class ChuNhat
    {
        int dai, rong;
        public ChuNhat(int dai, int rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public ChuNhat(int canh)
        {
            this.dai = canh;
            this.rong = canh;
        }
        public int Dientich()
        {
            return dai * rong;
        }
    }
}

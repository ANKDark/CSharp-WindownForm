using System;

namespace BaitapVeXau
{
    internal class Program
    {
        static int n, nThap;
        static int[] a = new int[100];

        static void Main(string[] args)
        {
            // Bai 1
            int count = 0, sum = 0;
            NhapMang();
            XuatMang();

            for (int i = 0; i < n; i++)
            {
                if (NguyenTo(a[i]))
                {
                    count++;
                    sum += a[i];
                }
            }

            Console.WriteLine("\nSo nguyen to co trong day: {0}", count);
            Console.WriteLine("Tong so nguyen to co trong day: {0}", sum);

            //Bai 2
            NhapnThap();
            char aT = 'A', bT = 'B', cT = 'C';
            ThapHN(aT, bT, cT, nThap);

            // Bai 3
            string xau;
            char ktu;
            Console.Write("\nNhap mot xau ki tu ban mong muon: ");
            xau = Console.ReadLine();
            Console.WriteLine("Xau ban vua nhap: {0}", xau);
            Console.WriteLine("Xau ban vua nhap: {0}", xau.ToUpper());
            Console.Write("Nhap mot ki tu bat ky: ");
            ktu = Console.ReadKey().KeyChar;
            KtraKiTu(ktu, xau);
            // Bai 4
            string hovaten;
            Console.Write("Nhap ho va ten cua ban: ");
            hovaten = Console.ReadLine();
            string[] luutru = hovaten.Split(' ');
            tachHVT(hovaten, luutru);
            Console.Read();
        }

        // Bai 1
        public static void NhapMang()
        {
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia tri cua mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void XuatMang()
        {
            Console.WriteLine("Day so vua nhap: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }

        public static bool NguyenTo(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        //Bai 2
        public static void NhapnThap()
        {
            Console.Write("Nhap n thap: ");
            nThap = Convert.ToInt32(Console.ReadLine());
        }

        public static void ThapHN(char a, char b, char c, int nThap)
        {
            if (nThap > 0)
            {
                ThapHN(a, c, b, nThap - 1);
                Console.WriteLine("Chuyen dia thu {0} tu cot {1} sang cot {2}", nThap, a, c);
                ThapHN(b, a, c, nThap - 1);
            }
        }
        // Bai 3
        public static void KtraKiTu(char ktu, string xau)
        {
            int count3 = 0;

            for (int i = 0; i < xau.Length; i++)
            {
                if (ktu == xau[i])
                {
                    count3++;
                }
            }

            Console.WriteLine("\nSo lan {0} xuat hien trong xau la {1}.", ktu, count3);
        }
        public static void tachHVT (string hovaten, string[] luutru)
        {
            if (luutru.Length >= 1)
            {
                string hodem = "";
                for (int i = 0; i < luutru.Length - 1; i++)
                {
                    hodem += luutru[i] + " ";
                }
                string ten = luutru[luutru.Length - 1];
                Console.WriteLine("\nHo va dem: " + hodem.Trim());
                Console.WriteLine("Ten: " + ten);
            }else
            {
                Console.Write("Vui long nhap lai ho ten");
            }
        }
    }
}

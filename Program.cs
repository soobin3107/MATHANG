using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATHANG
{
    public class MATHANG
    {
        public string TenMatHang {  get; set; }
        public int DonGia {  get; set; }
        public float SoLuongTon { get; set; }
    }

    public class NhapXuatMH
    {
        public static void NhapMH(ref MATHANG mh)
        {
            Console.Write("Nhập Tên Mặt Hàng: ");
            mh.TenMatHang = Console.ReadLine();

            Console.Write("Nhập Đơn Giá: ");
            mh.DonGia = int.Parse(Console.ReadLine());

            Console.Write("Nhập Số Lượng Tồn: ");
            mh.SoLuongTon = float.Parse(Console.ReadLine());
        }

        public static void XuatMH(MATHANG mh)
        {
            Console.WriteLine($"Tên Mặt Hàng: {mh.TenMatHang}");
            Console.WriteLine($"Đơn Giá: {mh.DonGia}");
            Console.WriteLine($"Số Lượng Tồn: {mh.SoLuongTon}");
        }
    }

    public class Program
    {
        const int N = 100;

        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            MATHANG[] a = new MATHANG[N];
            int n = 0;
            NhapDSMH(a, ref n);
            XuatDSMH(a, n);
            Console.ReadLine();
        }

        static void NhapDSMH(MATHANG[] a, ref int n)
        {
            Console.Write("Nhập số lượng Mặt Hàng: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new MATHANG();
                Console.WriteLine("---------------------------");
                Console.WriteLine($"---Mặt Hàng thứ {i + 1}---");
                NhapXuatMH.NhapMH(ref a[i]);
            }
        }

        static void XuatDSMH(MATHANG[] a, int n)
        {
            Console.WriteLine("\n=-=DANH SÁCH CÁC MẶT HÀNG=-=");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"---Mặt Hàng thứ {i + 1}---");
                NhapXuatMH.XuatMH(a[i]);
                Console.WriteLine("---------------------------");
            }
        }
    }

}

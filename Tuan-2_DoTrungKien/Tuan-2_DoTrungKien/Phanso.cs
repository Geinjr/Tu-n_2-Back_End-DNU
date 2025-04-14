using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        // Constructor
        public PhanSo(int tuSo = 0, int mauSo = 1)
        {
            TuSo = tuSo;
            MauSo = (mauSo == 0) ? 1 : mauSo; // tránh mẫu số = 0
        }

        // Nhập phân số
        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
            if (MauSo == 0)
            {
                Console.WriteLine("Mẫu số không thể bằng 0. Đặt lại mẫu số = 1.");
                MauSo = 1;
            }
        }

        // Hiển thị phân số
        public void HienThi()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

        // Cộng 2 phân số
        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            int tuMoi = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int mauMoi = a.MauSo * b.MauSo;
            return RutGon(new PhanSo(tuMoi, mauMoi));
        }

        // Rút gọn phân số
        public static PhanSo RutGon(PhanSo ps)
        {
            int ucln = UCLN(ps.TuSo, ps.MauSo);
            ps.TuSo /= ucln;
            ps.MauSo /= ucln;
            return ps;
        }

        // Tìm ước chung lớn nhất
        private static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}

using System;

namespace Bai_2
{
    // Lớp cha trừu tượng
    abstract class Hinh
    {
        public abstract double TinhChuVi();
        public abstract double TinhDienTich();
    }

    class HinhTron : Hinh
    {
        public double BanKinh { get; set; }

        public HinhTron(double r)
        {
            BanKinh = r;
        }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
    }

    class HinhVuong : Hinh
    {
        public double Canh { get; set; }

        public HinhVuong(double canh)
        {
            Canh = canh;
        }

        public override double TinhChuVi()
        {
            return 4 * Canh;
        }

        public override double TinhDienTich()
        {
            return Canh * Canh;
        }
    }

    class HinhChuNhat : Hinh
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public HinhChuNhat(double dai, double rong)
        {
            ChieuDai = dai;
            ChieuRong = rong;
        }

        public override double TinhChuVi()
        {
            return 2 * (ChieuDai + ChieuRong);
        }

        public override double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }
    }

    class HinhTamGiac : Hinh
    {
        public double a, b, c;

        public HinhTamGiac(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double TinhChuVi()
        {
            return a + b + c;
        }

        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // công thức Heron
        }
    }
}

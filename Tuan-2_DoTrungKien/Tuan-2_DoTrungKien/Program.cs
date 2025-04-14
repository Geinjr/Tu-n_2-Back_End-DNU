using System;
using System.Collections.Generic;
using Bai_1;
using Tuan_2_DoTrungKien;
//Bài 1
namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhanSo> danhSach = new List<PhanSo>();

            Console.Write("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phân số thứ {i + 1}:");
                PhanSo ps = new PhanSo();
                ps.Nhap();
                danhSach.Add(ps);
            }

            PhanSo tong = new PhanSo(0, 1);
            foreach (var ps in danhSach)
            {
                tong = PhanSo.Cong(tong, ps);
            }

            Console.WriteLine("Tổng các phân số:");
            tong.HienThi();
        }
    }
}


//Bài 2

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hinh> danhSachHinh = new List<Hinh>();

            // Thêm vài hình mẫu
            danhSachHinh.Add(new HinhTron(3));
            danhSachHinh.Add(new HinhVuong(4));
            danhSachHinh.Add(new HinhChuNhat(5, 2));
            danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

            double tongChuVi = 0;
            double tongDienTich = 0;

            foreach (var hinh in danhSachHinh)
            {
                tongChuVi += hinh.TinhChuVi();
                tongDienTich += hinh.TinhDienTich();
            }

            Console.WriteLine($"Tổng chu vi: {tongChuVi:F2}");
            Console.WriteLine($"Tổng diện tích: {tongDienTich:F2}");
        }
    }
}
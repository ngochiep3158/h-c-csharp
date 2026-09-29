using System;
using System.Collections.Generic;

// 1. Lớp cơ sở (Base class) đại diện cho Nhân viên chung
abstract class NhanVien
{
    // Thông tin cơ bản của nhân viên gồm: Mã nhân viên, họ tên
    public string MaNV { get; set; }
    public string HoTen { get; set; }

    public virtual void Nhap()
    {
        Console.Write("Nhap Ma NV: ");
        MaNV = Console.ReadLine()!;
        Console.Write("Nhap Ho ten: ");
        HoTen = Console.ReadLine()!;
    }

    // Phương thức trừu tượng để tính lương (đa hình)
    public abstract double TinhLuong();

    public virtual void Xuat()
    {
        Console.Write($"Ma NV: {MaNV} | Ho Ten: {HoTen} | Luong: {TinhLuong():N0} VND");
    }
}

// 2. Lớp Nhân viên kinh doanh kế thừa từ Nhân viên
class NhanVienKinhDoanh : NhanVien
{
    public double LuongCoBan { get; set; }
    public int SoHopDong { get; set; }

    public override void Nhap()
    {
        base.Nhap(); // Gọi lại hàm Nhap() của lớp cha
        Console.Write("Nhap Luong co ban: ");
        LuongCoBan = double.Parse(Console.ReadLine()!);
        Console.Write("Nhap So hop dong ky ket: ");
        SoHopDong = int.Parse(Console.ReadLine()!);
    }

    public override double TinhLuong()
    {
        // Ngoài lương cơ bản, nhận 500.000 trên 1 hợp đồng
        return LuongCoBan + (SoHopDong * 500000);
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine(" (NV Kinh Doanh)");
    }
}

// 3. Lớp Nhân viên sản xuất kế thừa từ Nhân viên
class NhanVienSanXuat : NhanVien
{
    public int SoSanPham { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap So luong san pham: ");
        SoSanPham = int.Parse(Console.ReadLine()!);
    }

    public override double TinhLuong()
    {
        // Lương tính theo số lượng sản phẩm x 1000
        double luong = SoSanPham * 1000;
        
        // Nếu làm trên 3000 sản phẩm được thưởng 5% lương
        if (SoSanPham > 3000)
        {
            luong += luong * 0.05; // Cộng thêm 5%
        }
        return luong;
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine(" (NV San Xuat)");
    }
}

// 4. Lớp Program chạy chương trình
class Program
{
    static void Main()
    {
        List<NhanVien> danhSachNV = new List<NhanVien>();

        Console.Write("Nhap so luong thu tu nhan vien can quan ly: ");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nChon loai nhan vien thu {i + 1}:");
            Console.WriteLine("1. Nhan vien Kinh Doanh");
            Console.WriteLine("2. Nhan vien San Xuat");
            Console.Write("Lua chon (1/2): ");
            int loai = int.Parse(Console.ReadLine()!);

            NhanVien nv; // Khai báo tham chiếu lớp cha
            if (loai == 1)
            {
                nv = new NhanVienKinhDoanh();
            }
            else
            {
                nv = new NhanVienSanXuat();
            }

            nv.Nhap(); // Tính đa hình: Tự động gọi đúng hàm Nhap() của lớp con
            danhSachNV.Add(nv);
        }

        Console.WriteLine("\n--- BANG LUONG NHAN VIEN ---");
        foreach (NhanVien nv in danhSachNV)
        {
            nv.Xuat(); // Tính đa hình: Tự động tính đúng lương và xuất đúng định dạng
        }

        Console.ReadLine();
    }
}
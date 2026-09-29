using System;
using System.Collections.Generic;

class NhanVien
{
    public string Ten { get; set; }
    public double LuongGoc { get; set; }
    public int NgayVang { get; set; }
    
    public NhanVien(string ten, double luong, int vang) 
    { 
        Ten = ten; 
        LuongGoc = luong; 
        NgayVang = vang; 
    }
    
    public double TinhLuong() 
    { 
        return LuongGoc - (NgayVang * 100000); 
    }

    public void Xuat()
    {
        // Sử dụng :N0 để định dạng số tiền có dấu phẩy phân cách hàng nghìn
        Console.WriteLine($"Ten: {Ten} | Luong goc: {LuongGoc:N0} | Vang: {NgayVang} ngay | Thuc lanh: {TinhLuong():N0} VND");
    }
}

class PhongBan
{
    // Sử dụng List để quản lý n nhân viên
    private List<NhanVien> dsNhanVien = new List<NhanVien>();

    public void Nhap(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap nhan vien {i + 1}:");
            
            Console.Write("Ten: "); 
            // Thêm ! để sửa warning CS8600/CS8604
            string ten = Console.ReadLine()!; 
            
            Console.Write("Luong goc (VND): "); 
            double luong = double.Parse(Console.ReadLine()!);
            
            Console.Write("Ngay vang: "); 
            int vang = int.Parse(Console.ReadLine()!);
            
            dsNhanVien.Add(new NhanVien(ten, luong, vang)); 
        }
    }

    public void Xuat()
    {
        foreach (NhanVien nv in dsNhanVien)
        {
            nv.Xuat();
        }
    }

    // Tính tổng lương của phòng ban
    public double TongLuongPhongBan()
    {
        double tong = 0;
        foreach (NhanVien nv in dsNhanVien)
        {
            tong += nv.TinhLuong();
        }
        return tong;
    }
}

// Lớp Program chứa hàm Main để chạy thử
class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong nhan vien trong phong ban (n): ");
        int n = int.Parse(Console.ReadLine()!);

        PhongBan pb = new PhongBan();
        
        Console.WriteLine("\n--- NHAP THONG TIN PHONG BAN ---");
        pb.Nhap(n);

        Console.WriteLine("\n--- DANH SACH NHAN VIEN ---");
        pb.Xuat();

        double tongLuong = pb.TongLuongPhongBan();
        Console.WriteLine($"\n=> TONG LUONG CUA PHONG BAN: {tongLuong:N0} VND");

        Console.ReadLine();
    }
}
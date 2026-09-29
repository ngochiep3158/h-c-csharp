using System;

class NhanVien
{
    // Các Fields lưu trữ trạng thái của nhân viên[cite: 30]
    string hoTen;
    double mucLuong;
    int soNgayVang;

    // Phương thức nhập thông tin
    public void Nhap()
    {
        Console.Write("Nhap ho ten nhan vien: ");
        hoTen = Console.ReadLine();
        
        Console.Write("Nhap muc luong goc (VND): ");
        mucLuong = double.Parse(Console.ReadLine());
        
        Console.Write("Nhap so ngay vang: ");
        soNgayVang = int.Parse(Console.ReadLine());
    }

    // Phương thức tính toán nghiệp vụ
    public double TinhLuong()
    {
        return mucLuong - (soNgayVang * 100000);
    }

    // Phương thức xuất kết quả
    public void Xuat()
    {
        Console.WriteLine("\n--- BANG LUONG NHAN VIEN ---");
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Muc luong goc: {0:N0} VND", mucLuong);
        Console.WriteLine("So ngay vang: " + soNgayVang);
        
        // Gọi hàm TinhLuong() ngay trong lúc xuất
        Console.WriteLine("Luong thuc lanh: {0:N0} VND", TinhLuong());
    }
}

class Program
{
    static void Main()
    {
        NhanVien nv1 = new NhanVien();
        
        Console.WriteLine("NHAP THONG TIN NHAN VIEN");
        nv1.Nhap();
        nv1.Xuat();
        
        Console.ReadLine();
    }
}
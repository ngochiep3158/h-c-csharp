using System;

// Định nghĩa lớp cơ bản theo cú pháp: class <ClassName>
class SinhVien
{
    // Khai báo các Fields (biến thành viên) để lưu giữ giá trị của đối tượng
    // Mặc định nếu không ghi bổ từ truy cập, các thành viên này sẽ là private
    string maSV;
    string hoTen;
    string diaChi;
    int namThuMay;

    // Khai báo Method (phương thức) nhập thông tin
    public void Nhap()
    {
        Console.Write("Nhap ma sinh vien: ");
        maSV = Console.ReadLine();
        
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        
        Console.Write("Nhap dia chi: ");
        diaChi = Console.ReadLine();
        
        Console.Write("Nhap sinh vien nam thu may: ");
        namThuMay = int.Parse(Console.ReadLine());
    }

    // Khai báo Method (phương thức) xuất thông tin[cite: 28]
    public void Xuat()
    {
        Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
        Console.WriteLine("Ma SV: " + maSV);
        Console.WriteLine("Ho Ten: " + hoTen);
        Console.WriteLine("Dia Chi: " + diaChi);
        Console.WriteLine("Sinh vien nam thu: " + namThuMay);
    }
}

class Program
{
    static void Main()
    {
        // Tạo một đối tượng (instance) từ lớp SinhVien
        SinhVien sv1 = new SinhVien();
        
        Console.WriteLine("NHAP THONG TIN SINH VIEN");
        sv1.Nhap();
        sv1.Xuat();
        
        Console.ReadLine();
    }
}
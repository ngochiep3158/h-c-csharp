using System;
using System.Collections.Generic;

// 1. Lớp cơ sở: Thí sinh
abstract class ThiSinh
{
    // Thông tin chung của các thí sinh: sbd, hoten, bai1, bai2, bai3, tongdiem[cite: 45]
    public string SBD { get; set; }
    public string HoTen { get; set; }
    public double Bai1 { get; set; }
    public double Bai2 { get; set; }
    public double Bai3 { get; set; }
    public double TongDiem { get; protected set; } // Chỉ lớp con mới được gán giá trị

    public virtual void Nhap()
    {
        Console.Write("SBD: "); SBD = Console.ReadLine()!;
        Console.Write("Ho ten: "); HoTen = Console.ReadLine()!;
        Console.Write("Diem Bai 1: "); Bai1 = double.Parse(Console.ReadLine()!);
        Console.Write("Diem Bai 2: "); Bai2 = double.Parse(Console.ReadLine()!);
        Console.Write("Diem Bai 3: "); Bai3 = double.Parse(Console.ReadLine()!);
    }

    public abstract void TinhTongDiem();

    public virtual void Xuat()
    {
        Console.Write($"SBD: {SBD,-5} | Ten: {HoTen,-15} | Tong diem: {TongDiem}");
    }
}

// 2. Lớp Thí sinh Chuyên
class ThiSinhChuyen : ThiSinh
{
    // Thông tin riêng cho đối tượng Chuyên: tiengAnh[cite: 45]
    public double TiengAnh { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Diem Tieng Anh: ");
        TiengAnh = double.Parse(Console.ReadLine()!);
    }

    public override void TinhTongDiem()
    {
        // Tổng 3 bài thi lập trình + điểm thưởng tiếng Anh[cite: 45]
        double diemThuong = 0;
        if (TiengAnh >= 7 && TiengAnh <= 8)
        {
            diemThuong = 1; // 7 <= tiengAnh <= 8: cộng 1 điểm[cite: 45]
        }
        else if (TiengAnh >= 9 && TiengAnh <= 10)
        {
            diemThuong = 2; // 9 <= tiengAnh <= 10: cộng 2 điểm[cite: 45]
        }

        TongDiem = Bai1 + Bai2 + Bai3 + diemThuong;
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine(" (TS Chuyen)");
    }
}

// 3. Lớp Thí sinh Siêu cúp
class ThiSinhSieuCup : ThiSinh
{
    // Thông tin riêng cho đối tượng Siêu cúp: csdl[cite: 45]
    public double CSDL { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Diem CSDL: ");
        CSDL = double.Parse(Console.ReadLine()!);
    }

    public override void TinhTongDiem()
    {
        // Thí sinh Siêu cúp: Tổng điểm của 4 bài thi[cite: 45]
        TongDiem = Bai1 + Bai2 + Bai3 + CSDL;
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine(" (TS Sieu Cup)");
    }
}

// 4. Lớp Cuộc thi quản lý danh sách thí sinh[cite: 45]
class CuocThi
{
    private List<ThiSinh> danhSachTS = new List<ThiSinh>();

    public void Nhap()
    {
        Console.Write("Nhap so luong thi sinh: ");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nLoai thi sinh thu {i + 1} (1: Chuyen, 2: Sieu Cup): ");
            int loai = int.Parse(Console.ReadLine()!);
            
            ThiSinh ts;
            if (loai == 1) ts = new ThiSinhChuyen();
            else ts = new ThiSinhSieuCup();

            ts.Nhap();
            ts.TinhTongDiem(); // Tính điểm ngay sau khi nhập
            danhSachTS.Add(ts);
        }
    }

    public void XuatKetQua()
    {
        Console.WriteLine("\n--- DANH SACH KET QUA THI SINH ---");
        foreach (ThiSinh ts in danhSachTS)
        {
            ts.Xuat();
        }
    }
}

// 5. Chương trình chính
class Program
{
    static void Main()
    {
        CuocThi cuocThiTinHoc = new CuocThi();
        cuocThiTinHoc.Nhap();
        cuocThiTinHoc.XuatKetQua();
        
        Console.ReadLine();
    }
}
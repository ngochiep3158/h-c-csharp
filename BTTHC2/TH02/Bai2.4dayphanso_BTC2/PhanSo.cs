using System;

class PhanSo
{
    public int Tu { get; set; }
    public int Mau { get; set; }
    
    public PhanSo(int t, int m) 
    { 
        Tu = t; 
        Mau = (m == 0) ? 1 : m; // Tránh lỗi mẫu số bằng 0
    }
    
    // Nạp chồng toán tử cộng để tính tổng dễ dàng
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
    }
    
    public override string ToString() 
    { 
        return $"{Tu}/{Mau}"; 
    }
}

class DayPhanSo
{
    private PhanSo[] arr;
    private int n;

    public DayPhanSo(int n)
    {
        this.n = n;
        arr = new PhanSo[n];
    }

    public void Nhap()
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap phan so {i + 1}:");
            
            Console.Write("Tu so: "); 
            // Thêm ! để sửa warning CS8604
            int tu = int.Parse(Console.ReadLine()!); 
            
            Console.Write("Mau so: "); 
            int mau = int.Parse(Console.ReadLine()!);
            
            arr[i] = new PhanSo(tu, mau);
        }
    }

    public void Xuat()
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i].ToString() + "   ");
        }
        Console.WriteLine();
    }

    // Tính tổng của n phân số đó
    public PhanSo TinhTong()
    {
        if (n == 0) return new PhanSo(0, 1); // Trả về 0/1 nếu dãy rỗng
        
        PhanSo tong = arr[0];
        for (int i = 1; i < n; i++)
        {
            // Sử dụng toán tử + đã nạp chồng ở lớp PhanSo
            tong = tong + arr[i]; 
        }
        return tong;
    }
}

// Lớp Program chứa hàm Main để chạy thử
class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong phan so trong day (n): ");
        int n = int.Parse(Console.ReadLine()!);

        DayPhanSo day = new DayPhanSo(n);

        Console.WriteLine("\n--- NHAP DAY PHAN SO ---");
        day.Nhap();

        Console.WriteLine("\n--- DAY PHAN SO VUA NHAP ---");
        day.Xuat();

        PhanSo tong = day.TinhTong();
        Console.WriteLine($"\nTong cua {n} phan so la: {tong}");

        Console.ReadLine();
    }
}
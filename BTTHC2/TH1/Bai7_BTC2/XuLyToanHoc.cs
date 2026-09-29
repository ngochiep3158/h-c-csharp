using System;

class XuLyToanHoc
{
    // Phương thức trả về kiểu bool (true/false)
    public bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}

class Program
{
    static void Main()
    {
        XuLyToanHoc toanHoc = new XuLyToanHoc();
        
        Console.Write("Nhap so nguyen n can kiem tra: ");
        int n = int.Parse(Console.ReadLine());

        if (toanHoc.KiemTraNguyenTo(n))
        {
            Console.WriteLine(n + " la so nguyen to.");
        }
        else
        {
            Console.WriteLine(n + " khong phai la so nguyen to.");
        }
        
        Console.ReadLine();
    }
}
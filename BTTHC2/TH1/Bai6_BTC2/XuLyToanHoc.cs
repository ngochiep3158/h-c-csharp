using System;

class XuLyToanHoc
{
    // Phương thức truyền tham trị, trả về giá trị kiểu int
    public int TimMax3SoNguyen(int a, int b, int c)
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }
}

class Program
{
    static void Main()
    {
        XuLyToanHoc toanHoc = new XuLyToanHoc();
        
        Console.Write("Nhap so nguyen thu 1: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen thu 2: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen thu 3: ");
        int z = int.Parse(Console.ReadLine());

        int ketQua = toanHoc.TimMax3SoNguyen(x, y, z);
        Console.WriteLine("Gia tri lon nhat la: " + ketQua);
        
        Console.ReadLine();
    }
}
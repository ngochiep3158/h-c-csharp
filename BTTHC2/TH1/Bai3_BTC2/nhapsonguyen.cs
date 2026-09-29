using System;

class Bai3_NhapSoNguyen
{
    static void Main()
    {
        Console.Write("Nhap so nguyen x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Nhap so nguyen y: ");
        int y = int.Parse(Console.ReadLine());

        // Tính lũy thừa bằng hàm Math.Pow. Ép kiểu về long để kết quả hiển thị số nguyên
        long ketQua = (long)Math.Pow(x, y);

        // Xuất kết quả theo định dạng yêu cầu
        Console.WriteLine("Ket qua {0} mu {1} la: {2}", x, y, ketQua);
        
        Console.ReadLine();
    }
}
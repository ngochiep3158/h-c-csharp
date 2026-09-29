using System;

class xykhongphailasonguyen
{
    static void Main()
    {
        int x, y;

        // Nhập và kiểm tra số x
        Console.Write("Nhap so nguyen x: ");
        string inputX = Console.ReadLine();
        if (!int.TryParse(inputX, out x))
        {
            Console.WriteLine("Loi: x khong phai la so nguyen hop le!");
            Console.ReadLine();
            return; // Dừng chương trình nếu lỗi
        }

        // Nhập và kiểm tra số y
        Console.Write("Nhap so nguyen y: ");
        string inputY = Console.ReadLine();
        if (!int.TryParse(inputY, out y))
        {
            Console.WriteLine("Loi: y khong phai la so nguyen hop le!");
            Console.ReadLine();
            return; // Dừng chương trình nếu lỗi
        }

        // Tính và xuất kết quả nếu cả 2 đều hợp lệ
        long ketQua = (long)Math.Pow(x, y);
        Console.WriteLine("Ket qua {0} mu {1} la: {2}", x, y, ketQua);
        
        Console.ReadLine();
    }
}
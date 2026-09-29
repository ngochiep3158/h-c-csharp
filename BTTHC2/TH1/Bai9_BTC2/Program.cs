using System;

class XuLyToanHoc
{
    // Dùng tham số out để trả về cùng lúc 2 giá trị max và min
    public void TimMaxMin3SoThuc(double a, double b, double c, out double max, out double min)
    {
        // Tham số out bắt buộc phải được gán giá trị trước khi kết thúc hàm
        max = a;
        min = a;

        // Tìm Max
        if (b > max) max = b;
        if (c > max) max = c;

        // Tìm Min
        if (b < min) min = b;
        if (c < min) min = c;
    }
}

class Program
{
    static void Main()
    {
        XuLyToanHoc toanHoc = new XuLyToanHoc();
        
        double so1 = 7.4, so2 = 1.2, so3 = 5.9;
        
        // Biến out không cần gán giá trị ban đầu
        double ketQuaMax;
        double ketQuaMin;

        toanHoc.TimMaxMin3SoThuc(so1, so2, so3, out ketQuaMax, out ketQuaMin);

        Console.WriteLine("Ba so thuc la: {0}, {1}, {2}", so1, so2, so3);
        Console.WriteLine("Gia tri lon nhat: " + ketQuaMax);
        Console.WriteLine("Gia tri nho nhat: " + ketQuaMin);
        
        Console.ReadLine();
    }
}
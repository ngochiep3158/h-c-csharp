using System;

class XuLyToanHoc
{
    // Sử dụng từ khóa ref để truyền tham chiếu
    public void HoanVi(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }
}

class Program
{
    static void Main()
    {
        XuLyToanHoc toanHoc = new XuLyToanHoc();
        
        // Bắt buộc phải khởi tạo giá trị trước khi truyền vào hàm có ref
        double x = 3.5;
        double y = 9.2;

        Console.WriteLine("Truoc khi hoan vi: x = {0}, y = {1}", x, y);
        
        // Gọi hàm và truyền địa chỉ biến bằng từ khóa ref
        toanHoc.HoanVi(ref x, ref y);
        
        Console.WriteLine("Sau khi hoan vi: x = {0}, y = {1}", x, y);
        
        Console.ReadLine();
    }
}
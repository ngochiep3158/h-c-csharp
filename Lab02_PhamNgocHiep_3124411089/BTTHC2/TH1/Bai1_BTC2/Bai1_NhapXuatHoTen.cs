using System;

namespace Buoi01Prj
{
    class Bai1_NhapXuatHoTen
    {
        static void Main(string[] args)
        {
            string hoTen;

            // Dùng Console.Write để con trỏ chuột không bị rớt xuống dòng, tạo thẩm mỹ khi nhập liệu
            Console.Write("Vui long nhap ho va ten cua ban: ");

            // Đọc dữ liệu người dùng nhập vào từ bàn phím
            hoTen = Console.ReadLine();

            // Dùng Console.WriteLine để in chuỗi định dạng và tự động xuống dòng sau khi in xong
            Console.WriteLine("Ho ten ban vua nhap la: {0}", hoTen);

            // Dừng màn hình 
            Console.ReadLine();
        }
    }
}
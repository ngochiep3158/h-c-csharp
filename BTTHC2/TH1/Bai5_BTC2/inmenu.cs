using System;

class inmenu
{
    static void Main()
    {
        int chon;
        double x = 0, y = 0;
        bool daNhap = false; // Cờ kiểm tra xem người dùng đã nhập x, y chưa

        do
        {
            // In Menu ra màn hình
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            
            // Đọc lựa chọn của người dùng
            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Loi: Vui long nhap so tu 1 den 4.");
                continue;
            }

            // Xử lý các lựa chọn
            switch (chon)
            {
                case 1:
                    Console.Write("Nhap so thuc x: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Nhap so thuc y: ");
                    y = double.Parse(Console.ReadLine());
                    daNhap = true;
                    break;

                case 2:
                    if (!daNhap)
                    {
                        Console.WriteLine("Vui long chon 1 de nhap gia tri cho x va y truoc!");
                    }
                    else
                    {
                        Console.WriteLine("Ket qua {0}^{1} = {2}", x, y, Math.Pow(x, y));
                    }
                    break;

                case 3:
                    if (!daNhap)
                    {
                        Console.WriteLine("Vui long chon 1 de nhap gia tri cho x va y truoc!");
                    }
                    else
                    {
                        // Kiểm tra điều kiện số không âm trước khi tính căn bậc 2
                        if (x >= 0) Console.WriteLine("Can bac 2 cua {0} = {1}", x, Math.Sqrt(x));
                        else Console.WriteLine("Khong the tinh can bac 2 cua so am x = {0}", x);

                        if (y >= 0) Console.WriteLine("Can bac 2 cua {0} = {1}", y, Math.Sqrt(y));
                        else Console.WriteLine("Khong the tinh can bac 2 cua so am y = {0}", y);
                    }
                    break;

                case 4:
                    Console.WriteLine("Da thoat chuong trinh.");
                    break;

                default:
                    Console.WriteLine("Chuc nang khong ton tai. Vui long chon lai tu 1 den 4.");
                    break;
            }
        } while (chon != 4);
    }
}
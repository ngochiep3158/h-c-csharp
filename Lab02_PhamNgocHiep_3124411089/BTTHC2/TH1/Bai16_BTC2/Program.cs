    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so luong nguoi (n): ");
            int n = int.Parse(Console.ReadLine());
            
            // Khởi tạo mảng chuỗi
            string[] danhSachTen = new string[n];
            
            // Nhập mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ho ten nguoi thu {0}: ", i + 1);
                danhSachTen[i] = Console.ReadLine();
            }
            
            // Sắp xếp mảng tăng dần sử dụng phương thức tĩnh Sort của System.Array
            Array.Sort(danhSachTen);
            
            // In mảng sau khi sắp xếp
            Console.WriteLine("\n--- DANH SACH SAU KHI SAP XEP TANG DAN ---");
            foreach (string ten in danhSachTen)
            {
                Console.WriteLine(ten);
            }
            
            Console.ReadLine();
        }
    }
    
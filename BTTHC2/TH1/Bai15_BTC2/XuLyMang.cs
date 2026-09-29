using System;
using System.Collections.Generic;

class XuLyMang
{
    // 1. Nhập mảng gồm n phần tử
    public int[] NhapMang(int n)
    {
        // Khởi tạo mảng 1 chiều với kích thước n
        int[] arr = new int[n]; 
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu {0}: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }

    // 2. In mảng ra màn hình
    public void InMang(int[] arr)
    {
        // Sử dụng vòng lặp foreach để truy cập dữ liệu
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // 3. Tìm phần tử lớn nhất và nhỏ nhất
    public void TimMaxMin(int[] arr, out int max, out int min)
    {
        max = arr[0];
        min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
    }

    // Hàm phụ kiểm tra số nguyên tố
    private bool LaNguyenTo(int so)
    {
        if (so < 2) return false;
        for (int i = 2; i <= Math.Sqrt(so); i++)
        {
            if (so % i == 0) return false;
        }
        return true;
    }

    // 4. Trả về mảng các số nguyên tố
    public int[] MangNguyenTo(int[] arr)
    {
        // Dùng List để lưu trữ linh hoạt vì chưa biết trước có bao nhiêu số nguyên tố
        List<int> danhSachNT = new List<int>();
        foreach (int item in arr)
        {
            if (LaNguyenTo(item))
            {
                // Thêm dữ liệu vào List
                danhSachNT.Add(item);
            }
        }
        // Trả về dạng mảng
        return danhSachNT.ToArray();
    }
}

class Program
{
    static void Main()
    {
        XuLyMang xl = new XuLyMang();
        
        Console.Write("Nhap so luong phan tu n: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] mang = xl.NhapMang(n);
        
        Console.Write("\nMang vua nhap la: ");
        xl.InMang(mang);
        
        int max, min;
        xl.TimMaxMin(mang, out max, out min);
        Console.WriteLine("Phan tu lon nhat: {0}, Nho nhat: {1}", max, min);
        
        int[] mangNT = xl.MangNguyenTo(mang);
        Console.Write("Cac so nguyen to trong mang la: ");
        xl.InMang(mangNT);
        
        Console.ReadLine();
    }
}
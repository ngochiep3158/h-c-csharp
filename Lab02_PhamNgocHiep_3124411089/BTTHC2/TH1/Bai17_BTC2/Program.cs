using System;
using System.Collections.Generic;

class XuLyMang2Chieu
{
    // 1. Sinh ngẫu nhiên mảng A[nxm]
    public int[,] SinhMang(int n, int m)
    {
        // Khởi tạo mảng nhiều chiều: type[,] arrayName = new type[n1, n2];[cite: 29, 30]
        int[,] arr = new int[n, m];
        Random rnd = new Random();
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                // Sinh số ngẫu nhiên từ 10 đến 100
                arr[i, j] = rnd.Next(10, 101);
            }
        }
        return arr;
    }

    // 2. In mảng ra màn hình
    public void InMang(int[,] arr)
    {
        int dong = arr.GetLength(0); // Lấy số dòng[cite: 32]
        int cot = arr.GetLength(1);  // Lấy số cột[cite: 32]
        
        for (int i = 0; i < dong; i++)
        {
            for (int j = 0; j < cot; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // 3. Trả về hai mảng chẵn và lẻ
    public void TachChanLe(int[,] arr, out int[] mangChan, out int[] mangLe)
    {
        // Sử dụng Collections (List) để lưu trữ linh hoạt[cite: 33]
        List<int> listChan = new List<int>();
        List<int> listLe = new List<int>();
        
        foreach (int item in arr) // foreach duyệt qua mọi phần tử của mảng 2 chiều
        {
            if (item % 2 == 0)
            {
                listChan.Add(item); // Thêm phần tử[cite: 34]
            }
            else
            {
                listLe.Add(item); // Thêm phần tử[cite: 34]
            }
        }
        
        mangChan = listChan.ToArray();
        mangLe = listLe.ToArray();
    }
}

class Program
{
    static void Main()
    {
        XuLyMang2Chieu xl2D = new XuLyMang2Chieu();
        
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine());
        
        // Sinh và in mảng
        int[,] mang2D = xl2D.SinhMang(n, m);
        Console.WriteLine("\nMANG 2 CHIEU VUA SINH:");
        xl2D.InMang(mang2D);
        
        // Tách chẵn lẻ
        int[] chan, le;
        xl2D.TachChanLe(mang2D, out chan, out le);
        
        Console.WriteLine("\nMang cac so chan:");
        foreach(int c in chan) Console.Write(c + " ");
        
        Console.WriteLine("\n\nMang cac so le:");
        foreach(int l in le) Console.Write(l + " ");
        
        Console.ReadLine();
    }
}
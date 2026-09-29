using System;
using System.Collections.Generic;

class DaySoNguyen
{
    private int[] arr;
    private int n;

    // Các loại Constructor
    public DaySoNguyen() { n = 0; arr = new int[0]; }
    public DaySoNguyen(int n) { this.n = n; arr = new int[n]; }

    // Indexer để truy cập phần tử thứ i trong dãy
    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }

    // Nhập dãy số
    public void Nhap()
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            // Thêm dấu ! để báo hệ thống không bị null
            arr[i] = int.Parse(Console.ReadLine()!); 
        }
    }

    // Xuất dãy số
    public void Xuat()
    {
        for (int i = 0; i < n; i++) Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    // Tìm các số chẵn
    public List<int> TimSoChan()
    {
        List<int> chan = new List<int>();
        foreach (int item in arr)
        {
            if (item % 2 == 0) chan.Add(item); 
        }
        return chan;
    }
}

// Bổ sung class Program để chạy thử
class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong phan tu cua day so: ");
        int n = int.Parse(Console.ReadLine()!);
        
        // Khởi tạo đối tượng dãy số
        DaySoNguyen daySo = new DaySoNguyen(n);
        
        Console.WriteLine("\n--- NHAP DAY SO ---");
        daySo.Nhap();
        
        Console.WriteLine("\n--- DAY SO VUA NHAP ---");
        daySo.Xuat();
        
        // Gọi hàm tìm số chẵn và in kết quả
        List<int> dsChan = daySo.TimSoChan();
        Console.WriteLine("\n--- CAC SO CHAN TRONG DAY ---");
        if (dsChan.Count > 0)
        {
            foreach (int so in dsChan)
            {
                Console.Write(so + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Khong co so chan nao!");
        }
        
        Console.ReadLine();
    }
}
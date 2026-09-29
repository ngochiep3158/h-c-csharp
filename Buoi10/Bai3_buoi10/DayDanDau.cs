using System;
class DayDanDau
{
    public static void nhapdayso(ref double[] day)
    {
        int n, i;
        //nhap so luong phan tu
        Console.Write("nhap so luong phan tu :");
        n = int.Parse(Console.ReadLine());
        //tao mang
        day = new double[n];
        //nhap gia tri
        for (i=0; i<n; i++)
        {
            Console.Write("nhap phan tu thu {0};", i);
            day[i] = double.Parse(Console.ReadLine());
        }
    } 
    public static void indayso(double[] day)
    {
        //in day so
        Console.Write("day so co {0} phan tu; ", day.Length);
        // duyet day so
        for (int i=0; i<day.Length; i++)
        {
            Console.Write("{0} ", day[i]);
        }
        Console.WriteLine();
    }
    public static bool demdaydan(double[] day)
    {
        if (day.Length < 2)
        {
            Console.WriteLine("day so khong co phan tu ke nhau");
            return false;
        }
        bool co = true; // gan co
        for (int i=0; i<day.Length-1; i++)
        {
            if (day[i] * day[i + 1] >= 0)
            {
                co = false;
                break;
            }
        }
        // in ket qua kiem tra co
        if (co == true)
        {
            Console.WriteLine("day so la day dan dau");
        }
        else
        {
            Console.WriteLine("day so khong phai la day dan dau");
        }
        return co;
    }
    public static void Main(string[] args)
    {
        double[] day = { -2, 5, -3, 4, -6, 2, -1 };
        bool kq;
        // xu ly
        kq = demdaydan(day);
        // ket qua
        if (kq == true)
        {
            Console.WriteLine("day so la day dan dau");
        }
        else
        {
            Console.WriteLine("day so khong phai la day dan dau");
        }
    }
}
using System;
class KeNhauTraiDau
{
    public static void NhapDaySo(ref double[] day)
    {
        int n,i;
        //nhap so luong phan tu
        Console.Write("nhap so luong phan tu :");
        n = int.Parse(Console.ReadLine());
        // tao mang
        day = new double[n];
        // nhap gia tri
        for (i=0; i<n; i++)
        {
            Console.Write("nhap phan tu thu {0}:", i);
            day[i] = double.Parse(Console.ReadLine());
        }
    }
    public static void indayso(double[] day)
    {
        // in day so
        Console.Write("day so co {0} phan tu;", day.Length);
        // duyet day so
        for (int i=0; i<day.Length; i++)
        {
            Console.Write("{0} ", day[i]);
        }
        Console.WriteLine();
    }
    public static int phantukhacgiaukenhau(double[] day, ref int dem)
    {
        dem =0;
        for (int i=0; i<day.Length-1; i++)
        {
            
            if (day[i] * day[i+1] < 0)
            {
                dem++;
            }  
        }
        return dem;
    }
    public static void Main()
    {
        Console.WriteLine("// Nhap day so");
        
        // Khởi tạo cứng dãy số để in ra màn hình giống hệt ví dụ
        double[] day = { -2, 5, -3, -4, -6, 2, 1 };
        int dem = 0;

        // In mảng
        indayso(day);

        // Chạy hàm đếm
        int ketQua = phantukhacgiaukenhau(day, ref dem);

        // In kết quả
        Console.WriteLine("So luong cac phan tu ke nhau ma trai dau: {0}.", ketQua);
    }
}
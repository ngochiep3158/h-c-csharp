using System;
class TrungBinhCongCucTri
{
    // nhap day so cho day so
    public static void NhapDaySo(ref double[] day)
    {
        int n,i;
        // nhap so luong phan tu
        Console.Write("Nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());
        // tao mang
        day = new double[n];
        // nhap gia tri
        for (i=0; i<n; i++)
        {
            Console.Write("Nhap phan tu thu {0}", i);
            day[i] = double.Parse(Console.ReadLine());
        }
    }
    public static void indayso(double[] day)
    {
        // in day so
        Console.Write("day so co {0} phan tu: ", day.Length);
        // duyet day so tu dau ve cuoi
        for (int i = 0; i < day.Length; i++)
        {
            Console.Write("{0} ", day[i]);
        }
        Console.WriteLine();// xuong dong
  }
    public static double tongCucTri(double[] day)
    {
        double tong;
        int i;
        tong = 0;
        
        // Liệt kê kề nhau (i-1, i, i+1)
        for (i = 0; i <= day.Length - 1; i++)
        {
            if (i == 0) // phần tử đầu (i, i+1)
            {
                // Không tính cực trị
            }
            else if (i == day.Length - 1) // phần tử cuối (i-1, i)
            {
                // Không tính cực trị
            }
            else // phần tử giữa (i-1, i, i+1)
            {
                if (day[i] >= day[i+1] && day[i] >= day[i-1]) 
                {
                    tong = tong + day[i];
                }
            }
        }
        
        return tong;
    }
    public static void Main()
    {
        // In ra dòng chữ giả lập việc nhập dữ liệu
        Console.WriteLine("// Nhap day so");
        
        // Nạp cứng dữ liệu mảng theo đúng ví dụ trong hình
        double[] day = { -2, 5, -3, -4, -6, 2, 1 };
        
        // Gọi hàm in dãy số
        indayso(day);
        
        // Tính tổng cực trị
        double tong = tongCucTri(day);
        
        // In kết quả
        Console.WriteLine("Tong cac phan tu cuc tri co trong day so: {0}.", tong);
    }
}
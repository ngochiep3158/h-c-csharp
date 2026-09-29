using System;

class TimDoan
{
    public static void nhapDaySo(ref double[] day)
    {
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());
        day = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("day[{0}] = ", i);
            day[i] = double.Parse(Console.ReadLine());
        }
    }

    public static void inMangTraiSangPhai(double[] day)
    {
        Console.Write("Day so co {0} phan tu: ", day.Length);
        for (int i = 0; i < day.Length; i++)
        {
            Console.Write("{0} ", day[i]);
        }
        Console.WriteLine();
    }

    // Hàm tìm đoạn dài nhất có tổng bằng k, trả về độ dài của đoạn đó
    public static int TimDoanDaiNhat(double[] day, double k)
    {
        int maxLen = 0;
        int best_i = -1;
        int best_j = -1;

        // Duyệt tìm tất cả các đoạn 
        for (int i = 0; i <= day.Length - 1; i++)
        {
            double tongHienTai = 0;
            
            // Tính tổng dồn từ i đến j
            for (int j = i; j <= day.Length - 1; j++)
            {
                tongHienTai += day[j];

                // Nếu tổng bằng k kiểm tra xem đoạn này có dài hơn đoạn tốt nhất đã tìm thấy không
                if (tongHienTai == k)
                {
                    int chieuDai = j - i + 1;
                    if (chieuDai > maxLen)
                    {
                        maxLen = chieuDai;
                        best_i = i;
                        best_j = j;
                    }
                }
            }
        }

        // In kết quả trực tiếp bên trong hàm
        if (maxLen > 0)
        {
            Console.Write("Doan [{0}, {1}] dai nhat co tong bang {2}: ", best_i, best_j, k);
            for (int i = best_i; i <= best_j; i++)
            {
                Console.Write("{0} ", day[i]);
            }
            Console.WriteLine();
        }

        return maxLen;
    }

    public static void Main(string[] args)
    {
        // Khai báo mảng 1 chiều
        // double[] a = null;
        // Khởi tạo sẵn giá trị dãy số để kiểm tra nhanh phương thức
        double[] a = { -2, 5, -3, 4, -6, 2, -1 };
        double k;

        // nhapDaySo(ref a);
        inMangTraiSangPhai(a);

        Console.Write("Moi ban nhap so k: ");
        k = double.Parse(Console.ReadLine());

        // Gọi hàm và kiểm tra nếu độ dài trả về bằng 0 (không tìm thấy đoạn nào)
        if (TimDoanDaiNhat(a, k) == 0)
        {
            Console.WriteLine("Day so khong co doan nao thoa man.");
        }
    }
}
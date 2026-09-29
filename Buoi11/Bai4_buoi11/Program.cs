using System;

class DaoDay
{
    // Hàm in dãy số
    public static void inMangTraiSangPhai(int[] day)
    {
        Console.Write("Day so co {0} phan tu: ", day.Length);
        for (int i = 0; i < day.Length; i++)
        {
            Console.Write("{0} ", day[i]);
        }
        Console.WriteLine();
    }

    // Hàm xử lý chính: Đảo ngược mảng
    public static void daoNguocDay(int[] day)
    {
        int n = day.Length;
        // Chỉ cần duyệt đến một nửa mảng (n / 2)
        for (int i = 0; i < n / 2; i++)
        {
            // Hoán vị phần tử đầu (i) và phần tử đối xứng ở cuối (n - 1 - i)
            int tmp = day[i];
            day[i] = day[n - 1 - i];
            day[n - 1 - i] = tmp;
        }
    }

    public static void Main(string[] args)
    {
        // Khởi tạo mảng với dãy số mẫu trong đề bài
        int[] a = { 2, 4, 3, 4, 2, 8, 2, 5 };

        Console.WriteLine("* Mang truoc đao: ");
        inMangTraiSangPhai(a);

        // Gọi hàm đảo dãy
        daoNguocDay(a);

        Console.WriteLine("* Mang sau khi đao: ");
        inMangTraiSangPhai(a);
    }
}
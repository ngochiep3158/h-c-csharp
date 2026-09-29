using System;

class SapChanLe
{
    public static void inMangTraiSangPhai(int[] day)
    {
        Console.Write("Day so co {0} phan tu: ", day.Length);
        for (int i = 0; i < day.Length; i++)
        {
            Console.Write("{0} ", day[i]);
        }
        Console.WriteLine();
    }

    public static void sapXepChanLe(int[] day)
    {
        // Duyệt tất cả các cặp trong dãy số
        for (int i = 0; i <= day.Length - 2; i++)
        {
            for (int j = i + 1; j <= day.Length - 1; j++)
            {
                // Biến cờ để đánh dấu 
                bool nghichThe = false;

                // Số đứng trước là lẻ, số đứng sau là chẵn (không đúng thứ tự)
                if (day[i] % 2 != 0 && day[j] % 2 == 0)
                {
                    nghichThe = true;
                }
                // Hai số cùng chẵn, nhưng số trước > số sau (không tăng dần)
                else if (day[i] % 2 == 0 && day[j] % 2 == 0 && day[i] > day[j])
                {
                    nghichThe = true;
                }
                // Hai số cùng lẻ, nhưng số trước < số sau (không giảm dần)
                else if (day[i] % 2 != 0 && day[j] % 2 != 0 && day[i] < day[j])
                {
                    nghichThe = true;
                }

                // Nếu phát hiện nghịch thế thì tiến hành hoán vị
                if (nghichThe)
                {
                    // Hoán vị cặp (day[i], day[j])
                    int tmp = day[i];
                    day[i] = day[j];
                    day[j] = tmp;
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        // Khai báo mảng 1 chiều
        // int[] a = null;
        // Khởi tạo sẵn giá trị dãy số để kiểm tra nhanh phương thức
        int[] a = { 2, 4, 3, 4, 2, 8, 2, 5 };

        // Xử lý
        // nhapDaySo(ref a);

        // Kết quả
        Console.WriteLine("* Mang truoc khi sap xep: ");
        inMangTraiSangPhai(a);

        sapXepChanLe(a);

        Console.WriteLine("* Mang sau khi sap xep: ");
        inMangTraiSangPhai(a);
    }
}
using System;

class ThemChanLe
{
    // Hàm in dãy số từ trái sang phải
    public static void inMangTraiSangPhai(int[] day)
    {
        Console.Write("Day so co {0} phan tu: ", day.Length);
        for (int i = 0; i < day.Length; i++)
        {
            Console.Write("{0} ", day[i]);
        }
        Console.WriteLine();
    }

    // Hàm hỗ trợ: Nới rộng dãy thêm n phần tử 
    public static int[] noiRongDay(int[] day, int n)
    {
        // Tạo mảng mới lớn hơn mảng cũ n ô
        int[] mangMoi = new int[day.Length + n];
        
        // Chép dữ liệu từ mảng cũ sang mảng mới
        for (int i = 0; i < day.Length; i++)
        {
            mangMoi[i] = day[i];
        }
        return mangMoi;
    }

    // Hàm mẫu: Thêm 1 phần tử vào vị trí cho trước 
    public static void them1PhanTu(ref int[] day, int viTri, int giaTri)
    {
        // Nới rộng 1 phần tử
        day = noiRongDay(day, 1);

        // Dời các phần tử 
        for (int i = day.Length - 2; i >= viTri; i--)
        {
            day[i + 1] = day[i];
        }

        // Chép giá trị thêm vào vị trí
        day[viTri] = giaTri;
    }

    //Thêm số lẻ vào giữa 2 số chẵn liên tiếp
    public static void themPhanTuLeVaoGiua(ref int[] day)
    {
        // Duyệt mảng từ đầu đến kế cuối
        for (int i = 0; i < day.Length - 1; i++)
        {
            // Nếu phát hiện 2 phần tử liên tiếp đều là số chẵn
            if (day[i] % 2 == 0 && day[i + 1] % 2 == 0)
            {
                // Dựa vào ví dụ ảnh 1, giá trị lẻ được thêm vào chính là số chẵn đứng trước + 1
                int giaTriLeCanThem = day[i] + 1;
                
                // Gọi hàm thêm phần tử lẻ này vào vị trí i + 1 (chen vào giữa 2 số chẵn)
                them1PhanTu(ref day, i + 1, giaTriLeCanThem);

                // Tăng i thêm 1 để bỏ qua phần tử lẻ vừa thêm vào, tránh lặp lại
                i++;
            }
        }
    }

    public static void Main(string[] args)
    {
        // Khởi tạo sẵn giá trị dãy số giống ví dụ trong đề bài
        int[] a = { 2, 4, 3, 4, 2, 8, 2, 5 };

        Console.WriteLine("* Mang truoc khi them: ");
        inMangTraiSangPhai(a);

        // Gọi hàm xử lý
        themPhanTuLeVaoGiua(ref a);

        Console.WriteLine("* Mang sau khi them: ");
        inMangTraiSangPhai(a);
    }
}
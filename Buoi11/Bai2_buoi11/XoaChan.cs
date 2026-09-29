using System;

class XoaChan
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

    // Hàm thu hẹp mảng đi n phần tử
    public static int[] thuHepDay(int[] day, int n)
    {
        // Tạo mảng mới có kích thước giảm đi n phần tử
        int[] mangMoi = new int[day.Length - n];
        
        // Sao chép các phần tử từ mảng cũ sang mảng mới
        for (int i = 0; i < mangMoi.Length; i++)
        {
            mangMoi[i] = day[i];
        }
        return mangMoi;
    }

    // Hàm mẫu
    public static void xoa1PhanTu(ref int[] day, int viTri)
    {
        // Dời các phần tử 
        for (int i = viTri + 1; i <= day.Length - 1; i++)
        {
            day[i - 1] = day[i];
        }
        
        // Thu hẹp 1 phần tử
        day = thuHepDay(day, 1);
    }

    // Hàm xử lý chính: Xóa tất cả các phần tử chẵn
    public static void xoaCacPhanTuChan(ref int[] day)
    {
        // Duyệt qua toàn bộ mảng
        for (int i = 0; i < day.Length; i++)
        {
            // Kiểm tra nếu là số chẵn
            if (day[i] % 2 == 0)
            {
                // Gọi hàm xóa 1 phần tử tại chính vị trí i này
                xoa1PhanTu(ref day, i);
                // Giảm i đi 1 để kiểm tra lại vị trí i sau khi xóa
                i--;
            }
        }
    }

    public static void Main(string[] args)
    {
        // Khai báo mảng 1 chiều
        // int[] a = null;
        
        // Khởi tạo sẵn giá trị dãy số để kiểm tra nhanh phương thức
        int[] a = { 2, 4, 3, 4, 2, 8, 2, 5 };

        // Kết quả
        Console.WriteLine("* Mang truoc xoa: ");
        inMangTraiSangPhai(a);

        // Xử lý xóa chẵn
        xoaCacPhanTuChan(ref a);

        Console.WriteLine("* Mang sau khi xoa: ");
        inMangTraiSangPhai(a);
    }
}
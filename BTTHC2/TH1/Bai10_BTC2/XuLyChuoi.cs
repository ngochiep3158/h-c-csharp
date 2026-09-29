using System;

class XuLyChuoi
{
    // Phương thức kiểm tra chuỗi đối xứng (Palindrome)
    public bool KiemTraDoiXung(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        
        // Sử dụng toán tử truy xuất phần tử [] để so sánh từng cặp ký tự
        while (left < right)
        {
            if (s[left] != s[right]) 
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}

class Program
{
    static void Main()
    {
        XuLyChuoi xuLy = new XuLyChuoi();
        
        Console.Write("Nhap chuoi can kiem tra: ");
        string chuoi = Console.ReadLine();

        if (xuLy.KiemTraDoiXung(chuoi))
        {
            Console.WriteLine("Chuoi '{0}' LA chuoi doi xung.", chuoi);
        }
        else
        {
            Console.WriteLine("Chuoi '{0}' KHONG PHAI la chuoi doi xung.", chuoi);
        }
        
        Console.ReadLine();
    }
}
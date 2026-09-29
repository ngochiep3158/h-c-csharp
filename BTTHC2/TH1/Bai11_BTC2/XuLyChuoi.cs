using System;
using System.Text;

class XuLyChuoi
{
    // Phương thức đảo ngược chuỗi sử dụng StringBuilder để tối ưu bộ nhớ
    public string DaoChuoi(string s)
    {
        StringBuilder sb = new StringBuilder();
        
        // Duyệt ngược từ cuối chuỗi về đầu bằng toán tử []
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        
        return sb.ToString();
    }
}

class Program
{
    static void Main()
    {
        XuLyChuoi xuLy = new XuLyChuoi();
        
        Console.Write("Nhap chuoi can dao nguoc: ");
        string chuoiGoc = Console.ReadLine();

        string chuoiDao = xuLy.DaoChuoi(chuoiGoc);
        
        Console.WriteLine("Chuoi goc: " + chuoiGoc);
        Console.WriteLine("Chuoi dao nguoc: " + chuoiDao);
        
        Console.ReadLine();
    }
}
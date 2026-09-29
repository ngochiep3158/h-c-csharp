using System;

class XuLyChuoi
{
    // Phương thức chuyển chuỗi sang ký tự thường
    public string ChuyenThanhThuong(string s)
    {
        return s.ToLower();
    }

    // Phương thức chuyển chuỗi sang ký tự hoa
    public string ChuyenThanhHoa(string s)
    {
        return s.ToUpper();
    }

    // Phương thức đếm số từ trong chuỗi
    public int DemSoTu(string s)
    {
        string[] mangTu = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        return mangTu.Length;
    }
}

class Program
{
    static void Main()
    {
        XuLyChuoi xuLy = new XuLyChuoi();
        Console.Write("Nhap vao mot chuoi gom nhieu tu: ");
        string chuoi = Console.ReadLine();

        // 1. Chuyển sang ký tự thường
        string chuoiThuong = xuLy.ChuyenThanhThuong(chuoi);
        Console.WriteLine("\nChuoi in thuong: " + chuoiThuong);

        // 2. Chuyển sang ký tự hoa
        string chuoiHoa = xuLy.ChuyenThanhHoa(chuoi);
        Console.WriteLine("Chuoi in hoa: " + chuoiHoa);

        // 3. Đếm số từ trong chuỗi
        int soTu = xuLy.DemSoTu(chuoi);
        Console.WriteLine("So tu trong chuoi la: " + soTu);
        
        Console.ReadLine();
    }
}
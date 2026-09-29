using System;

class DonThuc
{
    public double HeSo { get; set; }
    public int SoMu { get; set; }
    
    public DonThuc(double h, int m) 
    { 
        HeSo = h; 
        SoMu = m; 
    }
    
    public double TinhGiaTri(double x) 
    { 
        return HeSo * Math.Pow(x, SoMu); 
    }
    
    public override string ToString() 
    { 
        return $"{HeSo}x^{SoMu}"; 
    }
}

// Lớp Đa thức
class DaThuc
{
    private DonThuc[] dsDonThuc;
    private int n; // Số bậc cao nhất

    // Constructor
    public DaThuc(int n)
    {
        this.n = n;
        dsDonThuc = new DonThuc[n + 1]; // Gồm n+1 đơn thức (từ bậc 0 đến bậc n)
    }

    // Indexer để truy cập đơn thức thứ i
    public DonThuc this[int i]
    {
        get { return dsDonThuc[i]; }
        set { dsDonThuc[i] = value; }
    }

    // Nhập đa thức
    public void Nhap()
    {
        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Nhap he so cho x^{i}: ");
            // Thêm dấu ! để fix cảnh báo CS8604
            double heso = double.Parse(Console.ReadLine()!); 
            dsDonThuc[i] = new DonThuc(heso, i);
        }
    }

    // Xuất đa thức
    public void Xuat()
    {
        Console.Write("P(x) = ");
        bool first = true;
        for (int i = 0; i <= n; i++)
        {
            if (dsDonThuc[i].HeSo != 0) // Bỏ qua in nếu hệ số bằng 0
            {
                if (!first && dsDonThuc[i].HeSo > 0) Console.Write(" + ");
                Console.Write(dsDonThuc[i].ToString());
                first = false;
            }
        }
        if (first) Console.Write("0"); // Nếu tất cả hệ số đều bằng 0
        Console.WriteLine();
    }

    // Tính giá trị của đa thức
    public double TinhGiaTri(double x)
    {
        double tong = 0;
        for (int i = 0; i <= n; i++)
        {
            tong += dsDonThuc[i].TinhGiaTri(x);
        }
        return tong;
    }
}

// Lớp Program chứa hàm Main để chạy
class Program
{
    static void Main()
    {
        Console.Write("Nhap bac cua da thuc (n): ");
        int n = int.Parse(Console.ReadLine()!);

        // Khởi tạo đa thức bậc n
        DaThuc dt = new DaThuc(n);
        
        Console.WriteLine("\n--- NHAP DA THUC ---");
        dt.Nhap();
        
        Console.WriteLine("\n--- DA THUC VUA NHAP ---");
        dt.Xuat();
        
        Console.Write("\nNhap gia tri x de tinh P(x): ");
        double x = double.Parse(Console.ReadLine()!);
        
        Console.WriteLine($"Gia tri cua da thuc tai x = {x} la: {dt.TinhGiaTri(x)}");
        
        Console.ReadLine();
    }
}
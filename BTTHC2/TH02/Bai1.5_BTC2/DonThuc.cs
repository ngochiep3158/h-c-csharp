using System;

class DonThuc
{
    private double a;
    private int n;

    public DonThuc(double heSo, int soMu)
    {
        this.a = heSo;
        // Đảm bảo n là số nguyên không âm
        this.n = (soMu < 0) ? 0 : soMu; 
    }

    // (a) Tính giá trị đơn thức P(x) = a.x^n
    public double TinhGiaTri(double x)
    {
        return a * Math.Pow(x, n);
    }

    // (b) Đạo hàm đơn thức P'(x) = a.n.x^(n-1)
    public DonThuc DaoHam()
    {
        if (n == 0) return new DonThuc(0, 0); // Đạo hàm hằng số = 0
        
        double newA = a * n;
        int newN = n - 1;
        return new DonThuc(newA, newN);
    }

    public void Xuat()
    {
        Console.WriteLine("P(x) = {0} * x^{1}", a, n);
    }
}

class Program
{
    static void Main()
    {
        // Ví dụ: P(x) = 5.x^3
        DonThuc p = new DonThuc(5, 3);
        p.Xuat();

        Console.Write("Nhap gia tri x de tinh: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Gia tri P({0}) = {1}", x, p.TinhGiaTri(x));

        Console.WriteLine("\nDao ham cua don thuc:");
        DonThuc q = p.DaoHam();
        q.Xuat();

        Console.ReadLine();
    }
}
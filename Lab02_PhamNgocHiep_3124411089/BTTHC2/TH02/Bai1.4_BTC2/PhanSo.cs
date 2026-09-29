using System;

class PhanSo
{
    private int tuSo;
    private int mauSo;

    // Constructor mặc định, sao chép, khởi tạo dữ liệu                                                                                         
    public PhanSo() { tuSo = 0; mauSo = 1; }
    
    public PhanSo(int tu, int mau)
    {
        tuSo = tu;
        mauSo = (mau == 0) ? 1 : mau; // Chống lỗi chia 0
    }
    
    public PhanSo(PhanSo other)
    {
        this.tuSo = other.tuSo;
        this.mauSo = other.mauSo;
    }

    // Override ToString()
    public override string ToString()
    {
        return tuSo + "/" + mauSo;
    }

    // Overload toán tử 1 ngôi: +, -
    public static PhanSo operator +(PhanSo a) => a;
    public static PhanSo operator -(PhanSo a) => new PhanSo(-a.tuSo, a.mauSo);

    // Overload toán tử 2 ngôi: +, -, *, /
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);
    }
    
    public static PhanSo operator *(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
    }

    // Overload so sánh: ==, != (bắt buộc đi chung 1 cặp)
    public static bool operator ==(PhanSo a, PhanSo b)
    {
        return (a.tuSo * b.mauSo) == (b.tuSo * a.mauSo);
    }
    public static bool operator !=(PhanSo a, PhanSo b)
    {
        return !(a == b);
    }

    // Overload so sánh: > (làm mẫu cho >, <, >=, <=)
    public static bool operator >(PhanSo a, PhanSo b)
    {
        return (a.tuSo * b.mauSo) > (b.tuSo * a.mauSo);
    }
    public static bool operator <(PhanSo a, PhanSo b)
    {
        return (a.tuSo * b.mauSo) < (b.tuSo * a.mauSo);
    }
}

class Program
{
    static void Main()
    {
        PhanSo ps1 = new PhanSo(1, 2);
        PhanSo ps2 = new PhanSo(3, 4);
        
        Console.WriteLine("PS1: " + ps1.ToString());
        Console.WriteLine("PS2: " + ps2.ToString());
        
        PhanSo tong = ps1 + ps2;
        Console.WriteLine("Tong 2 phan so: " + tong.ToString());
        Console.WriteLine("PS1 == PS2 ? " + (ps1 == ps2));
        
        Console.ReadLine();
    }
}
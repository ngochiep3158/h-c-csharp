using System;

class Point
{
    // Field[cite: 36, 42]
    private double x, y;

    // Property
    public double X { get { return x; } set { x = value; } }
    public double Y { get { return y; } set { y = value; } }

    // Default constructor khởi tạo giá trị ban đầu
    public Point()
    {
        x = 0;
        y = 0;
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Method Input và Output
    public void Input()
    {
        Console.Write("Nhap toa do x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Nhap toa do y: ");
        y = double.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine(this.ToString());
    }

    // Override hàm ToString()
    public override string ToString()
    {
        return string.Format("({0}, {1})", x, y);
    }

    // Phép toán: +, -, lấy âm (-)
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.x + b.x, a.y + b.y);
    }

    public static Point operator -(Point a, Point b)
    {
        return new Point(a.x - b.x, a.y - b.y);
    }

    public static Point operator -(Point a)
    {
        return new Point(-a.x, -a.y);
    }

    // (a) Khoảng cách giữa 2 điểm theo 2 cách
    // 1. Phương thức thành viên (Instance Method)
    public double Distance(Point B)
    {
        return Math.Sqrt(Math.Pow(B.x - this.x, 2) + Math.Pow(B.y - this.y, 2));
    }

    // 2. Phương thức tĩnh (Static Method) - Phải có từ khóa static
    public static double Distance(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.x - A.x, 2) + Math.Pow(B.y - A.y, 2));
    }

    // (b) Trung điểm của 2 điểm theo 2 cách[cite: 42]
    // 1. Phương thức thành viên
    public Point Midpoint(Point B)
    {
        return new Point((this.x + B.x) / 2, (this.y + B.y) / 2);
    }

    // 2. Phương thức tĩnh
    public static Point Midpoint(Point A, Point B)
    {
        return new Point((A.x + B.x) / 2, (A.y + B.y) / 2);
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        Console.WriteLine("Diem 1 (Mac dinh): " + p1.ToString());
        
        Point p2 = new Point();
        Console.WriteLine("\nNhap diem 2:");
        p2.Input();

        Point p3 = new Point(4, 5);
        Console.WriteLine("Diem 3: " + p3.ToString());

        Console.WriteLine("\nKhoang cach p2 den p3 (Instance): " + p2.Distance(p3));
        Console.WriteLine("Khoang cach p2 den p3 (Static): " + Point.Distance(p2, p3));
        
        Point mid = Point.Midpoint(p2, p3);
        Console.WriteLine("Trung diem cua p2 va p3: " + mid.ToString());

        Console.ReadLine();
    }
}
using System;

class Person
{
    // Data members
    private int id;
    private string name;
    private int yob;
    private int yod;

    // Default Constructor
    public Person()
    {
        id = 0;
        name = "Unknown";
        yob = 0;
        yod = 0;
    }

    // Copy Constructor
    public Person(Person other)
    {
        this.id = other.id;
        this.name = other.name;
        this.yob = other.yob;
        this.yod = other.yod;
    }

    public void Input()
    {
        Console.Write("Nhap ID: ");
        id = int.Parse(Console.ReadLine());
        Console.Write("Nhap Ten: ");
        name = Console.ReadLine();
        Console.Write("Nhap nam sinh (yob): ");
        yob = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam mat (yod - nhap 0 neu con song): ");
        yod = int.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine("ID: {0} | Name: {1} | Sinh: {2} | Mat: {3}", id, name, yob, (yod == 0 ? "N/A" : yod.ToString()));
    }

    // Trả về false hay true tùy thuộc vào yod bằng 0 hay khác 0
    public bool IsLiving()
    {
        return (yod == 0);
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        p1.Input();
        
        Console.WriteLine("\nThong tin Nguoi 1:");
        p1.Output();
        Console.WriteLine("Con song khong? " + p1.IsLiving());

        // Sử dụng Copy Constructor
        Person p2 = new Person(p1);
        Console.WriteLine("\nThong tin Nguoi 2 (Copy tu Nguoi 1):");
        p2.Output();

        Console.ReadLine();
    }
}
using System;
using System.Collections.Generic;

class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Yob { get; set; }
    public int Yod { get; set; }
    
    public Person(int id, string name, int yob, int yod)
    {
        ID = id; Name = name; Yob = yob; Yod = yod;
    }
    
    public bool IsLiving() { return Yod == 0; }
    
    public void Output() 
    { 
        Console.WriteLine($"ID: {ID} | Name: {Name} | Sinh: {Yob} | Mat: {(Yod == 0 ? "Con song" : Yod.ToString())}"); 
    }
}

class PersonList
{
    private List<Person> danhSach;

    public PersonList()
    {
        danhSach = new List<Person>();
    }

    public PersonList(PersonList other)
    {
        this.danhSach = new List<Person>(other.danhSach);
    }

    public void Input(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap nguoi thu {i + 1}:");
            
            Console.Write("ID: "); 
            // Thêm dấu ! để báo với hệ thống rằng giá trị nhập vào sẽ không bị null
            int id = int.Parse(Console.ReadLine()!); 
            
            Console.Write("Ten: "); 
            string name = Console.ReadLine()!; 
            
            Console.Write("Nam sinh: "); 
            int yob = int.Parse(Console.ReadLine()!); 
            
            Console.Write("Nam mat (0 neu con song): "); 
            int yod = int.Parse(Console.ReadLine()!);
            
            Add(new Person(id, name, yob, yod));
        }
    }

    public void Output()
    {
        foreach (Person p in danhSach) p.Output();
    }

    public void Add(Person x)
    {
        danhSach.Add(x);
    }

    public PersonList LivingPeople()
    {
        PersonList result = new PersonList();
        foreach (Person p in danhSach)
        {
            if (p.IsLiving())
            {
                result.Add(p);
            }
        }
        return result;
    }
}

// Bổ sung class Program chứa hàm Main để làm điểm bắt đầu chạy chương trình
class Program
{
    static void Main()
    {
        PersonList ds = new PersonList();
        
        Console.Write("Nhap so luong nguoi can quan ly: ");
        int n = int.Parse(Console.ReadLine()!);
        
        // Gọi hàm nhập
        ds.Input(n);
        
        Console.WriteLine("\n=== DANH SACH VUA NHAP ===");
        ds.Output();
        
        Console.WriteLine("\n=== DANH SACH NHUNG NGUOI CON SONG ===");
        PersonList dsConSong = ds.LivingPeople();
        dsConSong.Output();
        
        Console.ReadLine();
    }
}
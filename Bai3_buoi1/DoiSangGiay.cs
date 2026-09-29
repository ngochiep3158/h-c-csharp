// khai bao thu vien
using System;
class DoiSangGiay
    {
        public static void Main(string[] args)
        {
            // nhap du lieu 
            Console.Write("nhap so gio:");
            int h = int.Parse(Console.ReadLine());

            Console.Write("nhap so phut:");
            int m = int.Parse(Console.ReadLine());
            
            Console.Write("nhap so giay:");
            int s = int.Parse(Console.ReadLine());

            // xy ly doi sang giay
            int tonggiay = h * 3600 + m * 60 + s;

            // xuat du lieu
            Console.WriteLine($"tong so giay cua {h}:{m}:{s} la: {tonggiay} giay");
        }
    }

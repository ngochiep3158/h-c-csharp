    using System;

    class SinhVien
    {
        // Cú pháp khai báo Field: <type> <name>;[cite: 36]
        private string hoTen;
        private int namSinh;

        public void Nhap()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
        }

        public void XuatVaTinhTuoi()
        {
            // Lấy năm hiện tại của hệ thống để tính tuổi
            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine("\nSinh vien: " + hoTen);
            Console.WriteLine("Tuoi hien tai: " + tuoi);
        }
    }

    class Program
    {
        static void Main()
        {
            SinhVien sv = new SinhVien();
            sv.Nhap();
            sv.XuatVaTinhTuoi();
            Console.ReadLine();
        }
    }
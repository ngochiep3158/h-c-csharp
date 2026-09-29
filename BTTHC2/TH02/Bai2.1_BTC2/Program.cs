    using System;
    using System.Collections;

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public override string ToString() { return $"({X}, {Y})"; }
    }

    class ArrayPoint
    {
        // Field: Một ArrayList các Point
        private ArrayList points;

        public ArrayPoint()
        {
            points = new ArrayList(); // Khởi tạo ArrayList
        }

        public void AddPoint(Point p)
        {
            points.Add(p); // Thêm dữ liệu
        }

        // Indexer cho phép truy cập Point thứ i của ArrayList
        public Point this[int index]
        {
            get
            {
                if (index >= 0 && index < points.Count)
                    // Ép kiểu (cast) vì ArrayList lưu trữ dưới dạng object
                    return (Point)points[index]; 
                return null;
            }
            set
            {
                if (index >= 0 && index < points.Count)
                    points[index] = value;
            }
        }

        public void Output()
        {
            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine($"Point {i}: {this[i]}"); // Sử dụng Indexer
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ArrayPoint ds = new ArrayPoint();
            ds.AddPoint(new Point(1, 2));
            ds.AddPoint(new Point(5, 6));

            Console.WriteLine("Danh sach diem:");
            ds.Output();

            // Test Indexer (Sửa điểm thứ 0)
            ds[0] = new Point(9, 9);
            Console.WriteLine("\nDanh sach diem sau khi sua:");
            ds.Output();
            Console.ReadLine();
        }
    }
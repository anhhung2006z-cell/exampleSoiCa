class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }

    // Constructor
    public Student(string id, string name, double score)
    {
        Id = id;
        Name = name;
        Score = score;
    }

    // Phương thức in thông tin
    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Score: {Score}");
    }
}

class Program
{
    static void Main()
    {
        // Tạo danh sách sinh viên có sẵn
        List<Student> students = new List<Student>()
        {
            new Student("SV01", "Nguyen Quoc Bao", 8.2),
            new Student("SV02", "Tran Hoang Hai", 6.2),
            new Student("SV03", "Le Thu Thuy", 8.5),
            new Student("SV04", "Tran Minh Hoang", 7.3),
            new Student("SV05", "Duong Quoc Hoang", 9.6)
        };

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. In danh sách sinh viên");
            Console.WriteLine("2. Tìm sinh viên có điểm cao nhất");
            Console.WriteLine("3. Tìm sinh viên có điểm >= 8");
            Console.WriteLine("4. Tìm sinh viên theo tên");
            Console.WriteLine("5. Thêm sinh viên mới");
            Console.WriteLine("6. Thoát");
            Console.Write("Chọn chức năng (1-6): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\n===== DANH SÁCH SINH VIÊN =====");
                foreach (var sv in students)
                    sv.Display();
            }
            else if (choice == "2")
            {
                double maxScore = students.Max(s => s.Score);
                Console.WriteLine($"\nSinh viên có điểm cao nhất ({maxScore}):");
                foreach (var sv in students.Where(s => s.Score == maxScore))
                    sv.Display();
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nDanh sách sinh viên có điểm >= 8:");
                var list = students.Where(s => s.Score >= 8).ToList();
                if (list.Count > 0)
                    list.ForEach(sv => sv.Display());
                else
                    Console.WriteLine("X Không có sinh viên nào.");
            }
            else if (choice == "4")
            {
                Console.Write("Nhập tên cần tìm: ");
                string keyword = Console.ReadLine().ToLower();

                var list = students.Where(s => s.Name.ToLower().Contains(keyword)).ToList();
                if (list.Count > 0)
                {
                    Console.WriteLine($"\nKết quả tìm kiếm theo tên \"{keyword}\":");
                    list.ForEach(sv => sv.Display());
                }
                else
                {
                    Console.WriteLine("X Không tìm thấy sinh viên.");
                }
            }
            else if (choice == "5")
            {
                Console.Write("Nhập ID: ");
                string id = Console.ReadLine();
                Console.Write("Nhập tên: ");
                string name = Console.ReadLine();

                double score;
                while (true)
                {
                    Console.Write("Nhập điểm (0-10): ");
                    if (double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 10)
                        break;
                    Console.WriteLine("! Điểm không hợp lệ, nhập lại!");
                }

                students.Add(new Student(id, name, score));
                Console.WriteLine("V Thêm sinh viên thành công!");
            }
            else if (choice == "6")
            {
                Console.WriteLine("Chương trình kết thúc.");
                break;
            }
            else
            {
                Console.WriteLine("! Lựa chọn không hợp lệ!");
            }
        }
    }
}

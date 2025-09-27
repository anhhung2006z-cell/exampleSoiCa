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
            new Student("Sv05", "Duong Quoc Hoang", 9.6)
        };

        // In danh sách sinh viên
        Console.WriteLine("===== DANH SÁCH SINH VIÊN =====");
        foreach (var sv in students)
        {
            sv.Display();
        }
    }
}

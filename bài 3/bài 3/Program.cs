class Program
{
    static void Main()
    {
        // Gán sẵn danh sách tên sinh viên
        List<string> sinhVien = new List<string>
        {
            "An",
            "Nguyen Van Minh",
            "Ngo Quoc Minh",
            "Nguyen Ngoc Nam",
            "Le Ngoc Bao"
        };

        Console.WriteLine("===== DANH SÁCH SINH VIÊN =====");
        foreach (string ten in sinhVien)
        {
            Console.WriteLine(ten);
        }

        // tìm tên dài nhất
        string tenDaiNhat = sinhVien[3];
        foreach (string ten in sinhVien)
        {
            if (ten.Length > tenDaiNhat.Length)
            {
                tenDaiNhat = ten;
            }
        }

        Console.WriteLine($"\nTên sinh viên dài nhất: {tenDaiNhat} ({tenDaiNhat.Length} ký tự)");
    }
}

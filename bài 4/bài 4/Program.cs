using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary lưu mã sinh viên (key) và tên sinh viên (value)
        Dictionary<string, string> danhSach = new Dictionary<string, string>()
        {
            {"SV01", "Le Thu Huong"},
            {"SV02", "Nguyen Ngoc Minh"},
            {"SV03", "Duong Minh Ngoc"}
        };

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Tìm sinh viên theo mã");
            Console.WriteLine("3. In toàn bộ danh sách");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn chức năng (1-4): ");

            string chon = Console.ReadLine();

            if (chon == "1")
            {
                Console.Write("Nhập mã sinh viên: ");
                string ma = Console.ReadLine();

                Console.Write("Nhập tên sinh viên: ");
                string ten = Console.ReadLine();

                if (!danhSach.ContainsKey(ma))
                {
                    danhSach.Add(ma, ten);
                    Console.WriteLine("✅ Thêm sinh viên thành công!");
                }
                else
                {
                    Console.WriteLine("⚠️ Mã sinh viên đã tồn tại!");
                }
            }
            else if (chon == "2")
            {
                Console.Write("Nhập mã sinh viên cần tìm: ");
                string ma = Console.ReadLine();

                if (danhSach.TryGetValue(ma, out string ten))
                {
                    Console.WriteLine($"👉 Mã: {ma}, Tên: {ten}");
                }
                else
                {
                    Console.WriteLine("❌ Không tìm thấy.");
                }
            }
            else if (chon == "3")
            {
                Console.WriteLine("\n===== DANH SÁCH SINH VIÊN =====");
                foreach (var sv in danhSach)
                {
                    Console.WriteLine($"Mã: {sv.Key}, Tên: {sv.Value}");
                }
            }
            else if (chon == "4")
            {
                Console.WriteLine("Chương trình kết thúc.");
                break;
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
            }
        }
    }
}

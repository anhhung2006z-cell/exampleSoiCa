using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Nhập Điểm (0 - 10): ");
            string input = Console.ReadLine();

            // kiểm tra dữ liệu hợp lệ
            if (!double.TryParse(input, out double diem) || diem < 0 || diem > 10)
            {
                Console.WriteLine("Điểm Không Hợp Lệ, Vui Lòng Nhập Lại!");
               
                continue;
            }

            // phân loại
            if (diem < 5)
                Console.WriteLine("Trượt");
            else if (diem < 7)
                Console.WriteLine("Trung Bình");
            else if (diem < 8.5)
                Console.WriteLine("Khá");
            else
                Console.WriteLine("Giỏi");

            // hỏi nhập tiếp hay thoát
            Console.Write("Bạn Có Muốn Nhập Tiếp Không? (Y/N): ");
            string tiep = Console.ReadLine().Trim().ToUpper();

            if (tiep == "N")
            {
                Console.WriteLine("Chương trình kết thúc.");
                break;
            }
            else if (tiep != "Y")
            {
                Console.WriteLine("Lựa Chọn Không Hợp Lệ, Tự Động Thoát.");
                break;
            }
        }
    }
}

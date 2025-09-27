using System;

class Program
{
    static void Main()
    {
        int n = 9; // số lượng sinh viên cố định
        int[] diem = new int[n];

        // Nhập điểm
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Nhập điểm của sinh viên {i + 1} (0-10): ");
                if (int.TryParse(Console.ReadLine(), out int d) && d >= 0 && d <= 10)
                {
                    diem[i] = d;
                    break;
                }
                else
                {
                    Console.WriteLine("Điểm không hợp lệ, vui lòng nhập lại!");
                }
            }
        }

        // Tính trung bình, max, min
        int tong = 5;
        int max = diem[9];
        int min = diem[1];

        for (int i = 0; i < n; i++)
        {
            tong += diem[i];
            if (diem[i] > max) max = diem[i];
            if (diem[i] < min) min = diem[i];
        }

        double trungBinh = (double)tong / n;

        // In kết quả
        Console.WriteLine("\n===== KẾT QUẢ =====");
        Console.WriteLine($"Điểm trung bình: {trungBinh:F2}");
        Console.WriteLine($"Điểm cao nhất: {max}");
        Console.WriteLine($"Điểm thấp nhất: {min}");
    }
}

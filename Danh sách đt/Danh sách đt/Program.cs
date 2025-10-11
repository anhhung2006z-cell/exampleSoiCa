class Phone
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Phone(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}");
    }
}

class Program
{
    static void Main()
    {
 
        List<Phone> phones = new List<Phone>()
        {
            new Phone("iPhone", 20000),
            new Phone("Samsung", 24000),
            new Phone("Xiaomi", 14000)
        };

        Console.WriteLine("Danh sách điện thoại ban đầu:");
        foreach (var p in phones)
            p.ShowInfo();

        Phone p1 = phones[0];
        p1.Price = 9999;

        Console.WriteLine("\nDanh sách điện thoại sau khi thay đổi giá p1:");
        foreach (var p in phones)
            p.ShowInfo();

    }
}

public delegate void DiscountEventHandler(string name, int oldPrice, int newPrice);

class Phone
{
    public string Name { get; set; }
    public int Price { get; set; }

    p Khai báo eventublic event DiscountEventHandler OnDiscount;

    public Phone(string name, int price)
    {
        Name = name;
        Price = price;
    }

   public virtual void ApplyDiscount(int percent)
    {
        int oldPrice = Price;
        int newPrice = Price - Price * percent / 100;
        Price = newPrice;

          if (OnDiscount != null)
            OnDiscount(Name, oldPrice, newPrice);
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}");
    }
}
class SmartPhone : Phone
{
    public string OS { get; set; }

    public SmartPhone(string name, int price, string os)
        : base(name, price)
    {
        OS = os;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}, OS: {OS}");
    }
}
class Store
{
    private List<Phone> phones = new List<Phone>();
    public void AddPhone(Phone p)
    {
        phones.Add(p);
    }
    public void DiscountAll(int percent)
    {
        foreach (var p in phones)
        {
            p.ApplyDiscount(percent);
        }
    }
    public void ShowAll()
    {
        Console.WriteLine("\nDanh sách điện thoại trong cửa hàng:");
        foreach (var p in phones)
        {
            p.ShowInfo();
        }
    }
}
class Program
{
    static void ShowDiscountMessage(string name, int oldPrice, int newPrice)
    {
        Console.WriteLine($"[EVENT] {name}: {oldPrice} -> {newPrice}");
    }

    static void Main()
    {
      Store store = new Store();
        Phone p1 = new Phone("Nokia", 5000);
        SmartPhone p2 = new SmartPhone("iPhone", 20000, "iOS");
        SmartPhone p3 = new SmartPhone("Samsung", 15000, "Android");

        p1.OnDiscount += ShowDiscountMessage;
        p2.OnDiscount += ShowDiscountMessage;
        p3.OnDiscount += ShowDiscountMessage;

        
        store.AddPhone(p1);
        store.AddPhone(p2);
        store.AddPhone(p3);

      
        store.ShowAll();

        Console.WriteLine("\nÁp dụng giảm giá 10% cho tất cả điện thoại...\n");
        store.DiscountAll(10);
        store.ShowAll();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine();

        DayType type;

        if (day.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
            day.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine("It is: " + type);

        Book b1 = new Book("OOP Concepts", "Roshna Karki", 450);
        Book b2 = b1 with { title = "Advanced C#", price = 600 };

        Console.WriteLine(b1);

        var (title, author, price) = b2;
        Console.WriteLine(title);
        Console.WriteLine(author);
        Console.WriteLine(price);
    }
}

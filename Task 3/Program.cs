class Program
{
    static void Main(string[] args)
    {
        // Create object of ParameterDemo
        ParameterDemo obj = new ParameterDemo();

        // Call Increase()
        int value = 20;
        obj.Increase(ref value);
        Console.WriteLine("Value after Increase: " + value);

        // Call GetFullName()
        string name;
        obj.GetFullName(out name);
        Console.WriteLine("Full Name: " + name);

        // Call SumAll()
        int total = obj.SumAll(5, 10, 15, 20);
        Console.WriteLine("Sum of all numbers: " + total);
    }
}

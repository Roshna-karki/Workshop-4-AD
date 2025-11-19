class Program
{
    static void Main(string[] args)
    {
        // Create object of Calculator
        Calculator calc = new Calculator();

        // Call PrintWelcome()
        calc.PrintWelcome();

        // Call Add()
        int addResult = calc.Add(10, 20);
        Console.WriteLine("Addition: " + addResult);

        // Call Multiply() with two parameters
        int mulResult1 = calc.Multiply(5, 4);
        Console.WriteLine("Multiplication (two params): " + mulResult1);

        // Call Multiply() with one parameter (uses default value)
        int mulResult2 = calc.Multiply(5);
        Console.WriteLine("Multiplication (one param): " + mulResult2);
    }
}

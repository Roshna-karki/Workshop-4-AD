public class Calculator
{
    // Method 1
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Method 2
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Method 3
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}

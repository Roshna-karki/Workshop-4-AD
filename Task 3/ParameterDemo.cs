public class ParameterDemo
{
    // 1. Increase using ref
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    // 2. GetFullName using out
    public void GetFullName(out string fullname)
    {
        fullname = "Roshna Karki";
    }

    // 3. SumAll using params
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}

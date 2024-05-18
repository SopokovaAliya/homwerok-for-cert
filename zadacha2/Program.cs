

int AckermannFunction(int m, int n)
{
    System.Console.WriteLine($"akerman calculation {m} and {n}");
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

void RequestInput()
{
    System.Console.WriteLine("Enter number m:");
    int m = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Enter number n:");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m >= 0 && n >= 0)
    {
        int result = AckermannFunction(m, n);
        System.Console.WriteLine($"The result of the Ackermann function for m = {m} и n = {n}: {result}");
    }
    else
    {
        System.Console.WriteLine("The values of m and n must not be negative");
        RequestInput();
    }
}

RequestInput();

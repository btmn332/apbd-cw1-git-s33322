double add(double x, double y)
{
    return x + y;
}

double divide(double x, double y)
{
    try
    {
        return x / y;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Divide by zero");
        return 0;
    }
}

double substract(double x, double y)
{
    return x - y;
}

double CalculateAverage(int[] values)
{
    double sum = 0;
    foreach (int value in values)
    {
        sum += value;
    }

    return sum / values.Length;
}

Console.WriteLine("Hello, World!");
Console.WriteLine("qwerty");

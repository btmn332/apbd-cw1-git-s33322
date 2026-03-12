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

Console.WriteLine("Hello, World!");
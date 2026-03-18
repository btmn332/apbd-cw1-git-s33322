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

int CalculateMax(int[] values)
{
    int max = values[0];
    foreach (int  value in values) {
        if  (value > max) {
            max = value;
            }
    }

    return max;
}

int CalculateMin(int[] values)
{
    
}

Console.WriteLine("Hello, World!");

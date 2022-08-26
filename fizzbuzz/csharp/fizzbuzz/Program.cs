using System;

for (int n = 1; n <= 100; n++)
{
    if (n % 15 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    if (n % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    if (n % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine($"{n}");
    }
}

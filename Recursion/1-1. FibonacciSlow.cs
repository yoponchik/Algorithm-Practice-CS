using System;

class FibonacciSlow
{
    static void Main(string[] args)
    {
        Console.WriteLine(FibSlow(6));
        Console.WriteLine(FibSlow(7));
        Console.WriteLine(FibSlow(8));
    }

    static int FibSlow(int n)
    {
        if (n <= 2) { return 1; }
        return FibSlow(n - 1) + FibSlow(n - 2);
    }
}
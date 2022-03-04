using System;

class FibonacciSlow
{
    //Fibonacci function is basically getting the sum of the previous Fib (n-1) and the one before that(n-2)

    static int FibSlow(int n)
    {
        if (n <= 2) { return 1; }                   //base case

        return FibSlow(n - 1) + FibSlow(n - 2);     //if not basecase, recursion
    }


    static void Main(string[] args)
    {
        Console.WriteLine(FibSlow(6));
        Console.WriteLine(FibSlow(7));
        Console.WriteLine(FibSlow(8));
    }

}
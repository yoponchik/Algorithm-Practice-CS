using System;

class FibonacciFast
{
    static Dictionary<int, long> _memo = new() { { 0, 0 }, { 1, 1 } };


    static void Main(string[] args)
    {
        Console.WriteLine(FibFast(6));
        Console.WriteLine(FibFast(7));
        Console.WriteLine(FibFast(8));
        Console.WriteLine(FibFast(50));
    }

    static long FibFast(int n)
    {
        if (_memo.ContainsKey(n)) { return _memo[n]; }
        var value = FibFast(n - 1) + FibFast(n - 2);
        _memo[n] = value;

        return value;
    }
}
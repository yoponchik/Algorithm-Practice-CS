using System;

class GridTravellerFast
{
    static Dictionary<Tuple<int, int>, long> _memo = new Dictionary<Tuple<int, int>, long>();

    static long GridTravel(int m, int n)
    {
        Tuple<int, int> key;
        key = Tuple.Create(m, n);

        if (_memo.ContainsKey(key)) { return _memo[key]; }
        if (m == 1 && n == 1) return 1;
        if (m == 0 || n == 0) return 0;

        _memo[key] = GridTravel(m - 1, n) + GridTravel(m, n - 1);
        return _memo[key];
    }
    static void Main(string[] args)
    {
        Console.WriteLine(GridTravel(1, 1));
        Console.WriteLine(GridTravel(2, 3));
        Console.WriteLine(GridTravel(3, 2));
        Console.WriteLine(GridTravel(3, 3));
        Console.WriteLine(GridTravel(18, 18));
    }
}
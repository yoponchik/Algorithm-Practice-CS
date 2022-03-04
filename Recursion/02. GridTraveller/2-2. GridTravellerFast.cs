using System;

class GridTravellerFast
{
    static Dictionary<Tuple<int, int>, long> _memo = new Dictionary<Tuple<int, int>, long>();   //Tuple type key

    static long GridTravel(int m, int n)
    {
        Tuple<int, int> key;                        //declare a tuple key
        key = Tuple.Create(m, n);                   //initialize/create a key

        if (_memo.ContainsKey(key)) { return _memo[key]; }          //check dictionary with tuple key, return if memoized
        if (m == 1 && n == 1) return 1;                             //positive base case    
        if (m == 0 || n == 0) return 0;                             //negative base case

        _memo[key] = GridTravel(m - 1, n) + GridTravel(m, n - 1);   //store memo
        return _memo[key];                                          //return memoized
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
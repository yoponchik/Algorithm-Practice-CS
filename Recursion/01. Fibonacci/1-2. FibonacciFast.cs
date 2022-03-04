using System;

class FibonacciFast
{
    //need to use memoization to decrease time complexity
    //basically we store calculated values and return that if it is used again

    
    //declare a dictionary with an int KEY and a long VALUE with 2 indices filled with 0 and 1
    static Dictionary<int, long> _memo = new() Dictionary<int, long>();               

    //static Dictionary<int, long> _memo = new() { { 0, 0 }, { 1, 1 } };


    //we know that the return value is going to be a LONG result and the input parameter is an INT n, which stands for iteration/step
    static long FibFast(int n)
    {
        if (n <= 2) { return 1; }                               
        if (_memo.ContainsKey(n)) { return _memo[n]; }          //now we need to add one more condition, when we have a calculated value we need to return it
                                                                //use iteration INT n as key, and LONG _memo as the return value; the return value has to match the method type
       
        var value = FibFast(n - 1) + FibFast(n - 2);            //instead of just returning the value, we first calculate it and store it
        _memo[n] = value;                                       //store into memo

        return value;                                           //and return the value that is not memoed
    }

    static void Main(string[] args)
    {
        Console.WriteLine(FibFast(6));
        Console.WriteLine(FibFast(7));
        Console.WriteLine(FibFast(8));
        Console.WriteLine(FibFast(50));
    }
}
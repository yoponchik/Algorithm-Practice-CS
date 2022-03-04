using System;

class CanSumFast
{

    static Dictionary<Tuple<int, int[]>, bool> _memo = new Dictionary<Tuple<int, int[]>, bool>();


    static bool CanSum(int targetSum, int[] numbers)
    {
        Tuple<int, int[]> key;
        key = Tuple.Create(targetSum, numbers);

        if (_memo.ContainsKey(key)) { return _memo[key]; }
        if (targetSum == 0) { return true; }
        if (targetSum < 0) { return false; }

        foreach (var num in numbers)
        {
            int remainder = targetSum - num;
            if (CanSum(remainder, numbers) == true){
                _memo[key] = true;
                return true;
            }
        }

        _memo[key] = false;
        return false;
    }
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 7, 14 };      //because call by reference not call by value
        Console.WriteLine(CanSum(300, numbers));                         //https://stackoverflow.com/questions/37498677/passing-arrays-as-parameter
    }
}
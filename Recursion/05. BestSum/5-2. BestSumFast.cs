using System;

class BestSumFast
{

    static Dictionary<int, int[]> _memo = new Dictionary<int, int[]>();

    static int[] BestSum(int targetSum, int[] numbers)
    {
        int[] emptyArray = new int[0];

        if (_memo.ContainsKey(targetSum)) { return _memo[targetSum]; }
        if (targetSum == 0) { return emptyArray; }
        if (targetSum < 0) return null;

        int[] shortestCombination = null;

        foreach (var num in numbers)
        {
            var remainder = targetSum - num;
            int[] remainderCombination = BestSum(remainder, numbers);

            if (remainderCombination != null)
            {
                var validCombination = remainderCombination.Append(num).ToArray();
                if (shortestCombination == null || validCombination.Length < shortestCombination.Length)
                {
                    shortestCombination = validCombination;
                }
            }
        }

        _memo[targetSum] = shortestCombination;
        return shortestCombination;

    }

    static void Main(string[] args)
    {
        int[] numbers = new int[] { 3, 2, 5 };

        int[] result = BestSum(8, numbers);

        if (result != null)
        {
            Console.WriteLine(String.Join(",", result));
        }
        else { Console.WriteLine("NULL"); }
    }

}
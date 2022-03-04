using System;

class BestSumSlow
{

    static int[] BestSum(int targetSum, int[] numbers)
    {

        int[] empty = Array.Empty<int>();

        if (targetSum == 0) { return empty; }
        if (targetSum < 0) return null;

        //int[] shortestCombination = Array.Empty<int>();
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

        return shortestCombination;
    }

    static void Main()
    {
        int[] numbers = new int[] { 2, 3, 5 };

        int[] result = BestSum(8, numbers);

        if (result != null)
        {
            Console.WriteLine(String.Join(",", result));
        }
        else
        {
            Console.WriteLine("NULL");
        }
    }
}
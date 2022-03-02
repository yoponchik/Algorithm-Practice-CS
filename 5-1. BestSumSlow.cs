class BestSumSlow
{

    static int[] BestSum(int targetSum, int[] numbers)
    {

        int[] empty = new int[] { };

        if (targetSum == 0) { return empty; }
        if (targetSum < 0) return null;

        int[] shortestCombination = new int[] { };

        foreach (var num in numbers)
        {
            var remainder = targetSum - num;
            int[] remainderCombination = BestSum(remainder, numbers);

            if (remainderCombination != Array.Empty<int>())
            {
                var combination = remainderCombination.Append(num).ToArray();
                if (shortestCombination == Array.Empty<int>() || combination.Length < shortestCombination.Length)
                {
                    shortestCombination = combination;
                }
            }
        }

        return shortestCombination;
    }

    static void Main(string[] args)
    {
        int[] numbers2 = new int[] { 2, 3, 5 };

        int[] result = BestSum(8, numbers2);

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
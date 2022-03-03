class HowSumFast
{
    static Dictionary<int, int[]> _memo = new Dictionary<int, int[]>();

    static int[] HowSum(int targetSum, int[] numbers)
    {
        int[] emptyArray = new int[0];
        if (_memo.ContainsKey(targetSum)) { return _memo[targetSum]; }
        if (targetSum == 0) { return emptyArray; }
        if (targetSum < 0) { return null; }

        foreach (var num in numbers)
        {
            var remainder = targetSum - num;
            var remainderResult = HowSum(remainder, numbers);

            if (remainderResult != null)
            {

                _memo[targetSum] = remainderResult.Append(num).ToArray();

                return _memo[targetSum];
            }
        }

        _memo[targetSum] = null;
        return null;
    }

    static void Main(string[] arg)
    {
        int[] numbers = new int[] { 7, 14 };
        int[] numbers2 = new int[] { 100, 250 };

        int[] result = HowSum(300, numbers2);

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
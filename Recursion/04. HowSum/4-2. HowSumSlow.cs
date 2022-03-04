class HowSumSlow{
    static int[] HowSum(int targetSum, int[] numbers)
    {
        int[] empty = new int[0];
        if (targetSum == 0) return Array.Empty<int>();
        //if (targetSum == 0) return empty;
        //if (targetSum < 0) throw new ArgumentException("NULL", nameof(targetSum));
        if (targetSum < 0) return null;

        foreach (var num in numbers)
        {
            var remainder = targetSum - num;
            int[] remainderResult = HowSum(remainder, numbers);

            if (remainderResult != null){
                return remainderResult.Append(num).ToArray();
            }
        }

        return null;
    }
    static void Main(string[] arg)
    {
        int[] numbers1 = new int[] { 2, 4 };
        int[] numbers2 = new int[] { 5, 3, 4, 7 };
        int[] numbers3 = new int[] { 2, 4 };
        int[] numbers4 = new int[] { 2, 3, 5 };

        int[] result = HowSum(7, numbers3);
        
        Console.WriteLine(result == null ? "null" : String.Join(",", result));


/*        if (result != null){
            Console.WriteLine(String.Join(",", result));
        }
        else{
            Console.WriteLine("NULL");
        }*/

        //Console.WriteLine(String.Join(",", HowSum(7, numbers3) ?? Array.Empty<int>()));

    }
}

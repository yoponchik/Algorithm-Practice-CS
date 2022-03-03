using System;

//https://jykimdev.blogspot.com/2019/06/2579.html
#region Problem2
class Problem2 {
	public static int[] max;
	public static int[] input;

	public static void Main(string[] args){
		var count = int.Parse(Console.ReadLine());

		max = new int[count + 1];
		input = new int[count + 1];

		for (var i = 1; i <= count; ++i) { 
			input[i] = int.Parse(Console.ReadLine());
		}

		max[1] = input[1];
		max[2] = input[1] + input[2];

		Console.WriteLine(CalcMax(count));

	}

    private static int CalcMax(int n)
    {
		var result = -1;
		if (n == 1 || n == 2) { result = max[n]; }

		for (int i = 3; i <= n; i++) {
			var candidate_one = max[i - 3] + input[i - 1] + input[i];
			var candidate_two = max[i - 2] + input[i];

			max[i] = Math.Max(candidate_one, candidate_two);
		}

		return max[n];
    }
}

#endregion Problem2
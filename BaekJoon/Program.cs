using System;
using System.Text;


//https://www.acmicpc.net/workbook/view/10475
#region Problem1
/*class Problem1 {
    static void Main(string[] args) {
		int n = int.Parse(Console.ReadLine());

		int[] dp = new int[n + 1];
		dp[0] = dp[1] = 0;

		for (int i = 2; i <= n; i++)
		{
			dp[i] = dp[i - 1] + 1;

			if (i % 2 == 0)
			{
				dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
			}
			if (i % 3 == 0)
			{
				dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
			}
		}
		Console.WriteLine(dp[n]);
	}
}
*/
#endregion Problem1

//https://jykimdev.blogspot.com/2019/06/2579.html
#region Problem2
/*class Problem2 {
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
}*/

#endregion Problem2

//https://munit-b.tistory.com/24
#region Problem3
class Problem3 {
	/*	static void Main(string[] args) {
			int t = int.Parse(Console.ReadLine());
			int[] dp = new int[12];
			dp[0] = 1;
			dp[1] = 1;
			dp[2] = 2;

			for (int i = 3; i < 11; i++) { 
				dp[i] = dp[i -1] + dp[i-2] + dp[i-3];
			}

			for (int i = 0; i < t; i++) {
				int n = int.Parse(Console.ReadLine());
				Console.WriteLine(dp[n]);
			}
		}*/
}

#endregion Problem3

//https://munit-b.tistory.com/23
//https://munit-b.tistory.com/m/22
#region Problem4
/*
class Problem4
{
	public static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		int[] dp = new int[1010];

		dp[1] = 1;
		dp[2] = 2;

		for (int i = 3; i <= n; i++) {
			dp[i] = (dp[i - 2] + dp[i - 1]) % 10007; 
		}

		Console.WriteLine(dp[n]);
	}

}
	*/

#endregion Problem4


//https://funfunhanblog.tistory.com/401https://funfunhanblog.tistory.com/401
#region Problem5
class Problem5 {
	public static void Main(string[] args){
		int[] array = new int[20000001];
		int n = int.Parse(Console.ReadLine());
		string[] nstr = Console.ReadLine().Split(' ');
		
		int m = int.Parse(Console.ReadLine());
		string[] mstr = Console.ReadLine().Split(' ');
		int nIdx = 10000000;

		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < nstr.Length; i++) {
			array[nIdx + int.Parse(nstr[i])]++;
			
		}		
		for (int i = 0; i < mstr.Length; i++) {
			stringBuilder.Append(array[nIdx + int.Parse(mstr[i])] + " ");
		}

		Console.WriteLine(stringBuilder.ToString());


	}
}

#endregion Problem5



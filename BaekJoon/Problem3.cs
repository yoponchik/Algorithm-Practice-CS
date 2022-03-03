using System;

//https://munit-b.tistory.com/24
#region Problem3
class Problem3
{
	static void Main(string[] args) {
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
	}
}

#endregion Problem3
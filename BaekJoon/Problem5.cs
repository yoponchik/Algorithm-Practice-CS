using System;

//https://funfunhanblog.tistory.com/401https://funfunhanblog.tistory.com/401
#region Problem5
class Problem5
{
	public static void Main(string[] args)
	{
		int[] array = new int[20000001];
		int n = int.Parse(Console.ReadLine());
		string[] nstr = Console.ReadLine().Split(' ');

		int m = int.Parse(Console.ReadLine());
		string[] mstr = Console.ReadLine().Split(' ');
		int nIdx = 10000000;

		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < nstr.Length; i++)
		{
			array[nIdx + int.Parse(nstr[i])]++;

		}
		for (int i = 0; i < mstr.Length; i++)
		{
			stringBuilder.Append(array[nIdx + int.Parse(mstr[i])] + " ");
		}

		Console.WriteLine(stringBuilder.ToString());


	}
}

#endregion Problem5
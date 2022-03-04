using System;


class CountConstructSlow
{
    static int CountConstruct(string target, string[] wordBank)
    {
        if (target == "") { return 1; }

        var totalCount = 0;

        foreach (var word in wordBank){
            if (target.IndexOf(word) == 0){
                var suffix = target.Substring(word.Length)
                var numWays = CountConstruct(suffix, wordBank);
                totalCount += numWays;
            }
        }

        return totalCount;

    }

    static void Main()
    {
        string[] wordBank = new string[] { "p", "ur", "ple", "u", "p", "urple" };
        Console.WriteLine(CountConstruct("purple", wordBank));
    }
}

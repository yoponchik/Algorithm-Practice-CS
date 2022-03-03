using System;


class CountConstructSlow
{
    static int CountConstruct(string target, string[] wordBank)
    {
        if (target == "") { return 1; }

        var totalCount = 0;

        foreach (var word in wordBank)
        {
            if (target.IndexOf(word) == 0)
            {
                var numWaysForRest = CountConstruct(target.Substring(word.Length), wordBank);
                totalCount += numWaysForRest;
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

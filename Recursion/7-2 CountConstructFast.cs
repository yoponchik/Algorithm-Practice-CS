using System;

class CountConstructFast
{

    static Dictionary<string, int> _memo = new Dictionary<string, int>();           //need to have static or else "An object reference is required for the non-static field, method,etc"

    static int CountConstruct(string target, string[] wordBank)
    {

        if (_memo.ContainsKey(target)) { return _memo[target]; }
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

        _memo[target] = totalCount;
        return totalCount;
    }

    static void Main()
    {
        string[] wordBank = new string[] { "s", "n", "i", "de", "d", "e", "sni" };

        Console.WriteLine(CountConstruct("snide", wordBank));
    }
}
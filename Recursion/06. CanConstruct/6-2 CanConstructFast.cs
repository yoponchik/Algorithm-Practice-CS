using System;

class CanConstructFast
{

    static Dictionary<string, bool> _memo = new Dictionary<string, bool>();

    static bool CanConstruct(string target, string[] wordBank)
    {
        if (_memo.ContainsKey(target)) { return _memo[target]; }
        if (target == "") { return true; }

        foreach (var word in wordBank)
        {
            if (target.IndexOf(word) == 0)
            {
                var suffix = target.Substring(word.Length);
                if (CanConstruct(suffix, wordBank))
                {
                    _memo[target] = true;
                    return true;
                }
            }
        }

        _memo[target] = false;
        return false;
    }

    static void Main(string[] args)
    {
        string[] wordBank = new string[] { "ab", "cd", "efg" };

        Console.WriteLine(CanConstruct("abcdefg", wordBank));
    }

}
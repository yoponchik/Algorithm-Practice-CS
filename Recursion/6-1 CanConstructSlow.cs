using System;

class CanConstructSlow { 
    static bool CanConstruct(string target, string[] wordBank){
        if (target == "") { return true; }

        foreach (var word in wordBank) {
            if (target.IndexOf(word) == 0) {
                var suffix = target.Substring(word.Length);
                if (CanConstruct(suffix, wordBank) == true) { 
                    return true; 
                }
            }
        }

        return false;
    }

    static void Main(string[] args) {

        string[] wordBank = new string[] { "ab", "d", "ef" };
        Console.WriteLine(CanConstruct("abcdef", wordBank));
    }
}
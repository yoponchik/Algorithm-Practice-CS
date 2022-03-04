using System;

class CanSumSlow
{
    static bool CanSum(int targetSum, int[] numbers)
    {

        if (targetSum == 0) { return true; }
        if (targetSum < 0) { return false; }

        foreach (var num in numbers)
        {
            int remainder = targetSum - num;
            if (CanSum(remainder, numbers)) { return true; }
        }

        return false;
    }

    static void Main(string[] args)
    {
        int[] numbers = new int[] { 7, 14 };      //because call by reference not call by value
        Console.WriteLine(CanSum(300, numbers));                         //https://stackoverflow.com/questions/37498677/passing-arrays-as-parameter
    }
}
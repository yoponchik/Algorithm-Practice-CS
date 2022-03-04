using System;
using System.Collections.Generic;


//https://getcomponent.tistory.com/19
https://www.acmicpc.net/problem/9012
#region Brackets
class Brackets
{
    static bool isRightBrackets(ref Queue<int> queue)
    {

        int checkPoint = 0;
        if (queue.Peek() == 1)
            return false;
        while (queue.Count != 0)
        {
            if (queue.Count == 1)
            {
                if (queue.Peek() == -1)
                    return false;
            }

            checkPoint += queue.Dequeue();

            if (checkPoint == 0 && queue.Count != 0)
                return isRightBrackets(ref queue);
        }

        if (checkPoint == 0)
            return true;
        return false;

    }



    static void Main(string[] args)
    {

        int count = int.Parse(Console.ReadLine());
        Queue<int> brackets = new Queue<int>();
        string str;
        for (int i = 0; i < count; i++)
        {

            str = Console.ReadLine();
            for (int x = 0; x < str.Length; x++)
            {
                if (str[x].Equals('('))
                    brackets.Enqueue(-1);
                else
                    brackets.Enqueue(1);
            }

            if (isRightBrackets(ref brackets))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            brackets.Clear();
        }
    }
}
#endregion Brackets
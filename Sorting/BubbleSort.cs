using System;
using System.Collections.Generic;

public class Algorithm1
{
    static void Main(string[] args)
    {

        BubbleSort();
    }




    #region Bubble Sort
    //An algorithm that goes through the ith element, compares it with the next element and sends the smaller number in the front
    //After each iteration, because we're taking the smaller number to the front, we have the largest number in the back
    //As a result, we can decrease the number of iterations as we go. 
    static void BubbleSort()
    {
        int i, j;
        int temp;
        int[] array = { 1, 10, 5, 8, 7, 6, 4, 3, 2, 9 };

        for (i = 0; i < array.Length; i++)
        {
            for (j = i; j < (array.Length - 1) - i; j++)
            {

                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    #endregion Bubble Sort


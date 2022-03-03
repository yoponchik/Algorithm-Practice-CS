using System;
using System.Collections.Generic;

public class Algorithm1
{
    static void Main(string[] args)
    {

        InsertionSort();

    }



    #region Insertion Sort
    //An algorithm where the array is virtually split into a sorted and unsorted part.
    //Values from unsorted are picked and inserted into the correct position
    //Because the array is split, when we have to insert the value, we don't need to loop through the whole
    //array again
    private static void InsertionSort()
    {
        int i, j, temp;
        int[] array = { 1, 10, 5, 8, 7, 6, 4, 3, 2, 9 };


        for (i = 0; i < (array.Length - 1); i++)
        {
            j = i;
            //Console.WriteLine(i);

            while (array[j] > array[j + 1])
            {               //if the jth element is greater than the one behind it
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                j--;                                        //if the jth element is smaller (or [j+1] > [j]), then after we swap; have to compare with the next preceding number
                                                            //Console.WriteLine(array[j]);              //This is the pivot, used for the array[j] > array[j+1]
                                                            //keep in mind the j decreases, so the number now compares with the next preceding number
                                                            //Console.WriteLine("********");
            }
        }

        for (i = 0; i < (array.Length); i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    #endregion Insertion Sort
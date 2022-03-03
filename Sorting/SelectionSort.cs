using System;
using System.Collections.Generic;

public class Algorithm1
{
    static void Main(string[] args)
    {
        SelectionSort();

    }



    #region Selection Sort
    //An algorithm that loops through the array pivoting on the ith element.
    static void SelectionSort()
    {

        int i;                  //nth number of the iteration
        int j;                  //nth number in the array(?)
        int min;                //the smallest number in the iteration
        int min_index = 0;      //the location of the smallest number; need to assign for some reason
        int temp;               //for swapping numbers

        int[] array = { 1, 10, 5, 8, 7, 6, 4, 3, 2, 9 };




        for (i = 0; i < array.Length; i++)
        {        //ith iteration; 0 -> 10
            min = 9999;         //arbitrary large number, so that the smallest number can be selected

            for (j = i; j < array.Length; j++)
            {    //jth element in the array; 0->10; loops through all the elements; compare ith element with all the elements
                if (min > array[j])
                {               //if the jth element is less than the current min

                    min = array[j];                 //store the jth element in the min variable
                    min_index = j;                      //store the location of the jth element
                }
            }

            //if the min value is stored 
            temp = array[i];                        //temporarily store the ith element of the array
            array[i] = array[min_index];                //insert min number in the right place
            array[min_index] = temp;                //insert temp into empty element

        }

        for (i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    #endregion Selection Sort
using System;
using System.Collections.Generic;
using System.Text;
//כאן אני מציג כמה שאלות שהבאתי מחיפוש בצ'אט הזה
namespace c_sharp_basics_lingar.algorithmic.some_challenges
{
    public class ChatGPTExercises
    {



        /** 
         * Write a function that takes an array of integers and returns the maximum difference between any 
         * two elements in the array, such that the larger element comes after the smaller element. 
         * If no such difference exists, return -1.

        For example:

        csharp
        Copy code
        int[] arr = { 2, 3, 10, 6, 4, 8, 1 };
        The function should return 8, as the maximum difference is between the elements 10 and 2.

        Here's a signature for the function:

        csharp
        Copy code
        public static int MaxDifference(int[] arr)
        */
        public static int MaxDifference(int[] arr)
        {

            
            int max = 0, min = 0;
            if(arr.Length > 0)
            {
                max = arr[0]; min = arr[0];
            }
            else
            {
                return -1;
            }
            for (int i =1; i< arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                else if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            if(max - min > 0)
            {
                return max - min;
            }
            return -1;
        }
    }




}

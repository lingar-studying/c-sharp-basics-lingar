using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic.tests.summer_23_B
{
    public class Part2
    {

        public static void Demo()
        {
            int[] arr1 = { 2, 5, 9, 11 };
            Console.WriteLine("result = " + Q7.What(arr1, 50));
        }
    }

    public class Q7
    {


        public static int What(int[] arr, int num)
        {
            int c = 0;
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
                if (arr[left] + arr[right] >= num)
                    right--;
                else
                {
                    c += (right - left);
                    left++;
                }
            return c;
        }
    }
}

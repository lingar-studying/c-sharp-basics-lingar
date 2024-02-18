using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar
{
    public  class HowTo
    {
        public static void Demo()
        {
            AddItemToArray();

        }

        public static void AddItemToArray()
        {
            int[] arr = new int[3];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            Console.WriteLine(string.Join(", ", arr));//1,2,3
            //want to add another value: 

            int[] arr2 = new int[arr.Length+1];
            Array.Copy(arr, arr2, arr.Length);
            arr2[arr2.Length-1] = 4;
            arr = arr2;
            Console.WriteLine(string.Join(", ", arr));//1,2,3,4

        }

    }
}

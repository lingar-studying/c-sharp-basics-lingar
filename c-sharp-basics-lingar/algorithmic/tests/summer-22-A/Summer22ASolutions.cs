using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic.tests.summer_22_A
{
    public class Summer22ASolutions
    {

        public static void Demo()
        {
            //SolveQ1();
            SolveQ2();

            int[] test1 = {1,3,5 };//false
            int[] test2 = {-6,4,-74 ,65};//true
            int[] test3 = { -6, 4, -74, 65, 0 ,0 };//false

            bool b = SolveQ3(test1);
            Console.WriteLine("false ? " + b);
            b = SolveQ3(test2);
            Console.WriteLine("true ? " + b);
            b = SolveQ3(test3);
            Console.WriteLine("false ? " + b);



        }

        public static void SolveQ1()
        {

            bool toContinue = true;
            int countZ = 0;
            while (toContinue)
            {
                Console.WriteLine("insert some string");
                string str = Console.ReadLine();
                if ((str[0] + "").ToLower().Equals("a") && (str[str.Length - 1] + "").ToLower().Equals("a"))
                {
                    Console.WriteLine("Stopping - this string starting and ending with a");

                    Console.WriteLine("Amount of z string: " + countZ);

                    toContinue = false;
                }
                else if ((str[0] + "").ToLower().Equals("z") && (str[str.Length - 1] + "").ToLower().Equals("z"))
                {
                    countZ++;
                }

            }

        }

        public static void SolveQ2()
        {
            int[] arr = { 18, 10, 3, 12, 17, 1 };
            int num = 15;

            What(arr, num);
        }


        public static void What(int[] arr, int num)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left != right)
            {
                if (arr[left] < num)
                    left++;
                else
                if (arr[right] > num)
                    right--;
                else
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
            }

            Console.WriteLine(string.Join(",", arr));
        }

        public static bool SolveQ3(int[] arr)
        {

            int countPositives = 0, countNegatives = 0;
            for(int i =0; i < arr.Length; i++)
            {
                if(arr[i] > 0 )
                {
                    countPositives++;

                }
                else if (arr[i] < 0)
                {
                    countNegatives++;
                }
                else
                {
                    return false;
                }
            }

            return countPositives == countNegatives;

        }
    }


        

    

    
}

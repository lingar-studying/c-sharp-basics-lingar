using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic.recursion
{
    public class RecursionDemo
    {

        public static void Demo()
        {

            int from = -1; int to = 20;
            Console.WriteLine("Print from {0} to upper bound - {1}", from, to);

            StringBuilder sb = new StringBuilder("Word");
            sb.Insert(0, "pre");
            Console.WriteLine(sb);

            Console.WriteLine("trying to print all combinations:");
            RecursionService recursionService = new RecursionService();
            recursionService.PrintAllCombinations("", "1234");
        }



    }

    public class RecursionService
    {

        //printing from the from to the upper, by recursion
        public void PrintToUpper(int num, int upperBound)
        {
            //base case
            if(num > upperBound)
            {
                return;
            }
            Console.WriteLine("num = " + num);
            //it's important to put the ++ before the num, otherwise - it will be up after the method will happen.
            PrintToUpper(++num, upperBound);
        }

        public void PrintAllCombinations(String prefix, String workOn)
        {
            if(workOn.Length == 1)
            {
                Console.WriteLine(prefix + workOn);
                return;
            }
                
            char first = workOn[0];           

            for (int i = 0; i < workOn.Length; i++)
            {
                StringBuilder newWorkOn = new StringBuilder(workOn);           

                //swap
                newWorkOn.Insert(0, workOn[i]);
                newWorkOn.Remove(i + 1, 1);

                //and provide it with one forward
                PrintAllCombinations(prefix+ newWorkOn[0], newWorkOn.ToString().Substring(1));

            }

        }
    }
}

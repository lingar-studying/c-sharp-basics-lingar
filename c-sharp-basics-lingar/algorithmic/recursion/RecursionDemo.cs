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
    }
}

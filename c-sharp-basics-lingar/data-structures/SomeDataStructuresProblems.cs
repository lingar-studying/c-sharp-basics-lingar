using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.data_structures
{
    public class SomeDataStructuresProblems
    {

        public static void Demo()
        {
            char[] palindrom3 = {
                'e','c','f','g',
                'g','f','c','e',
                'e','c','f','g'};

            char[] notPalindrom = { 'a', 'b', 'c', 'd'
                    , 'f', 'g', 'g', 'f', 'd' };
            char[] palindrom4 = {
                'a','b','c','d',
                'd','c','b','a',
                'a','b','c','d'};

            Console.WriteLine("true? " + IsThreePali(new Stack<char>(palindrom3)));
            Console.WriteLine("false? " + IsThreePali(new Stack<char>(notPalindrom)));
            Console.WriteLine("true? " + IsThreePali(new Stack<char>(palindrom4)));

            int[] q1Not = { 5, -9, 600, 0, 77 };
            int[] q1Yes = { 5, -9, 6, 0, 10 };
            Console.WriteLine("false = " + PosOrder(q1Not));
            Console.WriteLine("true = " + PosOrder(q1Yes));

            int[] q2 = { 6, 8, 12, 14, 16, 18 };//10 (interval 2)

            int[] q2_2 = {500,505,510,515,525,530,535  };//520 (interval 5)

            Console.WriteLine("10 ?  - " + MissingNum(q2) );

            Console.WriteLine("520 ?  - " +  MissingNum(q2_2));




        }
        //
        //צריך בדיקה... 
        //הסיבוכיות היא 
        //O(n^n)
        //Because we can call in the wrost scenario n time to count which is n so it comes O(n^n)
        public static bool IsThreePali(Stack<char> data)
        {
            if(data.Count % 3 != 0)
            {
                return false;
            }
            int partialLength = data.Count / 3;
            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();

            for(int i = 0; i < partialLength; i++)
            {
                stack1.Push (data.Pop());

            }
            //Console.WriteLine("data = " + String.Join(",", data));
            //Console.WriteLine("stack1 = " + String.Join(",", stack1));

            while (stack1.Count > 0)
            {
                if(stack1.Pop() != data.Peek())
                {
                    return false;
                }
                stack2.Push (data.Pop());
            }
            //Console.WriteLine("data = " + String.Join(",", data));
            //Console.WriteLine("stack2 = " + String.Join(",", stack2));
            while (stack2.Count > 0)
            {
                if (stack2.Pop() != data.Pop())
                {
                    return false;
                }
            }

            return true;
        }


        //from here - chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://kadman11.wordpress.com/wp-content/uploads/2023/12/t381_2023.pdf
        //the solution is: chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://kadman11.wordpress.com/wp-content/uploads/2023/12/pitaron899381_2023.pdf

        //q1
        public static bool PosOrder(int[] data)
        {
            int last = 0;
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] > 0)
                {
                    if (data[i] < last)
                    {
                        return false;
                    }
                    else
                    {
                        last = data[i];
                    }
                }
                
            }

            return true;
        }
        //q2
        //assuming that the data is ok 
        public static int MissingNum(int[] data)
        {

            //we need to find the interval by finding some reccuring interval 

            //and compare it to the missing interval which is twice of it...
           
            //it must be one of those the smaller
            int interval = Math.Min(data[1]- data[0], data[2] - data[1]);
            int missingNum = -1;

            for(int i = 0; i < data.Length-1; i++)
            {
                if(data[i+1] - data[i] > interval)
                {
                    missingNum = data[i] + interval;
                    return missingNum; ;
                }
            }
            return -1;
           

        }

    }
}

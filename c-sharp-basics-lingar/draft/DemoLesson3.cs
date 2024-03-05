using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.draft
{
    class DemoLesson3
    {
        public static void Run()
        {
            //MyAbstract m = new MyAbstract();
        }


        public static void YosefKortFibo()
        {
            int limit = 4000000; // Set your desired limit
            Console.WriteLine("Sum of even-valued terms in Fibonacci sequence up to " + limit + ":");

            int sum = 0;
            int currentTerm = 1;
            int nextTerm = 2;

            while (currentTerm <= limit)
            {
                if (currentTerm % 2 == 0)
                {
                    sum += currentTerm;
                }

                int temp = currentTerm + nextTerm;
                currentTerm = nextTerm;
                nextTerm = temp;
            }

            Console.WriteLine(sum);
        }
    }

    public class YosefKurtJobs
    {
        public static void Solve3()
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 1, 5, -8, -6 ,3,-2};
            CheckIfBalanced(arr);
        }

        public static void CheckIfBalanced(int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i = i + 1)
            {
                if (arr[i] == 0)
                {
                    Console.WriteLine("unbalanced");
                    return;
                }
                else if (arr[i] > 0)
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("balanced");
            }
            else
            {
                Console.WriteLine("not balanced");
            }
        }
    }

    public abstract class MyAbstract
    {
        public int x, y, z;

        public void ImplementedMethod()
        {
            Console.WriteLine("ImplementedMethod");
        }

        public abstract int AbstractMethod1(int x);
    }

    public class ImplementsMyAbstract: MyAbstract
    {
        public override int AbstractMethod1(int x)
        {
            return 0;
        }
    }
}

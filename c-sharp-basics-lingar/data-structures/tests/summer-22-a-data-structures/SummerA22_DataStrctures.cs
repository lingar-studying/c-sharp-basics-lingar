using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.data_structures.tests.summer_22_a_data_structures
{
    public class SummerA22_DataStrctures
    {
        public static void Demo()
        {
            SummerA22_DataStrctures_Q2.Demo();

            int[] q2WrongTestTrue = { 10, 20, 40, 100 };
            int[] q2WrongTestFalse = { 10, 20, 80, 100 };

            int[] trueCaseQ2 = { 200, 50, 30, 5, 2, 1 };
            int[] falseCaseQ2 = { 200, 177, 30, 5, 2, 1 };


            Console.WriteLine(Q2_Wrong_IsGreaterThenSum(new Stack<int>(q2WrongTestTrue)));
            Console.WriteLine(Q2_Wrong_IsGreaterThenSum(new Stack<int>(q2WrongTestFalse)));

            Console.WriteLine(Q2_Right_IsGreaterThenSum(new Stack<int>(trueCaseQ2)));
            Console.WriteLine(Q2_Right_IsGreaterThenSum(new Stack<int>(falseCaseQ2)));

        }

        //Complexity is O(n)
        public static bool Q2_Right_IsGreaterThenSum(Stack<int> stack)
        {
            Console.WriteLine("stack = {0} head is {1} ",  string.Join(',', stack), stack.Peek());
            //two queues for hold the values and the sums ---> not need! 
            //Queue<int> values = new Queue<int>();
            int sum = stack.Pop();
            int next = 0;
            while (stack.Count > 0)
            {
                next = stack.Pop();
                if (sum >= next)
                {
                    return false;
                }
                sum += next;
            }

            return true;
        }

        //this answer is wrong since we need to to calculate to the other direction (here I'm checking against the bottom
        //and the question is to the top...
        public static bool Q2_Wrong_IsGreaterThenSum(Stack<int> stack)
        {

            Stack<int> viseVersa = new Stack<int>();
            while (stack.Count > 0)//Similar to IsEmpty()
            {
                viseVersa.Push(stack.Pop());
            }
            int sum = viseVersa.Pop();
            while (viseVersa.Count > 0)
            {

                int next = viseVersa.Pop();
                // Console.WriteLine("sum = " + sum + " next = " + next);

                if (sum >= next)
                {
                    //Console.WriteLine("sum = " + sum + " next = " + next);
                    return false;
                }
                else
                {
                    sum += next;
                }

            }

            return true;
        }

    }
    public class SummerA22_DataStrctures_Q2
    {
        public static void Demo()
        {

            string[] words =
               { "the", "fox", "jumps", "over", "the", "dog" };
            int[] data = { 5, 20, 9, 6, 5, 8, 2 };
            int[] data2 = { 15, 200, 59, 76, 2 };

            LinkedList<int> list = new LinkedList<int>(data);
            LinkedList<int> list2 = new LinkedList<int>(data2);


            Console.WriteLine(string.Join(",", list));

            Console.WriteLine(DifferenceList(list.First).Value);

            Console.WriteLine("The survive is: \n");
            int result = TheSurvives(list.First);
            Console.WriteLine("Result = " + result);

            Console.WriteLine("The survive is: \n");
            result = TheSurvives(list2.First);
            Console.WriteLine("Result = " + result);
        }
        public static LinkedListNode<int> DifferenceList(LinkedListNode<int> node)
        {
            int current = node.Value;
            int next = node.Next.Value;
            int gap = Math.Abs(current - next);
            return new LinkedListNode<int>(gap);

        }

        public static int TheSurvives(LinkedListNode<int> node)
        {
            Console.WriteLine(String.Join(",", node.List));

            if (node.Next == null)
            {
                return node.Value;
            }
            LinkedList<int> newList = new LinkedList<int>();
            while (node.Next != null)
            {
                newList.AddLast(DifferenceList(node));
                node = node.Next;
            }
            return TheSurvives(newList.First);

        }
    }
}

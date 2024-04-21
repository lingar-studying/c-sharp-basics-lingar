using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.data_structures.tests.summer_22_a_data_structures
{
    public  class SummerA22_DataStrctures
    {
        public static void Demo()
        {
            SummerA22_DataStrctures_Q1.Demo();
        }

    }
    public class SummerA22_DataStrctures_Q1
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

            Console.WriteLine("The survive is: \n" );
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

        public static int TheSurvives (LinkedListNode<int> node)
        {
            Console.WriteLine(String.Join(",", node.List));

            if (node.Next == null)
            {
                return node.Value; 
            }
            LinkedList<int> newList = new LinkedList<int>();
            while(node.Next !=null)
            {
                newList.AddLast(DifferenceList(node));
                node = node.Next;
            }
           return TheSurvives(newList.First);
           
        } 
    }
}

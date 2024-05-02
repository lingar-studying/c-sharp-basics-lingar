using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic.tests.spring_22_A
{
    public class SimpleQuestionsSpring22A
    {
        public static void Demo()
        {
            Console.WriteLine("SimpleQuestionsSpring22A");
            Q1();
            Console.WriteLine(string.Join(",", Q2(16)));

            int[] testA = { 13, 6, 3, 13, 6, 3, 13, 6, 3 };
            int[] testB = { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3 };

            Console.WriteLine("true? " + Q3(testA));

            Console.WriteLine("false? " + Q3(testB));

            string s = "abcdefghijk";

            string sub = s.Substring(2);
            Console.WriteLine("sub = " + sub);
            string sub2 = s.Substring(3, 4);
            Console.WriteLine("Sub2 = " + sub2);

            string numStr = "13";
            int c = Int32.Parse(numStr);
            Console.WriteLine(c + 2);
            string number = c + "";
            char val = (char)126;
            Console.WriteLine("char val = " + val);
            Console.WriteLine("char val = " + ++val);

        }

        public static void Q1()
        {
            bool stop = false;
            int countNums = 0;
            int sumPositives = 0;
            //מייצג זוגות שווים
            int equalsPairs = 0;
            int a = 0;
            while (!stop)
            {

                Console.WriteLine("Insert number 1");
                a =int.Parse(Console.ReadLine());
                countNums++;

                if (a > 0)
                    sumPositives += a;
                
                Console.WriteLine("Insert number 2");
                int b = int.Parse(Console.ReadLine());
                countNums++;

                if (b > 0)
                {
                    sumPositives += b; ;
                }
                if (a == b) equalsPairs++;
               
                //if((a > 0 && b < 0) || (a < 0 && b > 0))
                //{
                //ההנחה היא שגם 2 אפסים הם הופכיים
                if (a + b == 0)
                {
                    stop = true;
                }
                //}
               

            }
            Console.WriteLine("Count numebrs = {0}, Sum Positives = {1}, Count Equals = {2} ", 
                countNums, sumPositives, equalsPairs);
        }

        public static int[] Q2(int num)
        {
            int[] nums = new int[num];

            for(int i = 0; i < num; i++)
            {
                Random rand = new Random();

                //ייצוג לעשרות
                int decimals = rand.Next(1, 6);
                decimals = decimals * 10;

                //ייצוג לאחדות
                int singles = rand.Next(6, 10);
                nums[i] = decimals + singles;

            }
            return nums;
        }



        //Complexity = O(n)
        public static bool Q3(int[] nums)
        {

            if(nums.Length % 3 != 0)
            {
                return false;
            }

            //מייצג את הקפיצה הנדרשת בין האינדקסים
            int jump = nums.Length / 3;

            for (int i =0; i < jump ; i++)
            {
                //wrong way
                //int part2I = (i + 1) * 2 - 1;
                //int part3I = (i + 1) * 3 - 1;
                //jump[i]
                if(!(nums[i] == nums[i + jump] 
                    && 
                    nums[i] == nums[i + jump * 2]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

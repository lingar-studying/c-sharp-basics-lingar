using System;


namespace c_sharp_basics_lingar.algorithmic.tests.summer_23_B
{
    internal class SmallQuestions
    {

        public static void Demo()
        {
          // Q1.Solve();
            Console.WriteLine("Q2 solution:");
            string wordValid = "AbbAc1A";// psdspcxbp , lhsl98l
            string wordInvalid = "pppp";// kdjtr, kkfasaa,....

            Console.WriteLine("is {0} valid? {1}", wordValid, Q2.IsValid(wordValid));

            Console.WriteLine("is {0} valid? {1}", wordInvalid, Q2.IsValid(wordInvalid));

            Q2.GetNStrings(3);

            Q3.Solve();

        }
    }

    public class Q1
    {
        public static void Solve()
        {
            //the task 
            //get input until you get 3 digits number (includes negative numbers
            //max number
            int max = 0;
            int min = 0;
            bool init = true;
            while (true) {

                //get the input 
                Console.WriteLine("inset some number:");

                int input = int.Parse(Console.ReadLine());

                //initialize numbers
                if (init)
                {
                    max = input; min = input;
                    init = false;
                }

                //assigning max
                if (input > max) max = input;

                //assigning min
                if (input < min) min = input;

                //checking if it's have 3 digits 
                if (input / 10 >= 10 || input / 10 <= -10)
                {
                    Console.WriteLine("max number = {0} | min number = {1}", max, min);
                    return;
                }
            }
           
        }

    }

    public class Q2
    {
        //try 3 running, not more 

        public static bool IsValid(string s)
        {

            //check if it's odd 
            if(s.Length % 2 == 0 )return false;

            //check if valid                                            
            //s[0] - first char s[length-1] last char - s[length / 2] - middle char. 
            if (s[0] == s[s.Length-1] && s[0] == s[s.Length / 2])
            {
                return true;
            }

            return false;
        }
        //B - get 23 strings. I did the number as parameter for changing it
        public static void GetNStrings(int length) {
            
            //preparing array for holding the values
            string[] myString = new string[length];

            int i = 0;
            int countValids = 0;
            while (i < myString.Length)
            {
                //getting the strings
                Console.WriteLine("Insert {0}/{1} strings please...", i+1, length);
                string str = Console.ReadLine();
                if (IsValid(str))
                {
                    Console.WriteLine("valid...");
                    countValids++;
                }
                i++;
            }
            Console.WriteLine("Valids Strings - {0}, Invalid Strings - {1}", countValids, length - countValids);

        }
    }

    public class Q3
    {
        public static void Solve()
        {
            Console.WriteLine("Solve and test Q3");
            int[] arr1 = { 1, 4, -6, -4 };
            int[] arr2 = { 1, 4, -6, -4 , 3};

            int[] arr3 = { 1, 4, -6, 4 };

            Console.WriteLine(IsEqualArray(arr1));//true
            Console.WriteLine(IsEqualArray(arr2));//false
            Console.WriteLine(IsEqualArray(arr3));//false

        }
        public static bool IsEqualArray(int[] array)
        {
            if (array.Length % 2 != 0) return false;
            int countNegative =0, countPositive = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != 0)
                {
                    if(array[i] < 0)
                    {
                        countNegative++;
                    }
                    else { countPositive++; }
                }
                else
                {
                    return false;
                }

            }

            return countNegative == countPositive;
        }
    }


}

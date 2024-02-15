using System;


namespace c_sharp_basics_lingar.algorithmic.tests.summer_23_B
{
    internal class SmallQuestions
    {

        public static void Demo()
        {
           Q1.Solve();
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
}

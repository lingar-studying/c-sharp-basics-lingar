using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic.tests.summer_22_A
{
    public class Summer22ASolutions
    {

        public static void Demo()
        {
            SolveQ1();
        }

        public static void SolveQ1()
        {

            bool toContinue = true;
            int countZ = 0;
            while (toContinue)
            {
                Console.WriteLine("insert some string");
                string str = Console.ReadLine();
                if((str[0]+"").ToLower().Equals("a") && (str[str.Length-1] + "").ToLower().Equals("a"))
                {
                    Console.WriteLine("Stopping - this string starting and ending with a");

                    Console.WriteLine("Amount of z string: " + countZ);
                }
                else if((str[0] + "").ToLower().Equals("z") && (str[str.Length - 1] + "").ToLower().Equals("z"))
                {
                    countZ++;
                }
                
            }
           
        }
    }

    
}

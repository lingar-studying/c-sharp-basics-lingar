using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic
{
    public class AlgoUtils
    {
        public static void Demo()
        {
            Console.WriteLine("Some digits printing");

            int num = 1234;

            PrintDigitByMath(num);
            PrintDigitByMath(num, true);
        }



        public static void PrintDigitByMath(int number1)
        {
            Console.WriteLine("digits from the right of :" + number1);
            while (number1 > 0)
            {
                int digit = number1 % 10;
                Console.WriteLine(digit);
                number1 /= 10;
            }
        }

        public static void PrintDigitByMath(int number1, bool b)
        {
            Console.WriteLine("digits from the left of :" + number1);

            //find the first divider: 
            int tempNumber = number1;
            int multiple10 = 1;
            while (tempNumber > 10)
            {
                multiple10 *= 10;
                tempNumber /= 10;
            }

            while (multiple10 > 0)
            {
                int digit = number1 / multiple10;
                Console.WriteLine(digit);
                number1 -= (digit * multiple10);
                multiple10 /= 10;
            }
        }
    }
}

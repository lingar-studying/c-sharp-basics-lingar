using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.general
{
    public class DemoEnum
    {

        public static void Demo()
        {
            PrintDayWithoutEnum(1);
            PrintDayWithoutEnum(10);
            PrintDay(Day.SUNDAY);
            PrintDay(Day.TUESDAY);


        }
        //without enum
        public static void PrintDayWithoutEnum(int day)
        {

            switch (day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    return;
                case 1:
                    Console.WriteLine("Monday");
                    return;

                case 2:
                    Console.WriteLine("Tuesday");
                    return;
                //.... 

                default:
                    Console.WriteLine("Not valid day");
                    return;

            }

        }


        public static void PrintDay(Day day)
        {

            switch (day)
            {
                case Day.SUNDAY:
                    Console.WriteLine("Sunday");
                    return;
                case Day.MONDAY:
                    Console.WriteLine("Monday");
                    return;

                case Day.TUESDAY:
                    Console.WriteLine("Tuesday");
                    return;
                //.... 

                default:
                    Console.WriteLine("Not valid day");
                    return;

            }

        }

    }
}

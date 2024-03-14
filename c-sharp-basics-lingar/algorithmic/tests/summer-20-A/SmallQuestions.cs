using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic.tests.summer_20_A
{
    public class SmallQuestionsSummer20A
    {
        public static void Demo()
        {


            //Q1 solution:
            SolveQ1();
            //Repsent 18:43 --> 317
            Clock clock1 = new Clock(17, 42);
            Console.WriteLine(clock1.GetInterval());
            //Repsent 17:15 --> 405
            Clock clock2 = new Clock(16, 14);
            Console.WriteLine(clock2.GetInterval());
            Console.WriteLine("result = " + clock2.GetInterval2());

            //Repsent 20:20 --> 220
            Clock clock3 = new Clock(19, 19);
            Console.WriteLine(clock3.GetInterval());

            CheckLater();


        }


        public static void CheckLater()
        {
            Console.WriteLine("write flight 1 hour:");
            int hour = int.Parse(Console.ReadLine());

            Console.WriteLine("write flight 1 minute:");
            int minute = int.Parse(Console.ReadLine());

            Clock flight1 = new Clock(hour - 1, minute - 1);

            Console.WriteLine("write flight 2 hour:");
            hour = int.Parse(Console.ReadLine());

            Console.WriteLine("write flight 2 minute:");
            minute = int.Parse(Console.ReadLine());

            Clock flight2 = new Clock(hour - 1, minute - 1);

            int intervalFlight1 = flight1.GetInterval();

            int intervalFlight2 = flight2.GetInterval2();

            if(intervalFlight1 < intervalFlight2)
            {
                Console.WriteLine("Flight 1 is later - " + (flight1.hour+1) + ":" + (flight1.min + 1));
            }
            else
            {
                Console.WriteLine("Flight 2 is later - " + (flight2.hour + 1) + ":" + (flight2.min + 1));

            }



        }

        public static void SolveQ1()
        {
            Console.WriteLine("Demo1");
            //WorkingClass.Demo1(); recursion

            int count = 0;
            int countEven = 0;
            int countPositives = 0;
            int sum = 0;
            int num = 10;
            Console.WriteLine("Type number");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                //Console.WriteLine("Type number");
                //num = int.Parse(Console.ReadLine());

                count++;

                //count events 
                if (num % 2 == 0)
                {
                    countEven++;

                }
                if (num > 0)
                {
                    sum += num;
                    countPositives++;

                }
                num = int.Parse(Console.ReadLine());


            }

            //find the average of the positive
            double average = (double)sum / countPositives;
            int x = 5;
            double d2 = x;

            Console.WriteLine("counts = " + count + "| count evens = " + countEven + "|average = " + average);

        }



    }//end of class



    //TODO 
    // - create other function in another class 
    // - it will get two int[] of pair of [hh,mm]
    // - create clock from each of the pairs 
    // - compare what clock 

    public class Clock
    {
        public  int hour; //שעה 0-23
        public int min; //דקות 0-59
        public Clock(int hour, int min)
        {
            this.hour = hour;
            this.min = min;
        }

        public int GetInterval()
        {

            //get hour gap without the min 
            int hourGap = 23 - hour;
            int result = (hourGap * 60) - (min + 1);
            //int result = ((hourGap+1)*60) - (min+1);
            return result;
        }

        public int GetInterval2()
        {

            //get hour gap without the min 
            int hours = 23 - hour;
            
            //int result = ((hourGap+1)*60) - (min+1);
            //if(min == 0)
            //{
            //    minutes = 0;
            //}
            return (hours * 60) - (min +1);
        }
    }


    public class Q2
    {

    }
}

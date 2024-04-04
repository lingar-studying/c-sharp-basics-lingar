using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar
{
    public class Drafti
    {
        public static void Demo()//
        {
            Console.WriteLine("Demo");


            Console.WriteLine("enter numbers");
            int num = int.Parse(Console.ReadLine());
            double avg = 0;
            int count = 0, countcouple = 0, sum = 0;
            while (num != 0)
            {
                count++;
                while (num > 0)
                {
                    count++;
                    if (num % 2 == 0)
                    {
                        countcouple++;
                    }
                    sum = sum + num;
                    avg = sum / count;
                }
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
            Console.WriteLine(countcouple);
            Console.WriteLine(avg);


        }
    }
}

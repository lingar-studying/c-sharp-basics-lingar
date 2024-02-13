using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.algorithmic.some_challenges
{
    internal class Euler
    {
        public static void Demo()
        {
            int result = Euler1.SolveByRecursion(10, 3 , 0);//recursion not working well in C#. On 1_000_000 it will fail
            //https://stackoverflow.com/questions/18581502/recursive-function-calls-throw-stackoverflowexception
            Console.WriteLine( "result euler 1 = " + result);
            result = Euler1.SolveByWhile(1000);
            Console.WriteLine("result euler 1 = " + result);

            Euler2.FindByWhile(4000_00_0);
            Console.WriteLine("euler 3 - ");
            Euler3.FindByFor(600_851_475_143);

        }
    }

    public class Euler1
    {
        public static int SolveByRecursion(int upperBound, int lastNumber, int sum)
        {
            if (lastNumber % 3 == 0 || lastNumber % 5 == 0) sum += lastNumber;

            if(lastNumber ==upperBound) return sum;

            return SolveByRecursion(upperBound, ++lastNumber, sum);
        }

        public static int SolveByWhile(int upperBound)
        {
            int number = 3;
           int sum = 0;
            while(number < upperBound)
            {
                if (number % 3 == 0 || number % 5 == 0) sum += number;
                number++;
                
                //Console.WriteLine("number = " + number);
            }

            return sum;
        }
    }

    public class Euler2
    {
        public static void FindByWhile(int upperBound)
        {
            int currentNumber = 2;
            int previousNumber = 1;

            int sum = 2;

            while(currentNumber < upperBound)
            {
                int temp = currentNumber + previousNumber;

                previousNumber = currentNumber;
                currentNumber = temp;
                if(currentNumber % 2 == 0)
                sum += currentNumber;
            }
            Console.WriteLine("euler2 = " + sum);

        }
    }

    public class Euler3
    {
        public static void FindByFor(long num)
        {
            //long startingPoint = Math.Sqrt(num) % 2 == 0 ? (long)Math.Sqrt(num) - 1 : (long)Math.Sqrt(num);
            //long startingPoint =( num / 2) - 1;//? (long)Math.Sqrt(num) - 1 : (long)Math.Sqrt(num);


            long startingPoint = (num / 2) % 2 == 0 ? (num / 2) - 1 : (num / 2);

            //long startingPoint = 35;// (num / 2) % 2 == 0 ? (num / 2) - 1 : (num / 2);


            for (long i = startingPoint; i >2; i -=2)
            {
                if(num % i == 0)
                {
                    if (IsPrime(i)) { Console.WriteLine(i);return; }
                }
            }
            Console.WriteLine(2);

        }

        public static bool IsPrime(long num)
        {

            //long startingPoint = Math.Sqrt(num) % 2 == 0 ? (long)Math.Sqrt(num) - 1 : (long)Math.Sqrt(num);
            
            long startingPoint = num / 2;

            if (startingPoint == 2) return true;


            for (long i = startingPoint; i > 2; i--)
            {
                if(num % i == 0 )return false;
            }
            return true;
            
        }
    }

    
}

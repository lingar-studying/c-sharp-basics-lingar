using System;
using System.Collections.Generic;
using System.Text;
//https://www.bigocalc.com/ - calculator
namespace c_sharp_basics_lingar.algorithmic.complexity
{
    public class ComplexityDemo
    {

        public static void Demo()
        {
            Sum(9, 10);

            Print(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12});
            Print2(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            LogN(10);
            NM(5, 10);
            nPowN(10);

        }

        //O(1)
        public static void Sum(int x, int y)
        {
            Console.WriteLine("O(1)");

            int d = 10;
            String s = "sdd";


            Console.WriteLine( x + y);

        }

        //O(n)
        public static void Print(int[] arr)
        {
            Console.WriteLine("O(n)");

            foreach (int i in arr) Console.WriteLine(i);
        }

        //O(2*n) --- > O(n) since constant are dropped
        public static void Print2(int[] arr)
        {
            Console.WriteLine("O(2*n)");

            foreach (int i in arr)
            {
                for(int j =0; j < i*2; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
        //O(Log N) -->recursion
        public static void LogN(int n)
        {
            Console.WriteLine("O(Log N)");
            if(n <= 0) { return; }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
            n = n / 2;
            LogN(n);

        }
        //O(n*m)
        public static void NM(int n, int m)
        {
            Console.WriteLine("O(n*m)");
            for( int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine( "m " + j);
                }
            }
        }

        //O(n^2)
        public static void nPowN(int n)
        {
            Console.WriteLine("O(n^2)");
            for(int i = 0; i < n; i++)
            {
                for(int k = 0; k < n; k++)
                {
                    Console.WriteLine("k = " + k);
                }
            }
        }


        public static void DraftTry(int n)
        {
            Console.WriteLine("DraftTry");
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine("k = " + k);
                }

                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine("k = " + k);
                }

                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine("k = " + k);
                }
            }
        }
    }

    
}

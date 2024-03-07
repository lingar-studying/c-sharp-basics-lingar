using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar
{
    public class DemoBasicsLoop
    {
        public static void Demo()
        {
            Console.WriteLine("Some object demo");

            int z = 10;
            SomeLoops o = new SomeLoops();

            Console.WriteLine("x = " + o.x);

            //Console.WriteLine("x = " + o.Do1);
            o.Do1();
            Console.WriteLine("x = " + o.x);

            SomeLoops o2 = new SomeLoops();
            Console.WriteLine("o2.x = " + o2.x);//5 

            o2.x = 7;
            Console.WriteLine("x = " + o.x);//10
            Console.WriteLine("o2.x = " + o2.x);//7

            Console.WriteLine("staticX = " + SomeLoops.staticX);//90

            SomeLoops.staticX = 10;

            Console.WriteLine("staticX = " + SomeLoops.staticX);//10

            o.ChangeStatic(30);
            o2.PrintStatic();//30

            SomeLoops.staticX = 100;

            o.PrintStatic();//100
            int i = 2;
            //mock for testing:
            int[] arr1 = { 1, 4, 5, 9, 7 };
            int[] arr2 = { 1, 4, 5, 50, 9, 7 };
            int[] arr3 = { 1, 4, 5, 9, 7 };

            int[] arr4 = new int[5];

            arr4[0] = 12;
            arr4[1] = 2;
            SomeLoops.Print50(arr2);

            Console.WriteLine("is 50 found ? " + SomeLoops.Is50Found(arr2));


            Console.WriteLine("is 50 found ? " + SomeLoops.Is50Found(arr3));


            Console.WriteLine("is 50 found ? " + SomeLoops.DemoBreak(arr2));
            Console.WriteLine("Staticx = " + SomeLoops.staticX);

            SomeLoops.PrintFoundOrNot(arr2);
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i > 7);

        }
    }

    public class SomeLoops
    {
        public static int staticX = 90;
        public int x = 5;

        public void Do1()
        {
            x = 10;
        }

        public static void Do2()
        {
            //x = 20;
        }

        public void PrintStatic()
        {
            Console.WriteLine("static x = " + staticX);
        }

        public void ChangeStatic(int x )
        {
            staticX = x;
            
        }



        //case for using return in array 
        public static void Print50(int[] myArray)
        {
            for(int i =0; i< myArray.Length; i++)
            {
                //return;
                Console.WriteLine("myArray element " + i + " = " + myArray[i]);

                if (myArray[i] == 50)
                {
                    Console.WriteLine("****Special Print 50 found!!!****" + myArray[i]);
                    return;
                }
            }

        }

        //case for using return value in array 
        public static bool Is50Found(int[] myArray)
        {
            //bool found = false;
            for (int i = 0; i < myArray.Length; i++)
            {
                //return;
                Console.WriteLine("myArray element " + i + " = " + myArray[i]);

                if (myArray[i] == 50)
                {
                    //found = true;
                    return true;
                }
                
            }

            //return found;
            return false;

        }


        public static SomeLoops ReturnDemo()
        {

            SomeLoops o = new SomeLoops();


            //return o;
            //return new Obj();
            //Obj o2;
            return null;
        }

        //case for using return value in array 
        public static bool DemoBreak(int[] myArray)
        {
            bool found = false;
            for (int i = 0; i < myArray.Length; i++)
            {
                //return;
                Console.WriteLine("myArray element " + i + " = " + myArray[i]);

                if (myArray[i] == 50)
                {
                    found = true;
                    break;
                    //return true;
                }

            }
            if (found)
            {
                Console.WriteLine("??");
                staticX = 500;
            }
            Console.WriteLine("More actions here... ");

            return found;
            //return false;

        }

        //use case for continue
        public static void PrintFoundOrNot(int[] myArray)
        {

            for (int i = 0; i < myArray.Length; i++)
            {
                
                if (myArray[i] == 50)
                {
                    Console.WriteLine("FOUND 50! " + myArray[i]);
                    continue;
                    //return true;
                }
                
                Console.WriteLine("Not FOUND " + myArray[i]);

                

            }

        }
    }
}

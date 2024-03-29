using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.spring_22_A
{
    class Spring22AQ4
    {

        public static void Demo()
        {
            Abc abc = new Abc();
            Bcd bcd = new Bcd();
            Abc mixed = new Bcd();

            //abc.GoodCode();
            //Console.WriteLine(bcd.GetMyVal());
            Console.WriteLine("Abc");
            abc.Func();
            //Console.WriteLine(abc is Abc);
            //Console.WriteLine((abc is Bcd )+ "?");
            Console.WriteLine("Bcd");
            bcd.Func();
            Console.WriteLine("mixed");
            mixed.Func();
            Console.WriteLine("abc func = {0}, bcd func = {1}", Abc.countA, Abc.countB );
            Abc one = new Bcd(127, 1.4);
            Abc two = new Abc(613);
            //bool myBool = one.GoodCode();
            //Console.WriteLine(bcd.myVal); ;
            //bool myBool = two.GoodCode();
            bool myBool = ((Bcd)one).GoodCode();

            //bool myBool2 = ((Bcd)two).GoodCode();
        }

        public class Abc
        {
            public static int countA = 0;
            public static int countB = 0;

            private int myVal;
            protected string myString;


            public void DoSomething(Abc abc)
            {
                abc.myVal = 10;
            }

            public int GetMyVal()
            {
                //https://stackoverflow.com/a/983061
                //GetType
                //is

                
                //double d = x;
                return myVal;
            }
            public Abc() { myVal = 1; myString = "BAD"; }
            public Abc(int val) { myVal = val; myString = "GOOD!"; }
            public int Func() {
                Console.WriteLine("is this Abc ? " + (this is Abc));
                Console.WriteLine("is this Bcd ? " + (this is Bcd));
                Console.WriteLine("Get type " + (this.GetType()));

                if(this is Bcd)
                {
                    countB++;
                }
                else
                {
                    countA++;
                }
                return 1; 
            
            }
        }

        //except myVal everything is accessible 

        public class Bcd : Abc
        {

            public Bcd() { }
            private double x;
            public Bcd(int myVal, double x) : base(myVal)
            {
                this.x = x;
            }
            public bool GoodCode() {
                Console.WriteLine("good code");
                //int x = myVal;
                String s = myString;
                return x > 15.0; }
        }

    }
}

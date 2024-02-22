using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.middle_test
{
    public class MiddleTestQ4
    {
        public static void Demo()
        {
            A a = new A();
        }
    }

    public class A
    {

        //Section A
        public int Foo(int i)
        {
            return i;
        }
        // public int Foo() { return 1; }//OK - overloading

        //public int Foo(double i) { return (int)i; }//OK - overloading

        //public double Foo(int i) { return i; }//Compilation

        //public double Foo(double i) { return i; }//OK - overloading

        //public void Foo(double i) { Console.Write(i); }//OK - overloading


    }
}


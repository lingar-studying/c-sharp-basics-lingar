using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.middle_test
{
    public class MiddleTestQ3
    {
        public static void Demo()
        {
            A a = new A();
            //Console.WriteLine(a.Foo(1.1));
            //a.Foo(2, 3);
            //a.Foo(5.5);
            //Console.WriteLine();
            //a.Foo(5.5);
            B b = new B();
            //b.Foo(1.5);
            //b.Foo();
            //Console.WriteLine(b.Foo(2));
        }
    }

    public class A
    {

        //Section A
        //public int Foo(int i)
        //{
        //    return i;
        //}
        //public int Foo() { return 1; }//OK - overloading

        //public int Foo(double i) { return (int)i; }//OK - overloading

        //public double Foo(int i) { return i; }//Compilation

        //public double Foo(double i) { return i; }//OK - overloading

        //public void Foo(double i) { Console.Write(i); }//OK - overloading

        //Section B

        public virtual int Foo(int i)
        {
            return i;
        }

    }

    public class B : A
    {
        //public int Foo() { return 10; }// OK - Overloading
        //public override int Foo(int i) { return i * 10; }//OK - Overriding

        //public override double Foo(int i) { return i * 10; }//Compilation - because of the type

        //public double Foo(double i) { return i * 10; }// OK - overloading

       //public override void Foo(double i) { Console.Write(i); }//Compilation 
    }

}


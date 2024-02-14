using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.spring_22_A
{
    internal class Question3
    {
        public static void Demo()
        {
            A a = new A();
            a.Do1();
        }

    }
    public class A // : B//-->Won't compile
    {
        private void G(int x, int y)
        {

        }
        public void Do1()
        {
            A a = new B();
            int x = 1;
            
            x.G2();
            x.G2();//will work by below

            Console.WriteLine(x);
            //String xx = Do1;
           
            Console.WriteLine(GetType());

            a.G(1,2);

            BB bb = new BB();
            bb.Demo();
        }
    }
    public class B : A
    {

    }

    public static class IntExtensions
    {
        public static void G2(this ref int number)
            => number++;

        // Take note of the extra ref keyword here
        public static void RefIncrement(this ref int number)
            => number++;
    }

    //B section 
    public class AA
    {
        protected virtual void A1()
        {
            Console.WriteLine("Hello A");
        }
        protected void A2()
        {
            A1();
        }
    }

    public class BB : AA
    {
        protected override void A1()
        {
            Console.WriteLine("Hello A");
        }

        public void Demo()
        {
            BB b = new BB();

            b.A2();
        }

        public BB()
        {
           

        }

    }
}

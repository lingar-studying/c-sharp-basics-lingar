using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.magen_spring_24_A
{
    public class MagenSpring24AQ4
    {
        //קטע הקוד שצריך לנתח:
        public static void Demo()
        {
            Test test = new Test();
            test.TestIt();
        }
    }


    //We have changed the class Names for preventing duplicates conflicts. 
    public class A_123
    {
        private static int countA = 0;
        protected int n;

        public A_123(int n1)
        {
            this.n = n1;
            A_123.countA++;
            Console.WriteLine("A {0} num is {1} ", A_123.countA, this.n);
        }
        public int GetN()
        {
            return this.n;
        }
        public virtual void Do()
        {
            for (int i = 0; i < this.n; i++)
                Console.Write(i + ",");
            Console.WriteLine();
        }

        public virtual void Print()
        {
            Console.WriteLine(this.n);
        }

    }


    public class B_123 : A_123
    {
        private static int countB = 0;

        public B_123(int n2) : base(n2)
        {
            B_123.countB++;
            Console.WriteLine("B {0} has {1} ", B_123.countB, n2);
        }

        public override void Do()
        {
            Console.WriteLine("Do B");
        }
    }



    public class C_123 : B_123
    {
        private static int countC = 0;
        private A_123 a;

        public C_123(int n1, int n2) : this(n1, new A_123(n2))
        { }
        public C_123(int n1, A_123 a) : base(n1)
        {
            this.a = a;
            countC++;
            Console.WriteLine("C is " + (a.GetN() + this.n));
        }
        public override void Print()
        {
            base.Print();
            this.a.Print();
        }
    }

    public class Test
    {
        private A_123[] arr;

        public Test()
        {
            arr = new A_123[3];
            arr[0] = new A_123(4);
            arr[1] = new B_123(2);
            arr[2] = new C_123(1, 6);
        }

        public void TestIt()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Do();
                arr[i].Print();
            }
        }
    }




}

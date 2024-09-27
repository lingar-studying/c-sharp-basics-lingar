using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.sping_23_A
{
    public class Spring23ASolutions
    {

        public static void Demo()
        {
            //question 3: 
            //see the code.
            //B - only 2 won't work since it's duplicate. THe others are proper overloading
            //C- All won't work since Method isn't virtual and isn't available for overriding.
            //If it was - only 2 was work - because  It's suppose to be the exact method - in code too.


            //question 8
            Console.WriteLine("Answer 8:");
            Tester.Demo();

        }

        public static void Main2()
        {
            Spring23A a1 = new Spring23B(4, 2);
            Console.WriteLine(a1);
            Spring23A a2 = new Spring23A(4, 2);
            Console.WriteLine(a2);
            Spring23B a3 = new Spring23B(4, 2);
            Console.WriteLine(a3);

            Spring23A b1 = new Spring23A();
            Console.WriteLine(b1);

            Spring23A c1 = new Spring23B("something");
            Console.WriteLine(c1);

            
        }

    }

    public class Spring23A
    {

        protected int x;
        public Spring23A()
        {
            this.x = 5;
        }
        public Spring23A(int x)
        {
            this.x = x;
        }
        public Spring23A(int x, int y) : this(x + y)
        {
        }
        public int Method(int i)
        {
            return x + i;
        }
        public override string ToString()
        {
            return this.x + " * ";
        }


    }
    public class Spring23B : Spring23A
    {
        private int y;
        public Spring23B(int x) : base(x, x)
        {
            this.y = x;
        }
        public Spring23B(int x, int y) : this(x * y)
        {
        }
        public Spring23B(string s)
        {
            Console.WriteLine(s + "% " + this.y);
        }
        public override string ToString()
        {
            return this.x + " " + this.y;
        }
    }

    public class One
    {
        protected int x;
        public One()
        {
            this.x = 1;
        }
        public One(int x)
        {
            this.x = x;
        }
        public virtual void F(int x)
        {
            this.x += x;
        }
        public override string ToString()
        {
            return "x=" + this.x;
        }
    } // end of One
    public class Two : One
    {
        public Two() : base(3)
        {

        }
        public Two(int x)
        {
            base.F(x);
            F(x);
        }
        public override void F(int x)
        {
            this.x -= x;
            base.F(x);
        }
    }// end of Two
    public class Tester
    {
        public static void Print(One[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + " " + arr[i]);
            }
        }
        public static void DoF(One[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].F(num);
            }
        }
        public static void What(One[] arr)
        {
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Two)
                    k++;
            }
            k = arr.Length - k;
            Console.WriteLine("k = " + k);
        }
        public static void Demo()
        {
            One[] arr = new One[6];
            arr[0] = new One();
            arr[1] = new One(3);
            arr[2] = new Two();
            arr[3] = new Two(2);
            arr[4] = new Two(5);
            arr[5] = arr[1];
            Print(arr);
            DoF(arr, 2);
            Print(arr);
            What(arr);
        }
    }

}

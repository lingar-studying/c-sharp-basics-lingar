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

    }
}

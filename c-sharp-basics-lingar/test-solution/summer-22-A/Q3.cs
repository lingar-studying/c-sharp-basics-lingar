using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.summer_22_A
{
    public class Summer22AQ3
    {
        public static void Test()
        {
            A[] array = new A[4];
            array[0] = new C();
            array[1] = new B();
            array[2] = new A();
            array[3] = new B();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[" + i + "] = " + array[i]);
                array[i].Method(i + 2);
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }

        }
    }

     class A
    {
        protected int x;
        public A()
        {
            x = 0;
        }
        public virtual void Method(int num)
        {
            x += num;
        }
        public override string ToString()
        {
            return "" + x;
        }
    }// end of class A
     class B : A
    {
        private int y;
        public B()
        {
            y = 1;
        }
        public override void Method(int num)
        {
            x -= num;
            y += num;
        }
        public override string ToString()
        {
            return "" + x + "." + y;
        }
    }// end of class B
    class C : A
    {
        private int y;
        public C()
        {
            y = 10;
        }
        public override void Method(int num)
        {
            x += num;
            y += num;
        }
        public override string ToString()
        {
            return "" + x + "/" + y;
        }
    } // end of class C
}

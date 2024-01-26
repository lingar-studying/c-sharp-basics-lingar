using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.draft
{
    class DemoLesson3
    {
        public static void Run()
        {
            //MyAbstract m = new MyAbstract();
        }
    }

    public abstract class MyAbstract
    {
        public int x, y, z;

        public void ImplementedMethod()
        {
            Console.WriteLine("ImplementedMethod");
        }

        public abstract int AbstractMethod1(int x);
    }

    public class ImplementsMyAbstract: MyAbstract
    {
        public override int AbstractMethod1(int x)
        {
            return 0;
        }
    }
}

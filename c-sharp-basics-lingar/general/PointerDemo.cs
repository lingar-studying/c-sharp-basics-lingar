using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.general
{
    public class PointerDemo
    {
        public static void Demo()
        {
            int x = 8;
            int y = x;

            x = 10;

            Console.WriteLine("y = " + y);
            SomeA a = new SomeA();
            SomeA b = a;

            a.x = 20;

            Console.WriteLine("b.x = " + b.x);

            ChangeX(x);
            Console.WriteLine("x = " + x);
            ChangeX(a.x);
            Console.WriteLine("a.x = " + a.x);

            ChangeSomeA(a);
            Console.WriteLine("a.x = " + a.x);

            String str = "other val";

            ChangeStr(str);//the value won't persist

            Console.WriteLine("str = " + str);

            //checing change the source

            a = new SomeA();
            a.x = 200;
            Console.WriteLine("a.x = " + a.x);
            
            Console.WriteLine("b.x = " + b.x);

            SomeA c = new SomeA();

            SomeA d = c;

            c = a;
            Console.WriteLine("c.x = " + c.x);

            Console.WriteLine("d.x = " + d.x);

            a = c = new SomeA();//assign to both.... 

        }

        public static void ChangeX(int x)
        {

            Console.WriteLine("x = " + x);

            x = 200;

            Console.WriteLine("x = " + x);
        }

        public static void ChangeStr(string s)
        {

            s = "new word";
        }

        public static void ChangeSomeA(SomeA obj)
        {
            //x = 200;
            obj.x = 300;
        }
    }

    public class SomeA
    {
        public int x = 10;
        public int y = 20;
    }
}

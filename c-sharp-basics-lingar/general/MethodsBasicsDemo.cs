using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.general
{
    public class MethodsBasicsDemo
    {

        //fields = variables = משתנים
        public static int number1 = 100;

        //static - method (Connected to the Class Name)
        public static int AddAndMultiple(int add, int multiple, string myName)
        {

            Console.WriteLine(myName + " Running this method");
            return AddAndMultiple(add, multiple);

            
        }

        public static int AddAndMultiple(int add, int multiple)
        {
            int temp = number1;
            temp = number1 + add;

            temp = temp * multiple;

            return temp;
        }

        private int AnotherPrivateMethod(int add, int multiple, string myName)
        {


            return 5;
        }


        public static void Demo()
        {

            int x = 2;
            int result2 = MethodsBasicsDemo.AddAndMultiple(9, x);
            Console.WriteLine("MY Result = " + result2);

            result2 = MethodsBasicsDemo.AddAndMultiple(3, 4, "Izhar");
            Console.WriteLine("MY Result = " + result2);
        }


        
    }
}

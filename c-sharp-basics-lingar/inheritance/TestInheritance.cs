using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.inheritance
{
    public class TestInheritance
    {
        public static void Test1()
        {
            Console.WriteLine("Test Inheritance");
            Car c = new Car();
            c.DisplayDetails();

            Car c2 = new Car(300, "Honda", 40);
            //c2.DisplayDetails();
            c2.DisplayCarDetails();
        }
    }
}

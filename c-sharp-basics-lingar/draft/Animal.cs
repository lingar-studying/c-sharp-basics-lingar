using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.draft
{
    public class Animal
    {
        public void Eat() => System.Console.WriteLine("Eating.");

        public override string ToString() => "I am an animal.";
    }

    class Reptile : Animal { }
    class Mammal : Animal { }

    public class UnSafeCast
    {
       public static void Main()
        {
            Test(new Reptile());
            Test(new Mammal());

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        static void Test(Animal a)
        {

            ImplementedInterface1 i = new ImplementedInterface1();
            Interface1 i1 = new ImplementedInterface1();

            i.do2();
            ((ImplementedInterface1)i1).do2();

            // System.InvalidCastException at run time
            // Unable to cast object of type 'Mammal' to type 'Reptile'
            if(a.GetType() == typeof (Reptile))

            
                //if (a is Reptile)

                {
                    Reptile r = (Reptile)a;

            }
        }
    }

    public interface Interface1
    {
        public void do1();
    }

    public class ImplementedInterface1 : Interface1
    {
        public void  do1()
        {

        }

        public void do2()
        {

        }
    }
}

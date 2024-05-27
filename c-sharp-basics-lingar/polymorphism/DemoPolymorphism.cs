using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.polymorphism
{
    public class DemoPolymorphism
    {

        public static void Demo()
        {
            Employee e = new Employee();

            Employee e1 = new Teacher();

            Teacher e2 = (Teacher)e1;

            //Teacher e3 = new Employee();//not working - compliation needed explicit (=מפורש ) casting

            // Teacher e4 = (Teacher)new Employee();//run time error 

            //Teacher e5 = (Teacher)new Plumber();

            IAutomatic i1 = new UAV();

            IAutomatic i2 = new SmallUAV();

            //IAutomatic i3 = new Plain();// צריך המרה מפורשת

            //IAutomatic i4 = (IAutomatic) new Plain();// runtime error - unable to cast
            ICartoon a8 = (ICartoon)new Character1();

            IAutomatic i5 = (IAutomatic) new Jumbo();//will pass compliation!! Runtime error
            //ICartoon i21 = (ICartoon)new Character1();//runtime error

            Character1 i22 = new BugsBunny();

            ICartoon i23 = (ICartoon)i22;
            ICartoon i24 = (ICartoon)new DonaldDuck();//will pass compilation. Runtime error.
            Console.WriteLine("************");
            Apple a1 = new Apple(10);
            Object a2 = new Apple(10);
            Banana b1 = new Banana(10);
            Object b2 = new Banana(10);

            ICartoon a3 = (ICartoon)new Employee();

            ICartoon a5 = (ICartoon)new SomeOther();

            //*******
            //1
            //Console.WriteLine(a1.weight);//compliation - private field

            // 2
            //Console.WriteLine(((Banana)a2).GetWeight());//run time error - because we're reffering Object


            //3 
            //Console.WriteLine(a1.Equals(a2));//works call to Object.Equals(object)
            //Console.WriteLine(a1.Equals2(a2));//compliation error


            //4 -->working false
            //Console.WriteLine(a2.Equals(a1));

            Object a4 = a2;
            //Console.WriteLine(a2.Equals(a3));//True By Object

            //Console.WriteLine(((Apple)a2).Equals(a1));//True by Apple

            //5
            //Console.WriteLine(b1.Equals(b2));//true

            //6
            //Console.WriteLine(b2.Equals(b1));

            //7
            //Console.WriteLine(a1.Equals((Banana)b2));


            //8
            //Console.WriteLine(a1.Equals((Apple)a2));


            //9
            //Console.WriteLine(b1.Equals((Apple)a2));

            //10 - 
            //Console.WriteLine(b1.Equals((Banana)a2));

        }

    }

    public class SomeOther
    {

    }


    public class Employee
    {

    }

    public class Teacher : Employee
    {

    }

    public class MathTeacher : Teacher { }

    public class Plumber : Employee
    {

    }


    //interface example 1

    public interface IAutomatic
    {

    }

    public class Plain
    {

    }

    public class UAV : IAutomatic
    {

    }

    public class SmallUAV : UAV
    {

    }


    public class Jumbo : Plain
    {

    }

    //interface Demo 2

    public interface ICartoon
    {
        public void Do1();
    }

    public class Character1
    {

        public void Do1()
        {
            Console.WriteLine("Do something");
        }
    }

    public class BugsBunny : Character1, ICartoon
    {


    }

    public class DonaldDuck : Character1
    {


    }

    public class Apple
    {
        private int weight;
        public Apple(int w)
        {
            weight = w;
        }
        public int GetWeight()
        {
            return weight;
        }
        public bool Equals(Apple other)
        {

            Console.WriteLine("Apple Equals");
            return ((other != null) &&
            (weight == other.weight));
        }

        public bool Equals2(Apple other)
        {
            return ((other != null) &&
            (weight == other.weight));
        }
    }
    public class Banana
    {
        private int weight;
        public Banana(int w)
        {
            weight = w;
        }
        public int GetWeight()
        {
            return weight;
        }
        public override bool Equals(Object other)
        {

            Console.WriteLine("Equals Banana");
            return ((other != null) &&
            (other is Banana) &&
            (weight == ((Banana)other).weight));
        }
    }

}

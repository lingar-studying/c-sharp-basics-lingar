using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.general
{
    public class EqualsDemo
    {

        public static void Demo()
        {
            Console.WriteLine("Equals Demo");

            Cat c = new Cat();

            Cat c2 = new Cat();

            Console.WriteLine("is c equal c2 " + c.Equals(c2) );

            Cat c3 = c;

            Console.WriteLine("is c equal c3 " + c.Equals(c3));

            String s = "xyz";

            s.Equals("cvs");

            Dog d = new Dog("aaa");
            Dog d2 = new Dog("aaa");
            Dog d3 = new Dog("bbb");
            
            Console.WriteLine("is d.Equals(d2) " + d.Equals(d2));

            Console.WriteLine("is d.Equals(d3) " + d.Equals(d3));

            Console.WriteLine("is d.Equals(c) " + d.Equals(c));





        }
    }

    public class Cat
    {

    }

    public class Dog
    {
        // Public field.
        public string Breed;

        // Class constructor.
        public Dog(string dogBreed)
        {
            this.Breed = dogBreed;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Dog))
                return false;
            else
                return this.Breed == ((Dog)obj).Breed;
        }

        public override int GetHashCode()
        {
            return this.Breed.GetHashCode();
        }

        public override string ToString()
        {
            return this.Breed;
        }
    }


}

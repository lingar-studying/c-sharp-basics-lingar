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


            PersonBase regularPerson = new PersonBase("Regular Person");
            Hero hero = new Hero("BirdMan", "can fly");
            Console.WriteLine(regularPerson.GetStrengh());
            regularPerson.MaximumStrengh();




            Console.WriteLine(regularPerson.GetStrengh());

            Console.WriteLine(hero.GetStrengh());
            hero.MaximumStrengh();

            Console.WriteLine(regularPerson);

            Console.WriteLine(hero);

            Console.WriteLine(hero.GetStrengh());
            Ball ball123 = new Ball();
            Console.WriteLine(ball123);
            Hero hero2 = hero;
            Hero hero3 = new Hero("BirdMan", "can fly");

            Console.WriteLine("hero == hero2? " + hero.Equals(hero2));
            Console.WriteLine("hero == hero3? " + hero.Equals(hero3));

            PersonBase regularPerson2 = new PersonBase("Regular Person");
            Hero hero4 = new Hero("BirdMan", "can fly");
            SuperHero hero5 = new SuperHero("IceMan", "can freeze");
            Kid kid1 = new Kid("Dani", false);
            hero4.DoHero();
            //polymorphism demo
            PersonBase[] allObjectTogether = { regularPerson2, hero4, hero5, kid1 };

            for(int i=0; i< allObjectTogether.Length;i++)
            {

                PersonBase p = allObjectTogether[i];
                p.MaximumStrengh();
                Console.WriteLine(p);
                //p.DoHero();
            }

            PersonBase regularPerson3 = new PersonBase("Regular Person");
            PersonBase hero7 = new Hero("BirdMan", "can fly");
            PersonBase hero6 = new SuperHero("IceMan", "can freeze");
            PersonBase kid2 = new Kid("Dani", false);
           // hero7.DoHero();
            ((Hero)hero7).DoHero();
            DemoPoly(hero6);
            Console.WriteLine(hero7);
            DemoPoly(hero7);




            //Console.WriteLine(regularPerson.name);
            //Console.WriteLine(regularPerson.strengh);

        }
        public static void DemoPoly(PersonBase p)
        {
            p.MaximumStrengh();
            Console.WriteLine("p= " + p);
        }
    }
}

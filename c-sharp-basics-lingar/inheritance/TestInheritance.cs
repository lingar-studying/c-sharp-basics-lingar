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
            Console.WriteLine(regularPerson.GetStrengh());//0
            regularPerson.MaximumStrengh();




            Console.WriteLine(regularPerson.GetStrengh());//40

            Console.WriteLine(hero.GetStrengh());//0
            hero.MaximumStrengh();

            Console.WriteLine(regularPerson);//ToString (100)

            Console.WriteLine(hero);//ToString
            //Console.WriteLine(hero.GetStrengh());
            Ball ball123 = new Ball();
            Console.WriteLine(ball123);
            Hero hero2 = hero;
            Hero hero3 = new Hero("BirdMan", "can fly");

            Console.WriteLine("hero == hero2? " + hero.Equals(hero2));//true
            Console.WriteLine("hero == hero3? " + hero.Equals(hero3));//false
            Console.WriteLine("We here");

            PersonBase regularPerson2 = new PersonBase("Regular Person");
            Hero hero4 = new Hero("BirdMan", "can fly");
            SuperHero hero5 = new SuperHero("IceMan", "can freeze");
            Kid kid1 = new Kid("Dani", false);
            hero4.DoHero();
            //polymorphism demo
            PersonBase[] allObjectTogether = { regularPerson2, hero4, hero5, kid1 };
            //SuperHero[] allObjectTogether = { regularPerson2, hero4, hero5, kid1 };//not working


            for (int i=0; i< allObjectTogether.Length;i++)
            {

                PersonBase p = allObjectTogether[i];
                p.MaximumStrengh();
                Console.WriteLine(p);
                Console.WriteLine("loop");
                if (p is Hero)
                {
                    ((Hero)p).DoHero();

                }
            }

            //allObjectTogether[1].DoHero();

            PersonBase regularPerson3 = new PersonBase("Regular Person");
            PersonBase hero7 = new Hero("BirdMan", "can fly");
            PersonBase hero6 = new SuperHero("IceMan", "can freeze");
            PersonBase kid2 = new Kid("Dani", false);

            //string str = (string)kid2;
            int charNumber = (int)Math.Round(2.5);

           // hero7.DoHero();
            ((Hero)hero7).DoHero();
            DemoPoly(hero6);
            Console.WriteLine(hero7);
            DemoPoly(hero7);

            DemoPoly(hero2);


            //Hero hero234 = (Hero)new PersonBase("David");

            //Console.WriteLine(regularPerson.name);
            //Console.WriteLine(regularPerson.strengh);

            DemoInharitance.demo();

        }
        public static void DemoPoly(PersonBase p)
        {
            //p.DoHero();
            p.MaximumStrengh();
            Console.WriteLine("p= " + p);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar
{
    public class StaticsDemoAndMore
    {
        public static void Demo()
        {
            Console.WriteLine("");
           
            //B b1 = new A();
            //B b2 = new C(); 
            //A a1 = (C)b2;
            //D d1 = new C(); 
            //B b3 = new B(); 
            //D d2 = (D)new A();

            DemoStatic demoStatic1 = new DemoStatic();
            DemoStatic demoStatic2 = new DemoStatic();
            DemoStatic demoStatic3 = new DemoStatic();

            demoStatic1.x = 10;

            DemoStatic.staticX = 100; 

            demoStatic2.x = 20;

            DemoStatic.staticX = 200;


            demoStatic3.x = 30;

            DemoStatic.staticX = 300;


            demoStatic1.PrintInstance();//10

            demoStatic1.PrintStatic();//300

            demoStatic2.PrintInstance();//20

            DemoStatic.staticX = 450;

            demoStatic3.PrintStatic();//450

            demoStatic3.PrintInstance();//30

            List<int> listInstance = new List<int>();
            List<int> listInstance2 = new List<int>();

            listInstance.Add(1);
            ChildA c1 = new ChildA();
            ParentA p = c1;

            if(c1 is ParentA)
            {
                ParentA p2 = (ParentA)c1;

            }
            //ChildA c2 = new ParentA();//not working need explicity casting
           
           // ChildA c2 = (ChildA)new ParentA();
            InterfaceB ib1 = new ChildB();

            InterfaceB ib2 = new ChildC();

            InterfaceB[] interfaceBs = {ib1, ib2};

            foreach (InterfaceB interfaceB in interfaceBs)
            {
                Console.WriteLine(interfaceB.Do2(4));
            }
            A.Do3(ib2);
            A.Do3(ib1);
            InterfaceB ib3 = new ChildB();
            ChildB cb1 = (ChildB)ib3;
            
            InterfaceB ib4 = new ChildC();
            ChildB cb2 = (ChildB)ib4;
            ChildA ca1 = new ChildA();

           // ChildA ca2 = (ParentA)ca1;//Compliation 

        }
    }

    public class A :B  {
         

        public static void Do3(InterfaceB b)
        {

        }

    }
    public class B  { public B() { Console.WriteLine("B constructor"); } }

    public class C :D
    {

    }
    public class D : A
    {

    }

    public class ParentA
    {

    }
    public class ChildA: ParentA
    {
        //public void Do1();
    }

    public interface InterfaceB
    {

        public void Do1();

        public int Do2(int x);
    }

    public class ChildB : ChildA, InterfaceB
    {
        public void Do1()
        {

        }

        public int Do2(int x222)
        {
            return 0;
        }

    }

    public class ChildC : InterfaceB
    {
        public void Do1()
        {
            //something
        }

        public int Do2(int x222)
        {
            return 12;
        }

    }

    public class DemoStatic
    {

        public int x = 0;

        public static int staticX = 0;

        public void PrintStatic()
        {
            Console.WriteLine("static x = " + staticX);
        }

        public void PrintInstance()
        {
            Console.WriteLine("x = " + x);
        }
    }
}

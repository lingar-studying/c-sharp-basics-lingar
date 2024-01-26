// See https://aka.ms/new-console-template for more information
using c_sharp_basics_lingar.draft;
using c_sharp_basics_lingar;
using c_sharp_basics_lingar.test_summer_81.pickup_store_Q1;
using c_sharp_basics_lingar.hospital;
using c_sharp_basics_lingar.polymorphism;
using System;
using c_sharp_basics_lingar.test_solution;
using c_sharp_basics_lingar.chess;

using c_sharp_basics_lingar.Collecions_and_more;
using c_sharp_basics_lingar.test_solution;
namespace c_sharp_basics_lingar
{
    public class Program
    {
        public static void Main()
        {
            
            
            
            Console.WriteLine("By the help of God -" +
            "" +
            "Some C# basics");

            NotSmartImplementation.Demo();
            NotSmartImplementation n = new NotSmartImplementation();
            //n.Demo();
            //Second s = new Second();
            //Console.WriteLine("second = " + s);
            /*
             * We'll do here some tasks for demo and learn the basics of C# and OOP
             * 
             * 
             */
            //task 2 - insert Main method from RunMe. 
            //RunMe.Main();
            //TestPickupStore.runMe();
            //TestHospital.Test1();
            //TestHospital.Test2();
            //AbstractDemo.DemoAbstractClass();
            // ListLearning.DemoList();
            // Driver.Main222();
            InheritanceImplementation.Demo();
            InterfaceImplementation.Demo();
            AbstractImplementation.Demo();

        }
    }
}



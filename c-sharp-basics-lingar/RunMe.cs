﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_basics_lingar.inventory_module;
namespace c_sharp_basics_lingar

{
    public class RunMe
    {
        public static void Main()
        {

            Console.WriteLine("Some OOP examples cames here");
            Inventory  inventory=new Inventory();

           
            //Console.WriteLine("id after change - " + inventory.id);//---> will generate an inaccessible error




        }
        //public static void Main(string v, string[] args)
        //{
        //    // Display the number of command line arguments.
        //    Console.WriteLine(args.Length);
        //}
    }
}

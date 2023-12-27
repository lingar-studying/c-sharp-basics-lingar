using System;
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

            Console.WriteLine("inventory = " + inventory);

            inventory.Id = 100;
            //task 1 - Demo proper encaplsulated inventory 
            Console.WriteLine("inventory after change= " + inventory);
            //Console.WriteLine("id after change - " + inventory.id);//---> will generate an inaccessible error

            DemoAccessors.Demo();

            Structure structure=new Structure(10,20,5);

            structure.Country = "Israel";
            structure.City = "Netanya";

            Console.WriteLine("\nStrcture = {0}", structure);

            Warehouse warehouse=new Warehouse();

            string[] keepers = { "Avraham", "Izhak", "Yaakov" };
            warehouse.LightOn = true;

            warehouse.addGuards(keepers);

            Console.WriteLine("\nwarehouse = " + warehouse);

            warehouse.addGuards("David");

            Console.WriteLine("\nwarehouse =" + warehouse);






        }
        //public static void Main(string v, string[] args)
        //{
        //    // Display the number of command line arguments.
        //    Console.WriteLine(args.Length);
        //}
    }
}

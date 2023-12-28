using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_basics_lingar.inventory_module;
using c_sharp_basics_lingar.test_solution;
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

            warehouse.AddGuards("David");

            Console.WriteLine("\nwarehouse =" + warehouse);         

            warehouse.Dirt = 120;

            Console.WriteLine("\ntrying to add more then 100 in dirt:\nwarehouse =" + warehouse);

            warehouse.Dirt = 65;

            Console.WriteLine("\nadding correct value \nwarehouse =" + warehouse);

            structure.Clean();
            Console.WriteLine("\n Cleaning the structre \nstrtucture =" + structure);


            warehouse.Clean();
            Console.WriteLine("\n Cleaning the warehouse \nwarehouse =" + warehouse +"\n");

            
            warehouse.W = 20;
            warehouse.demoThis(10);
            // Console.WriteLine("\ndemo this:\n" + warehouse);

            //Product p1 = new Product(1111);
            //Product p2 = new Product(2222);

            warehouse.AddProduct(1111, 10);
            warehouse.AddProduct(2222, 20);

            warehouse.AddProduct(3333, 20);
            warehouse.AddProduct(4444, 20);
            warehouse.AddProduct(5555, 20);
            warehouse.AddProduct(6666, 20);

            Console.WriteLine("\nadding products: \n" + warehouse );

            Console.WriteLine("\nproducts amount = " + Product.ProductDailyAmount);

            warehouse.RemoveProduct(2);
            warehouse.AddProduct(6666, 20);
            Console.WriteLine("\nadding another product after removing one: \n" + warehouse);

            //Test warehouse products behavior


            //solution for question 3:

            //Solution3.TestSolution();





        }
        //public static void Main(string v, string[] args)
        //{
        //    // Display the number of command line arguments.
        //    Console.WriteLine(args.Length);
        //}
    }
}

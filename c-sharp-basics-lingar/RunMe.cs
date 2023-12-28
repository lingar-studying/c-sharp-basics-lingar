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

            Warehouse warehouse1=new Warehouse();

            string[] keepers = { "Avraham", "Izhak", "Yaakov" };
            warehouse1.LightOn = true;

            warehouse1.addGuards(keepers);

            Console.WriteLine("\nwarehouse = " + warehouse1);

            warehouse1.AddGuards("David");

            Console.WriteLine("\nwarehouse =" + warehouse1);         

            warehouse1.Dirt = 120;

            Console.WriteLine("\ntrying to add more then 100 in dirt:\nwarehouse =" + warehouse1);

            warehouse1.Dirt = 65;

            Console.WriteLine("\nadding correct value \nwarehouse =" + warehouse1);

            structure.Clean();
            Console.WriteLine("\n Cleaning the structre \nstrtucture =" + structure);


            warehouse1.Clean();
            Console.WriteLine("\n Cleaning the warehouse \nwarehouse =" + warehouse1 +"\n");

            
            warehouse1.W = 20;
            warehouse1.demoThis(10);
            // Console.WriteLine("\ndemo this:\n" + warehouse);

            //Product p1 = new Product(1111);
            //Product p2 = new Product(2222);

            warehouse1.AddProduct(1111, 10);
            warehouse1.AddProduct(2222, 20);

            warehouse1.AddProduct(3333, 20);
            warehouse1.AddProduct(4444, 20);
            warehouse1.AddProduct(5555, 20);
            warehouse1.AddProduct(6666, 20);

            Console.WriteLine("\nadding products: \n" + warehouse1 );

            Console.WriteLine("\nproducts amount = " + Product.ProductDailyAmount);

            warehouse1.RemoveProduct(2);
            warehouse1.AddProduct(6666, 20);
            Console.WriteLine("\nadding another product after removing one: \n" + warehouse1);

            Warehouse warehouse2 = new Warehouse();



            //solution for question 3:

            //test 1 - regular case which both exist 
            warehouse2.AddProduct(2222, 40);

            NetanyaInventoryService netanyaInventoryService = new NetanyaInventoryService();
            Console.WriteLine("\n\n\n");
            netanyaInventoryService.TransferProducts(warehouse1, warehouse2, 2222, 7);//after this should be on w1 13 and on w2 47 (Barcode 2222 ) 
            Console.WriteLine("\nTest 1 - result:\n" +
                "Warehouse 1 (From) = \n" + warehouse1
                + "\nWarhouse 2 (To) = \n" + warehouse2);


            //test 2 - not exist on the warehouse1 
            netanyaInventoryService.TransferProducts(warehouse1, warehouse2, 6547, 7);
            Console.WriteLine("\ntest2 result:\n" +
                 "Warehouse 1 (From) = \n" + warehouse1
                 + "\nWarhouse 2 (To) = \n" + warehouse2);

            //test 3 - not exist on the warehouse2 
            netanyaInventoryService.TransferProducts(warehouse1, warehouse2, 5555, 17);
            Console.WriteLine("\ntest3 result:\n" +
                 "Warehouse 1 (From) = \n" + warehouse1
                 + "\nWarhouse 2 (To) = \n" + warehouse2);

            //test 4 - amount is more then the exist amounts
            netanyaInventoryService.TransferProducts(warehouse1, warehouse2, 1111, 17);
            Console.WriteLine("\ntest4 result:\n" +
                "Warehouse 1 (From) = \n" + warehouse1
                + "\nWarhouse 2 (To) = \n" + warehouse2);


            //you can do more tests

            //Solution3.TestSolution();





        }
        //public static void Main(string v, string[] args)
        //{
        //    // Display the number of command line arguments.
        //    Console.WriteLine(args.Length);
        //}
    }
}

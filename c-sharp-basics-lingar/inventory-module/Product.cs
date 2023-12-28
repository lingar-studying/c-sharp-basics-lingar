using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inventory_module
{
    public class Product
    {

        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members 
        public static int ProductDailyAmount;

        //final
        //https://stackoverflow.com/questions/1327544/what-is-the-equivalent-of-javas-final-in-c

        //readonly, const, sealed 
        public readonly int BarCode;
        // sealed and const won't let you set it in the constructor 


        private int quantity;
        public int Quantity { get => quantity; set => quantity = value; }
        public Product(int BarCode)
        {
            ProductDailyAmount++;
            this.BarCode = BarCode;
        }

        public override string ToString()
        {
            return string.Format("BarCode = {0} |Quantity = {1}", BarCode, quantity);
        }
    }

    //We can do few public classes from one file. Unlike Java.
    public class FoodProduct : Product
    {



        // how to call to parent constructor
        //https://stackoverflow.com/a/12052/9727918
        public FoodProduct(int BarCode) : base(BarCode)
        {
            //base(123); //not
        }
        public void DoSomeFood()
        {
            Console.WriteLine("DoSomeFood");
        }
    }

    //We can do few public classes from one file. Unlike Java.
    public class FinanceProduct : Product
    {
        public void DoSomeFinance()
        {
            Console.WriteLine("DoSomeFinance");
        }

        // how to call to parent constructor
        //https://stackoverflow.com/a/12052/9727918
        public FinanceProduct(int BarCode) : base(BarCode)
        {
            //base(123); //not
        }
    }


}

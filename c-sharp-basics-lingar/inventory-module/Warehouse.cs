using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inventory_module
{
    public class Warehouse : Structure
    {
        private bool lightOn = false;

        private string[] keepers;
        //Arrays - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
        //private Product[] = new Product[5];// what's wrong ? test youself
        private Product[] products = new Product[5];


        public bool LightOn { get { return lightOn; } set { lightOn = value; } }


        public void AddProduct(int Barcode, int quantity)
        {
            //foreach(Product p in products)
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = new Product(Barcode);
                    products[i].Quantity = quantity;
                    return;
                }
            }
            {

            }
        }

        public void AddGuards(string guard)
        {
            keepers = new string[] { guard };
        }
        //Method overloading 
        public void addGuards(string[] guards)
        {
            keepers = guards;
        }


        public override void Clean()
        {
            Dirt = 20;
        }



        public override string ToString()
        {
            string keepersString = "keepers= ";
            for (int i = 0; i < keepers.Length; i++)
            {
                keepersString += keepers[i] + ",";
            }
            return base.ToString() + "| lightOn = " + lightOn + "|" + keepersString
                + "\nproducts = " + string.Join("| ", (object[]) products); //another way to print the array https://www.bytehide.com/blog/convert-array-to-string-csharp
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inventory_module
{
    public class NetanyaInventoryService : InventoryServiceInterface

    {
        public void TransferProducts(Warehouse from, Warehouse to, int productBarcode, int amount)
        {
            bool found = false;
            //find the product at "from" and subsctract the amount. If not found message & return. If was less products know it.

            Product[] fromProducts = from.Products;
            for(int i = 0; i < from.Products.Length; i++)
            {
                if(from.Products[i].BarCode == productBarcode)
                {
                    int tempQuantity = fromProducts[i].Quantity;
                    fromProducts[i].Quantity = Math.Max(fromProducts[i].Quantity - amount, 0);
                    if(tempQuantity < amount) { amount = tempQuantity; }
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Product {0} not found in warehouse from", productBarcode);
                return;
            }

            Product[] toProducts = to.Products;
            found = false;
            for (int i = 0; i < to.Products.Length; i++)
            {
                 
                if (to.Products[i] == null) continue;

                if ( to.Products[i].BarCode == productBarcode) 
                {
                    toProducts[i].Quantity += amount;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                bool full = true;
                foreach (Product product in toProducts)
                {
                    if(product == null)
                    {
                        full = false;
                    }
                }

                if (full)//wrong condition since you initialize it. You should check if we have no null. 
                {
                    Console.WriteLine("to warehouse is full");
                    return;
                }

                //if(toProducts.Length >= 5)//wrong condition since you initialize it. You should check if we have no null. 
                //{
                //    Console.WriteLine("to warehouse is full");
                //    return;
                //}
                to.AddProduct(productBarcode, amount);
            }
            else
            {

                to.Products = toProducts;

            }
            from.Products = fromProducts;


        }
    }
}

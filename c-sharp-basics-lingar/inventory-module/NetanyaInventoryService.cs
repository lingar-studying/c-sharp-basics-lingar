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
                    fromProducts[i].Quantity = Math.Max(fromProducts[i].Quantity - amount, 0);
                    if(fromProducts[i].Quantity < amount) { amount = fromProducts[i].Quantity; }
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
                if (to.Products[i].BarCode == productBarcode)
                {
                    toProducts[i].Quantity += amount;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                if(toProducts.Length >= 5)
                {
                    Console.WriteLine("to warehouse is full");
                    return;
                }
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

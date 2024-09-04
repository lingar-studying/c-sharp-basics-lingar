using System;
using System.Collections.Generic;
using System.Text;
using c_sharp_basics_lingar.inventory_module;

namespace c_sharp_basics_lingar.general
{
    public class RuntimeExceptions
    {
        public static void GenerateError()
        {
            Product[] products = {
                new Product(123),
                new Product(124),
                null,
                new Product(125)
            };
            for (int i = 0; i < products.Length; i++)
            {
                Product product = products[i];
                Console.WriteLine("barcode is " + product.BarCode);
            }
        }

    }
}

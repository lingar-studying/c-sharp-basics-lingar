using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inventory_module
{
    public interface InventoryServiceInterface
    {
        public  void TransferProducts(Warehouse from, Warehouse to, int productBarcode, int amount); 
    }
}

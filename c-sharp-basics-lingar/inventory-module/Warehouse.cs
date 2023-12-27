using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inventory_module
{
    public class Warehouse: Structure
    {
        private bool lightOn = false;

        private string[] keepers;

        public bool LightOn { get { return lightOn; } set { lightOn = value; } }    
    }
}

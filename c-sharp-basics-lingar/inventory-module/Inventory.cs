using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inventory_module
{
    public class Inventory
    {
        private long id;
        private string companyName;

        public string CompanyName { get; set; }
        public int MyProperty { get; set; }

        //getter written as the field with capitalized Case
        public long Id()
        {
            return id;
        }

        public override string ToString() { 
        
            return "Inventory of company - " + companyName + "id number = " + id;
        }



        //TODO - demo advanced getters and setters 
        //public long Id2 { get; set; }
    }

    internal class OnlyInThisFile
    {
        int x = 0;
    }
}

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
        //String is equivalen to string, it's recommended to use string -
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-vs-systemstring
        public string companyName = "NA";
       


        public int MyProperty { get; set; }

        //getter written as the field with capitalized Case
        public long Id { get { return id; }set { this.id = value; } }


        public override string ToString() { 
        
            return "Inventory of company - " + companyName + "id number = " + id + " Id = " + Id;
        }



        //TODO - demo advanced getters and setters 
        //public long Id2 { get; set; }
    }

    internal class OnlyInThisFile
    {
        int x = 0;
    }
}

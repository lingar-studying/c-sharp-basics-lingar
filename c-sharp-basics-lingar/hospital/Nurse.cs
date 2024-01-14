using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.hospital
{
    public class Nurse: Employee
    {
        private string type;
        //public GetType --> don't use that! since it's predefined method of C#: 
        //https://learn.microsoft.com/en-us/dotnet/api/system.type.gettype?view=net-8.0

        //We can do this 
        // public string GetNurseType() { return type; }

        //Or use property 
        public String Type { get { return type; } }


        public Nurse(string name, string type): base(name)
        {
            this.type = type;
        }

    }
}

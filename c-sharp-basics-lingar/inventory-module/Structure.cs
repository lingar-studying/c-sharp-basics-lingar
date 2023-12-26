using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inventory_module
{
    public class Structure
    {
        //task 6 - create all access modifiers - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
        public String ownerCompany = "NA";

        public long id;

        public long Id { get { return id; } set { id = value; } }

        protected string customizedAble = "customizedAble default value ";

        internal string justFromThisFile = "justFromThisFile deafult value";

        protected internal string fromThisFileOrFromSubClass = "fromThisFileOrFromSubClass default value";

        protected private string fromSubClassInThisFileOnly = "fromSubClassInThisFileOnly default value";
        //internal is the default if no access modifier is specified.
        string nonModifier = "nonModifier default value";

    }
}

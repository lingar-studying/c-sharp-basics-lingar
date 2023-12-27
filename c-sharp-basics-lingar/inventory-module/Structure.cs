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

        private long id;

        public long Id { get { return id; } set { id = value; } }

        protected string customizedAble = "customizedAble default value ";
        //internal like public. Everything on the assembly, that means the project.
        //https://stackoverflow.com/a/1362269/9727918
        internal string fromAllProject = "fromAllProject deafult value";

        protected internal string fromThisProjectOrFromSubClass = "fromThisProjectOrFromSubClass default value";

        protected private string fromSubClassInThisProjectOnly = "fromSubClassInThisFileOnly default value";
        //internal is the default if no access modifier is specified.
        //it will put the most resticted that you can have. 
        string nonModifier = "nonModifier default value";

        public string NonModifier { get { return nonModifier; } set { nonModifier = value; } }
        public override string ToString()
        {
            return "id = " + id + "| customized customizedAble = " + customizedAble
                + "|fromAllProject = " + fromAllProject + "|fromThisProjectOrFromSubClass =" + fromThisProjectOrFromSubClass
                + "|fromSubClassInThisFileOnly =" + fromSubClassInThisProjectOnly + "|nonModifier =" + nonModifier;
        }

    }
}
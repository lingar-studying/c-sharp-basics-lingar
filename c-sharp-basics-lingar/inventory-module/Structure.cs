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

        public Structure() { }
        public Structure(int w, int l, int h)
        {
            this.w = w;
            this.l = l;
            this.h = h;
        }

        //privates
        private long id;

        private int w, h, l;
        private string country, city;

        //must be between 0-100(include)
        private int dirt;


        //Publics
        public string Country { get { return country; } set { country = value; } }
        public string City { get { return city; } set { city = value; } }

        public int W { get { return w; } set { w = value; } }
        public int H { get { return h; } set { h = value; } }
        public int L { get { return l; } set { l = value; } }

        public int Dirt
        {
            get => dirt;
            set
            {
                if (value >= 0 && value <= 100)
                {

                    dirt = value;

                }
            }
        }

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
            //Console.WriteLine("Length = {0}, Height = {1}, Width = {2}, Volume = {3}",
            //l, h, w);
            return "id = " + id + "| customized customizedAble = " + customizedAble
                + "|fromAllProject = " + fromAllProject + "|fromThisProjectOrFromSubClass =" + fromThisProjectOrFromSubClass
                + "|fromSubClassInThisFileOnly =" + fromSubClassInThisProjectOnly + "|nonModifier =" + nonModifier
                + String.Format("| length = {0}| height = {1}| width = {2} | Country = {3}| City = {4}| Dirt = {5}", l, h, w, country, city, dirt);


        }

    }
}
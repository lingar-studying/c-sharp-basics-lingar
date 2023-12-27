using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inventory_module
{
    public class DemoAccessors
    {

        //Demo accessors 
        public static void Demo()
        {

            Structure structure = new Structure();
            //should work
            structure.ownerCompany = "IBM";
            Console.WriteLine( "\nStructure owner - " + structure.ownerCompany);

            //structure.id = 5;//compliation error - private not accessible here 
            structure.Id = 5;
            Console.WriteLine("\nUpdated structure - " + structure);

            StructureChild structureChild = new StructureChild();

            structureChild.Id = 6;
            structureChild.ChangeParentProperties();
            //structureChild.customizedAble = "Protected customizedAble has changed";//in accessible

            Console.WriteLine("\nUpdated structureChild - " + structureChild);
            structureChild.fromAllProject = " accessible since it's internal and accessible from the whole project";

            Console.WriteLine("\nUpdated structureChild - " + structureChild);


            structureChild.fromThisProjectOrFromSubClass = "and also on another place on the project";
            Console.WriteLine("\nUpdated structureChild - " + structureChild);

            //structureChild.fromSubClassInThisProjectOnly = "Trying to change on not sub class and its not working - as expected";//
            //structureChild.nonModifier = "ddd";//won't compiled - it's acutally private


        }
        //inherits Structure
        public class StructureChild : Structure {

            public void ChangeParentProperties()
            {
                customizedAble = "Protected customizedAble has changed";
                //base.customizedAble = "Protected customizedAble - base is for calling to super directly";
                //id = 10;//won't be accessible 
                fromThisProjectOrFromSubClass = "I can edit it in the subclass";
                fromSubClassInThisProjectOnly = "Trying to change on outer sub class and its working";
                //nonModifier = "ddd";//won't compiled - it's acutally private
                NonModifier = "from sub class by setter";

            }
        }

    }
}

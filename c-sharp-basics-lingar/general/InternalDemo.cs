using System;
using System.Collections.Generic;
using System.Text;
//TODO - demo assemblies and internal access 
namespace c_sharp_basics_lingar.general
{
    public class InternalDemo
    {

        public static void Demo()
        {
            BaseClass.x = 9;
        }
    }

    public class BaseClass
    {
        // Only accessible within the same assembly.
        internal static int x = 0;
    }
}
//enum
using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.statics_demo
{
    public class Level1
    {
        //member = איברים
        //תכונות = משתנים = proprerties = שדות
        public static String name = "Avraham";
        //פעולות = מתודות = פונקציות
        public static void RunProcess()
        {
            Console.WriteLine("Level1 - RunProcess, name =  " + name );
            Level2.RunProcess();

        } 
    }


}

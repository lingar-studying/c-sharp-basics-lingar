using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.object_basics
{
    public class BoxingNoOOP
    {
        public static string boxer1Name = "Tony";
        public static string boxer2Name = "Mohamed Ali";

        public static int boxer1Weight = 50;
        public static int boxer2Weight = 55;

        //...
        public static int boxer1Puches = 0;
        public static string stadiumName = "London Square";
        //...

        public static void StartBattle()
        {

        }

        public static void Round()
        {
            //...
        }
        public static void Punch(int boxerNumber)
        {
            if(boxerNumber == 1)
            {
                boxer1Puches++;
            }//else...

        }
    }
}

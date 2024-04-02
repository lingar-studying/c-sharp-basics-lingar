using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar
{
    public class Drafti
    {
        public static void Demo()//
        {
            Console.WriteLine("Demo");

            Home home = new Castle();
            Villa v = (Villa)home;


            //Villa v2 = new Home();

            Castle c = (Castle)new Home();



            //Home home2 = new Castle();
            //Castle c = home2;

            Home home3 = new Castle();
            Castle c2 = (Castle)home3;


            Home home4 = new Villa();
            home4.SpecificVillaFunc();

            Home home5 = new Villa();

            //((Villa)home4).SpecificVillaFunc();

        }
    }

    public class Home
    {
        //גודל במ"ר
        private int size = 0;
        //מס' חדרים
        private int rooms = 0;
        //שנת ייסוד
        private int since = 0;

        private int currentYear = 0;

        public virtual void HomeDetails()
        {
            Console.WriteLine("This is a basic home");
        }

        public string SpecificHomeFunc()
        {
            return "only for base home";
        }


    }

    public class Villa : Home
    {
        //האם יש בריכה
        private bool hasPool = false;
        //גודל החצר
        private int yardSize = 0;
        //מספר הקומות
        private int floorAmt = 1;

        public override void HomeDetails()
        {
            Console.WriteLine("This is a villa");
        }

        public string SpecificVillaFunc()
        {
            return "only for villa";
        }
    }

    public class Castle : Home
    {
        //סוג האבן 
        private string stoneType = "";

        public override void HomeDetails()
        {
            Console.WriteLine("This is an ancients Castle");
        }
        public string SpecificCasttleFunc()
        {
            return "only for castle";
        }

    }

    public class HomeService
    {


        //פעולה שלפעמים נופלת
        public bool SometimesCrash(Home home)
        {

            ((Villa)home).SpecificVillaFunc();

            return true;
        }


        //שגיאת קימפול
        public void WhyIDontWork(int year)
        {
            Console.WriteLine("hey");
            if(year >= 1990)
            {
                return "pretty new home";


            }
            else
            {
                return "old home";

            }

        }

    }

    
}

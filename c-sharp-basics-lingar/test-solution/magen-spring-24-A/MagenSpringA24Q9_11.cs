using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.magen_spring_24_A
{
    public class MagenSpringA24Q9_11
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
            //home4.SpecificVillaFunc();
            //solution
            ((Villa)home4).SpecificVillaFunc();

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

        //9.3 - Getters and Setters for Home
        public int GetSize()
        {
            return size;
        }

        public void SetSize(int size)
        {
            this.size = size;
        }

        public int GetRooms()
        {
            return rooms;
        }

        public void SetRooms(int rooms) { 
            this.rooms = rooms;

        }

        public int GetSince()
        {
            return since;
        }

        public void SetSince(int since)
        {
            this.since = since;
        }

        public int GetCurrentYear()
        {
            return currentYear;
        }

        public void SetCurrentYear(int currentYear)
        {
            this.currentYear = currentYear;
        }

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

        //שאלה 9.1
        //שגיאת קימפול
        //void can't return string
        //public void WhyIDontWork(int year)
        //הפיתרון:
         public string WhyIDontWork(int year)

        {
            Console.WriteLine("hey");
            if (year >= 1990)
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

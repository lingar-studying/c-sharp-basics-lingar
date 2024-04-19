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


            //שאלה 9.4
            //שגיאת זמן ריצה - 
            //Because home is not Villa type
            Home home = new Castle();
           // Villa v = (Villa)home;

            //שגיאת קימפול
            //המרה למטה לא מפורשת
            //Villa v2 = new Home();

            //שגיאת זמן ריצה
            //the value is not Castle
            //Castle c = (Castle)new Home();


            //שגיאת קימפול
            //המרה למטה לא מפורשת
            //Home home2 = new Castle();
            //Castle c = home2;

            //רץ תקין
            //המרה מפורשת למטה מאובייקט שהוא באמת אותו ערך
            Home home3 = new Castle();
            Castle c2 = (Castle)home3;

            //רץ תקין המרה למעלה לא צריכה להיות מפורשת
            //Villa is Home

            Home home5 = new Villa();


            //שגיאת זמן ריצה בשורה הבאה. נדרשת המרה מפורשת כדי לגשת לפעולה
            Home home4 = new Villa();
            //home4.SpecificVillaFunc();
            //solution
            ((Villa)home4).SpecificVillaFunc();


            //((Villa)home4).SpecificVillaFunc();

        }
    }

    public class Home
    {

        //שאלה 9.5
        //פעולה בונה ריקה שמאפשרת יצירה ללא העברת נתונים
        public Home() { }

        public Home(int size, int rooms, int since)
        {
            this.size = size;
            this.rooms = rooms;
            this.since = since;
            currentYear = 2024;
        }

        //גודל במ"ר
        private int size = 0;
        //מס' חדרים
        private int rooms = 0;
        //שנת ייסוד
        private int since = 0;

        private int currentYear = 0;

        //11.1
        private Address address = null;

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

        public Address GetAddress() { return address; }

        public void SetAddress(Address address) { this.address = address; }

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

        //שאלה 9.6
        public Villa() { }
        public Villa(int size, int rooms, int since, bool hasPool, int yardSize, int floorAmt)
            :base(size, rooms, since){
            this.hasPool = hasPool;
            this.yardSize = yardSize;
            this.floorAmt = floorAmt;
        }


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

        //9.6
        public Castle() { }
        public Castle(int size, int rooms, int since, string stoneType):base(size, rooms, since)
        {
            this.stoneType = stoneType;
        }
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

    //11.1
    public class Address
    {
        private int homeNum = 0;
        private string streetName = "";
        private string cityName = "";

        public int GetHomeNum() { return homeNum; }
        public string GetStreetName() { return streetName; }
        public string GetCityName() { return cityName; }

        public void SetHomeNum(int homeNum) { this.homeNum = homeNum; }
        public void SetStreetName(string streetName) { this.streetName = streetName; }

        public void SetCityName(string cityName) { this.cityName = cityName; }
    }

}

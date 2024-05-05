using College;
using System;
using System.Collections.Generic;
using System.Text;
//using static c_sharp_basics_lingar.test_solution.magen_spring_24_A.MagenSpirngA24Q4.TvChannel;

namespace c_sharp_basics_lingar.test_solution.magen_spring_24_A
{
    public class MagenSpirngA24Q3
    {

        //סעיף ג'
        //כתבו פעולה חיצונית המקבלת מערך של ערוצי טלוויזיה מטיפוס TvChannel, הפעולה תדפיס את שם תוכנית הטלוויזיה בעלת הרייטינג הגבוה  מבין כל ערוצי הטלוויזיה 
        public static void GetBestShow(TvChannel[] channels)
        {

            double max = 0;
            string programName = "";
            for (int i = 0; i < channels.Length; i++)
            {

                //TvChannel tvChannel = channels[i];

                TvProgram[] programs = channels[i].GetPrograms();
                for (int j = 0; j < programs.Length; i++)
                {



                    if (programs[i].GetRating() > max)
                    {
                        max = programs[i].GetRating();
                        programName = programs[i].GetProgramName();
                    }


                }
            }
            Console.WriteLine("The best show is - " + programName);
            
            //return programName;
        }
    }

    //סעיף ב
    //אפשר גם לרשום בדרכים אחרות
    public class TvChannel
    {
        private TvProgram[] programs = null;
        public TvProgram[] GetPrograms()
        {
            return programs;
        }

        public void SetPrograms(TvProgram[] programs)
        {
            this.programs = programs;

        }

        private int current;
        public TvChannel()
        {
            programs = new TvProgram[100];
        }

        public TvChannel(TvProgram[] programs)
        {
            this.programs = programs;
        }
        /*
         * 
         * 
         ii.	
        פעולה המחזירה את מספר התוכניות המגבילות את גיל הצפייה ל-12 ומטה 
        ומדפיסה עבור כל תכנית כזו (שמגבילה את גיל הצפייה ל12 ומטה)
        את מספר השידורים שלה בעונה.
         * */
        public int GetRestricted()
        {
            int count = 0;

            for (int i = 0; i < programs.Length; i++)
            {
                TvProgram tvProgram = programs[i];
                if (tvProgram != null && tvProgram is ShowProgram)
                {

                    //if (((ShowProgram)tvProgram).GetMinAge() <= 12)
                        if (((ShowProgram)tvProgram).GetMinAge() <= 12)
                        {
                        Console.WriteLine(((ShowProgram)tvProgram).GetNumBroadcasts());
                        count++;
                    }


                }
            }

            return count;
        }

        //פעולה המחזירה את הרייטינג הגבוה ביותר של ערוץ הטלוויזה.
        public double GetMaxRating()
        {
            double max = 0;
            for (int i = 0; i < programs.Length; i++)
            {

                if (programs[i].GetRating() > max)
                {
                    max = programs[i].GetRating();
                }
            }
            return max;
        }

    }


    public class TvProgram
    {
        protected string programName; // שם התוכנית
        protected double rating; // רייטינג

        public string GetProgramName()
        {
            return programName;
        }

        public double GetRating() { return rating; }




        public TvProgram()
        {
            //...
        }

        public TvProgram(string programName, double rating)

        {
            //...
        }
    }

    public class ShowProgram : TvProgram
    {
        protected int numBroadcasts;// מספר שידורים בעונה
        protected int minAge;// גיל צפייה מינימלי

        public int GetNumBroadcasts()
        {
            return numBroadcasts;
        }

        public int GetMinAge() { return minAge; }
    }

    public class RealityProgram : ShowProgram
    {
        private string type; // סוג
    }

    public class News : TvProgram
    {
        private string name;//שם המגיש
        private int time; //משך זמן שידור בדקות 
    }

    public class BigBrother : RealityProgram
    {
    }


}

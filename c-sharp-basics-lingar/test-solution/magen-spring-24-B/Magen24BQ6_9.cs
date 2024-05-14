using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.magen_spring_24_B
{
    public class Magen24BQ6_9
    {

        public static void Demo()
        {
            Console.WriteLine("Soccer Data app:");
        }


    }

    //קבוצה
    public class Team
    {
        private string name;
        private string city;
        private string currentLeague;

        //סהכ משחקים
        public int totalGames;

        //משחקים ששוחקו
        private int gamesPlayed;
        //נצחונות
        public int wins;

        //הפסדים
        public int loses;

        //שערי זכות
        private int goalsFor;

        //שערי חובה
        private int goalsAgainst;

        //הפרש שערים
        private int goalDifferential;      
    
    
    }
}

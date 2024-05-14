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
            Team barchelona = new Team();
            barchelona.SetName("FC Barcelona");
            barchelona.SetCity("Barcelona");

            Console.WriteLine("Team = " + barchelona);


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

        //ctrl+r ctrl+e
        public int GoalsFor { get => goalsFor; set => goalsFor = value; }

        //constructors and getters and setters come here
        //I did some things I need for demonstration

        public void SetName(string name) { this.name = name; }
        public void SetCity(string city) { this.city = city; }

        public string GetCity() { return this.city; }

        public override string ToString()
        {
            return string.Format("Team=[name={0}, city={1}]", name, city);
        }




    }

    public class Game
    {
        //קבוצה א
        private Team teamA;
        //קבוצה ב
        private Team teamB;

        
        //מספרי שערים
        private int teamAGoals;
        private int teamBGoals;

        private int currentMinute;

        private bool isActive;

    }

    public class Round
    {
        //אפשר גם בבנאי לתת את הערך
        private Game[] games = new Game[6];
    }

    
    public class Season
    {
        private int year;

        private string league;

        private int roundsAmount;

        private int nextRound;

        private Team[] teams= new Team[12];

        private bool isActive;

    }
}

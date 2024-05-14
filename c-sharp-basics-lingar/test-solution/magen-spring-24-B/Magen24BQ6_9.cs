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
            Team refe = barchelona;

            Console.WriteLine(barchelona.Equals(refe));

        }


    }

    //סעיף ו
    // לכאורה לא נכון לפתוח לזה סטר, כי זה דבר שאפשר לחשב מבפנים
    // זה סכום השערים פחות ההפסדים
    // וגם כמו שכתבתי לגבי ענינים של ניצחון או הפסד וסיום משחק וכאלה, אפשר לבנות ביצוע יותר יעיל.

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
        private int wins;

        //הפסדים
        private int loses;

        //תיקו
        private int draws;

        //נקודות
        private int points;

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

        public string GetName()
        {
            return this.name;
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

        //9-ג
        private IStadium stadium;//in the constructor we will get the right staudion... or at setter
        /*_______*/

        //constructor comes here…. 

        public int GetCrowd()
        {

            return this.stadium.Count();
        }

        //סעיף ג
        //Goal scored by team
        public void ScroeGoal(Team team)
        {
            //אני רק מטפל במה שקשור למשחק
            //את הטיפול במה שקשור לפרטי הקבוצה אני אשאיר לסוף המשחק
            //to check if this will work too, I assume that yes:
            //if (team.Equals(teamA)) { Console.WriteLine("this is team A"); }
            if (team.GetName().Equals(teamA.GetName()))
            {
                teamAGoals++;
            }
            else
            {
                teamBGoals++;
            }
        }
        //סעיף ד
        //game finished
        //ניתן גם לממש את זה בצורות אחרות.
        public void GameFinished()
        {
            //צריך:
            //לחשב מי ניצח או תיקו
            //לתת נקודות לכל קבוצה בהתאם
            //לתת שערים נוספים או שנספגו לכל קבוצה בהתאם
            //להעריך בהתאם את הפרש השערים
            //להוסיף לכל קבוצה עוד משחק ששוחק
            //להפוך את המשחק לאינו פעיל

            //actually we can create a better fit methods, but this naive solution is enough for this test

            //קבוצה א ניצחה
            if (teamAGoals > teamAGoals)
            {

                //מעלה את הנצחונות
                teamA.SetWins(teamA.GetWins() + 1);
                //מעלה את הנקודות
                teamA.SetPoints(teamA.GetPoints() + 3);

                //מעלה הפסד לB
                teamB.SetLoses(teamB.GetLoses() + 1);
            }


            //קבוצה ב -בדיוק להיפך
            else if (teamBGoals > teamAGoals)
            {

                //מעלה את הנצחונות
                teamB.SetWins(teamB.GetWins() + 1);
                //מעלה את הנקודות
                teamB.SetPoints(teamB.GetPoints() + 3);

                //מעלה הפסד ל
                //A
                teamA.SetLoses(teamA.GetLoses() + 1);
            }

            //תיקו
            else
            {
                teamA.SetDraws(teamA.GetDraws() + 1);
                teamA.SetPoints(teamA.GetPoints() + 1);
                teamB.SetDraws(teamB.GetDraws() + 1);

                teamB.SetPoints(teamB.GetPoints() + 1);

            }

            //מכאן ואילך אלו פעולות שקורות בכל מצב לכן מבצע אותם ביחד כדי לא לכתוב 
            //קוד כפול

            //לתת שערים נוספים או שנספגו לכל קבוצה בהתאם
            teamA.SetGoalsFor(teamA.GetGoalsFor() + teamAGoals);

            teamB.SetGoalsFor(teamB.GetGoalsFor() + teamBGoals);


            teamA.SetGoalsAgainst(teamA.GetGoalsAgainst() + teamBGoals);

            teamB.SetGoalsAgainst(teamB.GetGoalsAgainst() + teamAGoals);
            //להוסיף לכל קבוצה עוד משחק ששוחק

            teamA.SetGamesPlayed(teamA.GetGamesPlayed() + 1);

            teamB.SetGamesPlayed(teamB.GetGamesPlayed() + 1);

            //להפוך את המשחק לאינו פעיל
            isActive = false;



        }

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

        private Round nextRound;

        private Team[] teams = new Team[12];

        private bool isActive;//


        //סעיף ו - קבל מחסנית של קבוצות מעל מס' נקודות
        //השתמשתי באובייקט המובנה במערכת
        //זה מקביל למה שצריך לעשות באובייקט המוכן אישית
        public Stack<Team> GetTeamsByMorePoints(int points)
        {
            Stack<Team> teamsStack = new Stack<Team>();

            for(int i = 0; i < teams.Length; i++)
            {

                //assuming not null
                if (teams[i].GetPoints() >= points)
                teamsStack.Push(teams[i]);


            }

            return teamsStack;


        }
 


        //סעיף ו - קבל את הקבוצה עם המס' הגדול ביותר של השערים.
        public Team MostGoals()
        {
            Team team = teams[0];
            for(int i = 1; i < teams.Length; i++)
            {
                if(teams[i] != null && teams[i].GetPoints() > team.GetPoints())
                {
                    team = teams[i];
                }
            }

            return team;
        }

        //סעיף ה - קבל את הקבוצה שמדורגת גבוה יותר
        public static Team GetHigherTeam(Team teamA, Team teamB)
        {
            //נעבור על כל ההתניות בשאלה

            //בדיקה אם הם מאותה ליגה
            if (!teamA.GetLeague().Equals(teamB.GetLeague()))
            {
                return null;
            }

            //1.	הקבוצה שיש לה את מירב הנקודות
            if (teamA.GetPoints() > teamB.GetPoints())
            {
                return teamA;
            }
            else if (teamA.GetPoints() < teamB.GetPoints())
            {
                return teamB;
            }

            //2.	הקבוצה שיש לה את הפרש השערים הגבוה ביותר
            if (teamA.GetGoalDifferential() > teamB.GetGoalDifferential())
            {
                return teamA;

            }

            else if (teamA.GetGoalDifferential() < teamB.GetGoalDifferential())
            {
                return teamB;

            }

            //3.	הקבוצה שכבשה יותר שערים.

            //אפשר גם לפי התנאים העכשוויים להשמיט את זה
            //אבל אני משאיר למקרה שאולי יכנס עוד תנאי שובר שביון ולא נשים לב שצריך לסדר את התנאי הזה
            if (teamA.GetGoalsFor() > teamB.GetGoalsFor())
            {
                return teamA;
            }


            else if (teamA.GetGoalsFor() < teamB.GetGoalsFor())
            {
                return teamB;
            }

            //4.	במידה וזה עדיין שווה – החזר את הראשונה שהוגשה.
            return teamA;

            //5.	בכל מקרה אחר – החזר null . 
            //התנאי הזה כוסה בתחילת הפעולה כשבדקנו אם הם מאותה ליגה. אין מצבים אחרים.


        }

    }//end of class season
     //סעיף 9
     //The stadiums:
    class EnglandStadium : IStadium
    {



        public int Count()
        {

            int someValue = 0;
            //some counting implementation goes here… 
            Console.WriteLine("England Counting");

            return someValue;

        }

    }

    class SpainStadium : IStadium
    {

        public int Count()
        {
            int someValue = 0;
            //some counting implementation goes here… 
            Console.WriteLine("Spanish Counting");
            return someValue;

        }

    }

    public interface IStadium
    {
        public int Count();
    }
}

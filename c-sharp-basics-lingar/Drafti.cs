using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar
{
    public class Drafti
    {
        public static void Demo()//
        {
            Console.Write("Demo ");
            Console.WriteLine("under");
            String str = "abcdef";
            //Console.WriteLine(  str.Substring(1,6));
            int result = MagenAToMove(181900,032119);
            Console.WriteLine("Result = " + result);
            //- ממוצע מספרים חיוביים שנקלטו.
            Console.WriteLine("enter numbers");
            //int num = int.Parse(Console.ReadLine());//גם לא נצרך - אמור להיות רק קולט אחד במתודה! 
            int num = 1;
            double avg = 0;
            int count = 0, /*countAvg = 0, לא נדרש */ countcouple = 0, sum = 0;
            while (num != 0)
            {
                //count++;//לא צריך להיות כאן, לספור את המס' כולם בתוך המתודה, אחרי שמתקבל מס'. 
                while (num > 0)
                {
                    num = int.Parse(Console.ReadLine());

                    count++;//count all numbers 
                    if (num % 2 == 0)
                    {
                        countcouple++;
                        //sum the numbers for getting average at the end... 
                        sum += num;

                    }
                    //sum = sum + int.Parse(Console.ReadLine());//זו טעות, אתה כאן פותח עוד אינפוט, וצריך להיות אינפוט אחד לכל לופ. 
                    //avg = sum / int.Parse(Console.ReadLine());//זו טעות גם כנל, וגם בכלל לא בודקים ממוצע בתוך הלופ רק בסוף אחרי שיש לך את הידע מה הסכום ומה הכמות.
                    //if (avg % 2 == 0)
                    //{
                    //    countAvg++;
                    //}
                }
                //num = int.Parse(Console.ReadLine());
            }

            //אחרי שסיימת את הספירה אתה יכול לחשב את הממוצע
            //כדי להימנע מתקלת חילוק ב0 במידה ולא יהיו זוגיים אני כורך בב
            //if
            if(sum> 0)
            {
                avg = (double)sum / countcouple;//צריך להוסיף המרה לדאבל או ליצור את סאם בתור דאבל, כדי שהערך יהיה נכון

            }
            Console.WriteLine("all numbers count : " + count);
            Console.WriteLine("Even numbers (זוגיים) count: " + countcouple);
            Console.WriteLine("Average of evens:" + avg);
            //Console.WriteLine(countAvg);


        }

        public static void DoNothing()
        {
            //- ממוצע מספרים חיוביים שנקלטו.
            Console.WriteLine("enter numbers");
            int num = int.Parse(Console.ReadLine());
            double avg = 0;
            int count = 0, countAvg = 0, countcouple = 0, sum = 0;
            while (num != 0)
            {
                count++;
                while (num > 0)
                {
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        countcouple++;
                    }
                    sum = sum + int.Parse(Console.ReadLine());
                    avg = sum / int.Parse(Console.ReadLine());
                    if (avg % 2 == 0)
                    {
                        countAvg++;
                    }
                }
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
            Console.WriteLine(countcouple);
            Console.WriteLine(countAvg);
        }


        public static int MagenAToMove(int currentTime, int addTime)
        {
            //TODO 
            //1- Parse (לנתח) the currentTime to hh:mm:ss
            //2- DO the same to the addTime
            //3 - add them together and return 

            //1-parse the current time
            string timeString = currentTime + "";

            int currHh = Int32.Parse(timeString.Substring(0, 2));
            int currMm = Int32.Parse(timeString.Substring(2, 2));
            int currSs = Int32.Parse(timeString.Substring(4, 2));

            //2-parse the add time 
            timeString = addTime + "";
            int addHh = Int32.Parse(timeString.Substring(0, 2));
            int addMm = Int32.Parse(timeString.Substring(2, 2));
            int addSs = Int32.Parse(timeString.Substring(4, 2));

            int resultSs = 0;
            int resultMm = 0;
            int resultHh = 0;
            if(currSs + addSs < 60)
            {
                resultSs = currSs + addSs;
            }
            else
            {
                resultSs = (currSs + addSs) - 60;
                addMm++;
            }

            if (currMm + addMm < 60)
            {
                resultMm = currMm + addMm;
            }
            else
            {
                resultMm = (currMm + addMm) - 60;
                addHh++;
            }


            if (currHh + addHh < 24)
            {
                resultHh = currHh + addHh;
            }
            else
            {
                resultHh = (currHh + addHh) - 24;
                
            }

            //to check if we can use it
            //string newTimeStr = resultHh + "" + resultMm + "" + resultSs.ToString("00");

            string newTimeStr = "";
            if (resultHh >= 10)
            {
                newTimeStr += resultHh;
            }
            else
            {
                newTimeStr += "0" + resultHh;
            }

            if (resultMm >= 10)
            {
                newTimeStr += resultMm;
            }
            else
            {
                newTimeStr += "0" + resultMm;
            }

            if (resultSs >= 10)
            {
                newTimeStr += resultSs;
            }
            else
            {
                newTimeStr += "0" + resultSs;
            }

            int newTime = Int32.Parse(newTimeStr);
            return newTime;
            //at the end convert all into new time int (by string)
        }
    }
}

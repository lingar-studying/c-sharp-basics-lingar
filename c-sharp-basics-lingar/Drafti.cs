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
    }
}

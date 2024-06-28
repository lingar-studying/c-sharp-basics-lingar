using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.polymorphism
{
    public class OverridingOverloadingCastingDemoImprotant
    {
        public static void DemoCastingAndConstructors()
        {

            double d = 2.5;
            //int x = d;//imlicity not working
            int x = (int)d;//explicity  - המרה מפורשת

            double d2 = x;//implicity is working

            //זכור שהבנאים של כיתת ההורה נקראים מעצמם או מפורש כשיוצרים את התולדה.
            Parent1 p1 = new Parent1();//print Parent1 constructor

            Child1 c1 = new Child1();//print Parent1 cosntructor

            Child2 c2 = new Child2();//print Parent1 cosntructor >> Child2 Constructor

            //פולימורפיזם והמרות
             //upcasting (המרה למעלה) 
             //לא מפורש
             //כי ילד בטוח חלק מההורה
             //כשזה לכיוון ההורה זה למעלה
            Parent1 mixed1 = new Child1();//שילוב של טיפוס מסוג הורה וערך מסוג ילד
            //הערכים שיהיו זמינים לשימוש הם רק הערכים שיש בהורה ומתודות דרוסות

            //המרה למטה לא מפורש - תייצר שגיאת קימפול, כי חייב לפרש
            //כי הורה לא בטוח שהוא מסוג הילד. גם אח שלו -מחלקה אחרת שירשה - היא מסוג ההורה אבל היא לא מכילה אותו
            //Child1 c3 = mixed1;

            //כדי שזה יעבור קימפול צריך לעשות המרה מפורש
            //explicit casting
            Child1 c4 = (Child1)mixed1;


            //אבל צריך לשים לב שזה נכון, אחרת זה יקרוס בשעת ההרצה - שגיאת הרצה
            //כמו פה - כי האובייקט הנתון בתור ערך הוא לא מסוג
            //Child2
            //run time exception
            //Child2 c5 = (Child2)mixed1;//unsafe

            if(mixed1 is Child2)
            {
                Child2 c5 = (Child2)mixed1;
            }



            //what is the value ? 
            c4.Child1Function();
            //כמו שאמרנו הפעולות שזמינות הן רק הפעולות 
            //שנמצאות בהורה
            mixed1.RegularFunc(1);

            //או פעולות שדרסנו
            mixed1.OverrideMe(2);

            //בשביל לגשת לפעולות של הילדים צריך לבצע המרה למטה
            //
            //mixed1.Child1Function();//שגיאת קימפול
            ((Child1)mixed1).Child1Function();

            //וגם פה בדיוק כמו מקודם, אם זה לא נכון, זה יקרוס בזמן הריצה
            //((Child2)mixed1).Child2Function();//שגיאת ריצה, כי האובייקט לא מהערך הזה


            Child3 c7 = new Child3();

            //במידה והפעולה לא נדרסה בתולדה, היא תקרא למה שקורה בתוך ההורה
            c7.OverrideMe(3);//parent1 Override

            Child1 child1 = new Child1();
            child1.OverrideMe2();

        }


    }

    public class Parent1
    {

        public Parent1() { Console.WriteLine("Parent 1 empty constructor"); }
        public void RegularFunc(int a)
        {

        }

        //העמסת מתודות
        //עובד כיוון שיש שוני במשתנים, ואין בעיה ששינינו את הערך שהפונקציה מחזיקה
        public int RegularFunc(int b, double c)
        {
            return 100;
        }


        //העמסת פעולות = מתודות
        //גם בלי לשנות את הערך זה יעבוד כל עוד נשנה את הפאראמטרים שהפעולה מכילה
        public void RegularFunc(int b, double c, string s)
        {
            return ;//void return nothing
        }

        //זה ייצר שגיאת קימפול מכיוון שזו אותה חתימה של פונקציה זה שהערך שהיא מחזירה שונה,
        //זה לא משנה את החתימה שלה
        //public int RegularFunc(int b, double c, string s)
        //{
        //    return;//void return nothing
        //}

        //דריסת פעולה - 
        //זו פעולה שניתנת לדריסה בגלל המילה
        //virtual
        public virtual string OverrideMe(int n)
        {

            return "OverrideMe of Parent1";
        }

        public virtual void OverrideMe2()
        {

            Console.WriteLine("OverrideMe2 of Parent1");
        }


    }

    //הורשה של מחלקה
    public class Child1 : Parent1
    {
        //default constructor... 


        public void Child1Function()
        {

            //ניתן לגשת להורה ע"י base
            int parentValue = base.RegularFunc(1, 5);
            Console.WriteLine("inner function in Child1 . parentValue = " + parentValue);
        }

        //דריסת הפעולה
        public override string OverrideMe(int n)
        {
            return "OverrideMe of Child1";
        }

        public override void OverrideMe2()
        {

            base.OverrideMe2();
            Console.WriteLine("OverrideMe2 of Child");
        }
    }


    public class Child2 : Parent1
    {

        public Child2() { Console.WriteLine("Child2 Constructor"); }

        public void Child2Function()
        {
            Console.WriteLine("inner function in Child2");
        }

        //דריסת הפעולה
        public override string OverrideMe(int n)
        {
            return "OverrideMe of Child2";
        }
    }

    public class Child3 : Parent1
    {

        //לא ניתן לדרוס מתודה עם ערך אחר. הכל חייב להיות זהה

        //שגיאות קימפול:

        //public override int OverrideMe(int n)
        //{
        //    return base.OverrideMe(n);
        //}

        //public override string OverrideMe(int n, int y)
        //{
        //    return base.OverrideMe(n);
        //}
    }
}

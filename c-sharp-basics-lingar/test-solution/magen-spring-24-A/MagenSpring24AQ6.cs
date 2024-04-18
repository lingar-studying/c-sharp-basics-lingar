using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.magen_spring_24_A
{
    public class MagenSpring24AQ6
    {

        public static void Demo()
        {

            //סעיף ג
            //CC_MagenA ac = new AA_MagenA();//לא תקין,שגיאת קימפול, כי 
            //AA doesn't inherit CC and don't have any connection - complication error 
            // AA_MagenA ab = new BB_MagenA();// תקין המרה כלפיי מעלה

            //סעיף ד
            AA_MagenA ab = new BB_MagenA(2, "excellent");
            //ab.IsExtends();//זו התקלה מכיוון שפעולה זו לא שייכת במחלקה של האובייקט הזה
            // הפיתרון לעשות המרה למטה
            //downcasting

            ((BB_MagenA)ab).IsExtends();
            BB_MagenA b = new BB_MagenA();
            if (ab.IsLike(b))
                Console.WriteLine(ab);
            //the prints will be:
            //true
            

        }
    }

    public class AA_MagenA
    {
        private int num;
        public AA_MagenA()
        {
            this.num = 1;
        }
        public AA_MagenA(int num)
        {
            this.num = Math.Abs(num);
        }


        //סעיף א
        public virtual bool IsLike(Object obj)
        {
            if(obj is AA_MagenA)
            {
                return ((AA_MagenA)obj).num == this.num;
            }
            return false;
        }
        public int GetNum()
        {
            return this.num;
        }
        public void SetNum(int num)
        {
            this.num = num;
        }
        public virtual void Print()
        {
            Console.WriteLine(" num = " + this.num);
        }

    }
    interface CC_MagenA
    {
        void IsExtends();
    }
    public class BB_MagenA : AA_MagenA, CC_MagenA
    {
        private String st;
        public BB_MagenA()
        {
            this.st = "excellent";
        }
        public BB_MagenA(int num, String st) : base(num)
        {
            this.st = st;
        }

        //סעיף ב
        public override bool IsLike(object obj)
        {
            if(obj is BB_MagenA)
            {
                return st.Equals(((BB_MagenA)obj).st);
            }
            return false;
        }
        public string GetSt()
        {
            return this.st;
        }
        public void SetSt(string st)
        {
            this.st = st;
        }
        public override void Print()
        {
            Console.WriteLine(base.ToString() + "st = " + this.st);
        }
        public void IsExtends()
        {
            Console.WriteLine(" true");
        }
    }

}

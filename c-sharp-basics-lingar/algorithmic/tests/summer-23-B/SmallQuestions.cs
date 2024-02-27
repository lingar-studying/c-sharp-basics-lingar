using System;


namespace c_sharp_basics_lingar.algorithmic.tests.summer_23_B
{
    internal class SmallQuestions
    {

        public static void Demo()
        {
            // Q1.Solve();
            //Console.WriteLine("Q2 solution:");
            //string wordValid = "AbbAc1A";// psdspcxbp , lhsl98l
            //string wordInvalid = "pppp";// kdjtr, kkfasaa,....

            //Console.WriteLine("is {0} valid? {1}", wordValid, Q2.IsValid(wordValid));

            //Console.WriteLine("is {0} valid? {1}", wordInvalid, Q2.IsValid(wordInvalid));

            //Q2.GetNStrings(3);

            //Q3.Solve();

            //Q4.Demo();

            Q5.Solve();
        }
    }

    public class Q1
    {
        public static void Solve()
        {
            //the task 
            //get input until you get 3 digits number (includes negative numbers
            //max number
            int max = 0;
            int min = 0;
            bool init = true;
            while (true) {

                //get the input 
                Console.WriteLine("inset some number:");

                int input = int.Parse(Console.ReadLine());

                //initialize numbers
                if (init)
                {
                    max = input; min = input;
                    init = false;
                }

                //assigning max
                if (input > max) max = input;

                //assigning min
                if (input < min) min = input;

                //checking if it's have 3 digits 
                if (input / 10 >= 10 || input / 10 <= -10)
                {
                    Console.WriteLine("max number = {0} | min number = {1}", max, min);
                    return;
                }
            }
           
        }

    }

    public class Q2
    {
        //try 3 running, not more 

        public static bool IsValid(string s)
        {

            //check if it's odd 
            if(s.Length % 2 == 0 )return false;

            //check if valid                                            
            //s[0] - first char s[length-1] last char - s[length / 2] - middle char. 
            if (s[0] == s[s.Length-1] && s[0] == s[s.Length / 2])
            {
                return true;
            }

            return false;
        }
        //B - get 23 strings. I did the number as parameter for changing it
        public static void GetNStrings(int length) {
            
            //preparing array for holding the values
            string[] myString = new string[length];

            int i = 0;
            int countValids = 0;
            while (i < myString.Length)
            {
                //getting the strings
                Console.WriteLine("Insert {0}/{1} strings please...", i+1, length);
                string str = Console.ReadLine();
                if (IsValid(str))
                {
                    Console.WriteLine("valid...");
                    countValids++;
                }
                i++;
            }
            Console.WriteLine("Valids Strings - {0}, Invalid Strings - {1}", countValids, length - countValids);

        }
    }

    public class Q3
    {
        public static void Solve()
        {
            Console.WriteLine("Solve and test Q3");
            int[] arr1 = { 1, 4, -6, -4 };
           

            int[] arr2 = { 1, 4, -6, -4 , 3};
         

            int[] arr3 = { 1, 4, -6, 4 };
         
            Console.WriteLine(IsEqualArray(arr1));//true
            Print(arr1);
            Console.WriteLine();

            Console.WriteLine(IsEqualArray(arr2));//false
            Print(arr2);
            Console.WriteLine();

            Console.WriteLine(IsEqualArray(arr3));//false
            Print(arr3);
            Console.WriteLine();




        }
        public static bool IsEqualArray(int[] array)
        {
            if (array.Length % 2 != 0) return false;
            int countNegative =0, countPositive = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != 0)
                {
                    if(array[i] < 0)
                    {
                        countNegative++;
                    }
                    else { countPositive++; }
                }
                else
                {
                    return false;
                }

            }

            return countNegative == countPositive;
        }

        public static void Print(int[] array)
        {
            if (IsEqualArray(array))
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + ",");
                }

            }
            else
            {
                for (int i = array.Length-1; i>= 0  ; i--)
                {
                    Console.Write(array[i] + ",");
                }
            }
        }
    }


    //solution q Q4


    //אובייקט משלוח פרחים
    public class FlowerPackage
    {
        //show here enum 
        public string type = "";

        public int num = 0;
        public int time = 0;
        public double price = 0;

        //default package
        public FlowerPackage(string type, double price)
        {

            this.type = type;
            this.price = price;
            num = 2000;
            time = 12;

        }
        
        public override string ToString()
        {
            return string.Format("Flower[type = {0}| num={1}| time={2}| price={3}]",type, num, time, price);
        }
    }

    public class Q4
    {
        public static void Demo()
        {
            FlowerPackage f1 = new FlowerPackage("Jasmine", 10.3);
            Console.WriteLine(f1);

            FlowerPackage f2 = new FlowerPackage("Sigalit", 7.67);

            f2.num = 3;
            f2.time = 6;





            FlowerPackage f3 = new FlowerPackage("Nerkis", 6);

            f3.num = 235;
            f3.time = 20;
            Console.WriteLine("----");

            Compensation(new FlowerPackage[] { f1, f2, f3 }, 25);
            Console.WriteLine("----");
            Compensation(new FlowerPackage[] { f1, f2, f3 }, 15);
            Console.WriteLine("----");

            Compensation(new FlowerPackage[] { f1, f2, f3 }, 7);

            Console.WriteLine("----");

            Compensation(new FlowerPackage[] { f1, f2, f3 }, 3);


        }

        public static void Compensation(FlowerPackage[] arr, int flyTime)
        {
            double lose = 0;
            Console.WriteLine("Not good deliveries:");

            for (int i = 0; i < arr.Length; i++)
            {
                if(flyTime > arr[i].time)
                {
                    double currentLose = arr[i].price * arr[i].num;
                    lose += currentLose;

                    Console.WriteLine(arr[i] + "\n---lost: " + currentLose + "---");
                }
            }
            Console.WriteLine("Total Lose = " + lose);
        }


    }
    public class Q5
    {
        public static void Solve()
        {
            //A-Debug it and test your answers on the tracking table
            Console.WriteLine("Secret = " + Secret(37245));
            //B - 2000 ? V
            //C-הפעולה מונה כמה חילוקים ב10 יש מהמס' עצמו עד 0 
            // במקביל היא בודקת בכל חילוק החל מהמס' עצמו אם המס' זוגי.
            // היא מחזירה את מס' הפעמים שהתוצאה היתה אי זוגית
            //במילים אחרות זה גם מבטא את מס' הספרות האי זוגיות במס'
            //כי בכל ספרה אי זוגית שנמצאת היא תמיד תהיה בצד ימין באיזה סיבוב, דבר שיצור מס' אי זוגי
            // כלומר יהיה הפרש בין הכולל לזוגי שיתבטא באותה ספרה. וממילא התוצאה תייצג את המספרים האי זוגיים.
            Console.WriteLine("Secret = " + Secret(2000));

            Console.WriteLine("Secret = " + Secret(20435678));
            int[] arr = { 7245, 64, 14783, 32, 824, 199 };


            //debug it
            Console.WriteLine(  "sod = "+  Sod(arr));//B - 1 - 64 
                                                     //2 - באופן כללי היא מחפשת את התוצאה הכי קטנה מבין המערך. כלומר את המס' שמכיל הכי פחות אי זוגיים. 


            int[] arr2 = { 724532, 645903336, 14783, 329, 824975313, 199 };//329


            //debug it
            Console.WriteLine("sod = " + Sod(arr2));//B - 1 - 64 
        }

        public static int Sod(int[] arr)
        {
            int res = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (Secret(arr[i]) < Secret(arr[res]))
                    res = i;
            }
            return arr[res];
        }

        public static int Secret(int num)
        {
            int res1 = 0, res2 = 0;
            while (num > 0)
            {
                res1++;
                if (num % 2 == 0)

                    res2++;
                num = num / 10;
            }
            return res1 - res2;
        }
    }

}

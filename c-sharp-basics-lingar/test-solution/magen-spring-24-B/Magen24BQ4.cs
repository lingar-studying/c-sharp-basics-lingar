using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.magen_spring_24_B
{
    public class Magen24BQ4
    {
        //א - בין המחלקות יש דריסת פעולות, במחלקת 
        /*
         * סעיף א
         * 
         בין המחלקות יש דריסה בפעולה 
        move 
        שמיושמת בכל אחת מהמחלקות היורשות ע"י שימוש במילת הקוד 
        override
        וכמו שניתן לראות באותה חותמת בלבד.
        העמסת פעולות פירושה ליצור פעולות עם אותו שם וחותמת שונה – כלומר מספר פאראמטרים שונה, ואנחנו לא רואים את זה קורה כאן. 

                */

        public static void Demo()
        {
            Vehicle v1 = new Rail(10);
            Vehicle v2 = new Bus(11);
            Vehicle v3 = new Bus(12);
            Vehicle v4 = new Vehicle(23);

            //****

            //v1.Move();
            //v4.Move();


            //Console.WriteLine(v2.BusDoorsOpen());

            //Console.WriteLine(((Rail)v2).RailDoorsOpen());


            //Console.WriteLine(((Bus)v2).BusDoorsOpen());

            Console.WriteLine(v3 is Bus);

        }
    }

    public class Vehicle//=כלי רכב
    {
        private int serialNum = 0;

        protected int maxSpeed = 0;
        public Vehicle(int serialNum)
        {
            this.serialNum = serialNum;
            this.maxSpeed = 40;
        }

        public virtual void Move()
        {
            Console.WriteLine("Some vehicle is moving");
        }
    }

    public class Rail : Vehicle
    {
        public Rail(int serialNum) : base(serialNum)
        {
            this.maxSpeed = 300;
        }
        public override void Move()
        {
            Console.WriteLine("Rail is moving");
        }
        public string RailDoorsOpen()
        {
            return "Rail is openning doors";
        }
    }

    public class Bus : Vehicle
    {
        public Bus(int serialNum) : base(serialNum)
        {
            this.maxSpeed = 120;
        }
        public override void Move()
        {
            Console.WriteLine("Bus is moving");
        }
        public string BusDoorsOpen()
        {
            return "Bus is openning doors";
        }
    }
}

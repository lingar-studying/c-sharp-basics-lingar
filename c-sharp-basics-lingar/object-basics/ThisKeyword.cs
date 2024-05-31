using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.object_basics
{
    public class ThisKeyword
    {


        public static void DoDiscount(Phone phone)
        {//==הנחה
            phone.price *= 0.9; 

        }
            public static void Demo()
        {
            Phone p = new Phone("black", 20);
            Console.WriteLine("color = " + p.color + "|price = " + p.price);
            Phone p2 = new Phone();
            Console.WriteLine("color = " + p2.color + "|price = " + p2.price);
            p.DoDiscount();
            p2.DoDiscount();

            Console.WriteLine("color = " + p.color + "|price = " + p.price);
            Console.WriteLine("color = " + p2.color + "|price = " + p2.price);

        }
    }

    public class Phone
    {
        public string color = "white";
        public double price = 0;

        public Phone(string color, double price)
        {

            //color hide color 
            //color = color;//
            //this reference to the instance
            this.color = color;
            this.price = price;
        }

        public Phone(): this("orange", 205.06)
        {

        }

        public Phone(double d) : this("orange", 205.06)
        {

        }

        public void DoDiscount()
        {
            ThisKeyword.DoDiscount(this);
        }

        public void Display()
        {
            Console.WriteLine("Price = " + price);
            Console.WriteLine("color = " + this.color);


        }




    }
}

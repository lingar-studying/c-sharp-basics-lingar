using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.Summer_23_B
{
    class Solution6
    {

        public static void Demo()
        {
            WomenShoe w = new WomenShoe("Nike", 37.5, "pink", 234.6, 2020, 2);
        }
    }
    //Explanation: there are some common properties for the different shoes. 
    //We'll create common objects for those objects and we'll extend the object that own
    //specific properties

    //The Top level shoe
    //Should be considered 
    public class Shoe
    {
        /*
         * I did all the fields privates, assuming that the childs not need to create new setters
            if they are need to make direct actions on the fields the fields should be protected
         */
        //producer
        private string producer = "";
        //the size is double since it's can be 20.5 , etc
        private double size = 0D;
        //color
        private string color = "";
        //base price
        private double price = 0;
        //final price after calculation 
        private double finalPrice = 0;

        //empty constructor
        public Shoe()
        {

        }

        //Constructor with most properties. I don't pass price, since it's have some specific calculation
        //It will happen from inside 
        public Shoe(string producer, double size, string color, double price)
        {
            this.producer = producer;
            this.size = size;
            this.color = color;
            //It will call the overrided method if there is. 
            this.price = price;
        }

        public virtual double CalcPrice()
        {

            return 0D;
        }

        //getters and setters come here... 
    }

    //returning the value of the right price as double
    
    //for general Adult shoe, contains the common properties
    //Consider do it abstract class 
    public class AdultShoe: Shoe
    {
        //currently only the year is common.
        //Year of manufacture 
        private int year = 0;
        

        //empty constructor 
        public AdultShoe()
        {

        }
        //constructor using the base with the year 
        public AdultShoe(string producer, double size, string color, double price, int year): 
            base(producer, size, color, price)
        {
            this.year = year;
        }


        //getters and setters come here 

    }

    //Specific object for man shoe
    public class MenShoe: AdultShoe
    {
        //האם נעל עבודה 
        private bool work = false;


        public MenShoe(string producer, double size, string color, double price, int year, bool work ) :
            base(producer, size, color, price, year)
        {
            this.work = work;
        }
    }

    public class WomenShoe : AdultShoe
    {
        //the height of the heal in CM
        private double heal = 10;
        

        public override double CalcPrice()
        {
            Console.WriteLine("heal = " + heal);
            return base.CalcPrice();
        }

        //constructor 
        //empty
        public WomenShoe()
        {

        }

        //with args 
        public WomenShoe(string producer, double size, string color, double price, int year, double heal) :
            base(producer, size, color, price, year)
        {
            this.heal = heal;
        }
    }

    public class KidShoe : Shoe
    {
        private bool orth = false;

        public KidShoe(string producer, double size, string color, double price, bool orth) : base(producer, size, color, price)
        {
            this.orth = orth;
        }
    }

    public class Storage
    {

        //כל הנעליים שבחנות
        private Shoe[] shoes = new Shoe[0];

        public Storage(Shoe[] shoes)
        {
            this.shoes = shoes;
        }
    }

}

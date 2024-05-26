using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.object_basics
{
    public class ObjectTemplate
    {
        //properties - שדות/תכונות
        public int intProperty = 10;

        public string stringProperty = "some string";

        public bool boolProperty = false; 

        public void ToggleBoolProperty()
        {
            boolProperty = !boolProperty;
        }

    }

    public class Chair
    {

        public Chair() { }

        public Chair(string color, int height, bool isWood)
        {
            this.color = color;
            this.height = height;
            this.isWood = isWood;
        }

        public string color = "white";

        public int height = 46;

        public bool isWood = false;

        public void DisplayProps()
        {

            Console.WriteLine("Chair = [color ={0}, height = {1}, isWood = {2}]", color, height, isWood);
        }
    }
    public class Room
    {
        public string type = "bathroom";
        public int sqm = 10;
        public bool hasWindows = true;
        public Chair chair = new Chair();

        public void DisplayProps()
        {

            Console.WriteLine("Room = [type ={0}]", type);
            chair.DisplayProps();
        }

    }

    public class Home
    {
        public Room[] rooms = new Room[3];

        public Home()
        {
            
            rooms[0] = new Room();
        }

        public Home(string type)
        {
            rooms[0] = new Room();
            rooms[0].type = type;
        }


    }

    public class TestBasicObject
    {

        public static void Demo()
        {
            ObjectTemplate template1 = new ObjectTemplate();


            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);
            template1.boolProperty = true;
            template1.stringProperty = "another string";
            template1.intProperty = 20;
            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);
            ObjectTemplate template2 = new ObjectTemplate();
            template1.ToggleBoolProperty();
            Console.WriteLine("Template 2 = intProperty = {0} , string property = {1}, boolProperty ={2} "
               , template2.intProperty, template2.stringProperty, template2.boolProperty);

            Chair c1 = new Chair();
            c1.DisplayProps();
            c1.color = "black";
            c1.DisplayProps();

            Home home = new Home();
            home.rooms[0].DisplayProps();

            Home home2 = new Home("Warehouse");
            home2.rooms[0].DisplayProps();

            Chair c2 = new Chair("orange", 50, false);//invocation, to invoke, לזמן, לקרוא
            c2.DisplayProps();
        }

    }
}

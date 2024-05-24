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

            Console.WriteLine("Template 2 = intProperty = {0} , string property = {1}, boolProperty ={2} "
               , template2.intProperty, template2.stringProperty, template2.boolProperty);


        }

    }
}

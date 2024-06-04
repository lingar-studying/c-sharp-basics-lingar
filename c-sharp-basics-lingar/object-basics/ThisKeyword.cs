using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.object_basics
{

    //some docs:
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this
    public class ThisKeyword
    {
        public static void Demo()
        {
            Console.WriteLine("This demo: ");
            Console.WriteLine("See below how we are using this to access the current instance ");
            SomeObj1 someObj1 = new SomeObj1();
            SomeObj1 someObj2 = new SomeObj1(10,20, "I have created");

            someObj1.DisplayMe();
            someObj2.DisplayMe();

            someObj2.AddN(10);
            someObj2.DisplayMe();

            SomeObj1 someObj3 = someObj2;

            someObj3.DisplayMe();

            int local = 10;

            AddN(local, 5);
            Console.WriteLine("local after adding = " + local);

            string s = "some word";
            someObj1.ChangeString(s);
            Console.WriteLine("s after change = " + s);

            string s2 = "some word2 ";

            someObj2.ChangeStringAndSave(ref s2);
            Console.WriteLine("s2 after change = " + s2);

        }

        public static void AddNToX (SomeObj1 obj, int n){

            obj.x += n;
        }

        public static void AddN(int parameter, int n)
        {
            parameter += n;
        }

    }

    public class SomeObj1
    {
        public int x = 0;
        public int y = 0;
        public string str = "";


        //the members is hidden 
        public SomeObj1(int x, int y, string str)
        {
            this.x = x;
            this.y = y;
            this.str = str;

        }
        //this as constructor:
        //(Must came before the parentheses
        public SomeObj1(): this(5, 5, "autocreated")
        {
                     

        }

        //we can but not must use with this, when it's not hidden (in Mahat they love to use it)
        public void DisplayMe()
        {
            Console.WriteLine($"x = {this.x}, y={y}, str = {str}");
        }

        public void AddN(int n)
        {
            ThisKeyword.AddNToX(this, n);
        }
        public void ChangeString(string str)
        {
            str += "newString";
        }

        public void ChangeStringAndSave(ref string str)
        {
            str += "newString";
        }

        //we can use it in places i
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using c_sharp_basics_lingar.object_basics;
namespace c_sharp_basics_lingar.general
{
    public class ICompareableDemo
    {
        public static void Demo()
        {
            List<int> list = new List<int>();
            list.Add(41);
            list.Add(14);
            list.Add(2);
            Console.WriteLine(string.Join(",", list));
            list.Sort();
            Console.WriteLine("After sorting:" + string.Join(",", list));

            List<string> listStr = new List<string>();
            listStr.Add("wsa");
            listStr.Add("opu");
            listStr.Add("abv");

            Console.WriteLine(string.Join(",", listStr));
            listStr.Sort();
            Console.WriteLine("After sorting:" + string.Join(",", listStr));

            List<Pen> pens = new List<Pen>();

            Pen pen = new Pen();
            pen.Color = "blue";
            pen.Price = 100;
            Pen pen2 = new Pen();
            pen2.Color = "Red";
            pen2.Price = 30;

            Pen pen3 = new Pen();
            pen3.Color = "Black";
            pen3.Price = 20;
            pens.Add(pen);
            pens.Add(pen2);
            pens.Add(pen3);
            Console.WriteLine(string.Join(",\n", pens));

            pens.Sort();
            Console.WriteLine("after sort = " + string.Join(",\n", pens));



        }

    }
}

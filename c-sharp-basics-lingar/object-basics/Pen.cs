using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.object_basics
{
    public class Pen
    {

        //NOT to use in Mahat test!
        private string color;
        private int length;

        private char type = 'A';
        private double price = 20.2;

        public int Length
        {
            get { return length; }

            set
            {

                if (value <= 15)
                {
                    length = value;
                }
                else
                {

                    Console.WriteLine("Length is too big");
                }
            }
        }
        public string Name
        {
            get;
            set;
        }



        public string Color
        {
            get => color;
            set => color = value;
        }
        public char Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"Pen: [color = {color}, length = {length}, price = {price}]";
        }

        public static void DemoProps()
        {
            Console.WriteLine("Demo props");

            Pen p = new Pen();
            p.Color = "black";

            Console.WriteLine("Color = " + p.Color);
            p.Name = "Pilot";
            p.Length = 16;
            p.Length = 13;
            Console.WriteLine(p);

            Console.WriteLine(p.Name);
        }

    }
}

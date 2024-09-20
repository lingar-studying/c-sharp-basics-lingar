using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace c_sharp_basics_lingar.object_basics
{

    public class Pen : IComparable
    {

        public int CompareTo(object obj)
        {

            //null at the end
            if (obj == null)
            {
                return 1;
            }
            Pen pen = (Pen)obj;
            if (price > pen.price)
            {
                return 1;
            }
            else if (price < pen.price)
            {
                return -1;
            }
            return 0;
        }

        //NOT to use in Mahat test!
        private string color;
        private int length;
        private double thickness;

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
        public double Thickness { get => thickness; set => thickness = value; }

        public override string ToString()
        {
            return $@"Pen: [Name = {Name}, color = {color}, length = {length}, price = {price}, 
                Thickness = {thickness}  ]";
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

    /*
    * TODO:
    * - General Builder with paramter for color 
    * - parker builder 0.5, length 12
    * - Pilto builder 0.7 length 13
    * - Artline builder 1.2 length 8.6
    * */


    //General Builder with paramter for color
    public interface IPenBuilder
    {

        public void Reset();
        public void BuildName();
        public void BuildThickness();

        public void BuildBasicsProperties(string color);//price, type

        public void BuildLength();

        public Pen Build();

    }
    //    * - parker builder 0.5, length 12

    public class ParkerBuilder: IPenBuilder
    {
        private Pen pen = null;
        private string color;

        public string Color { get => color; set => color = value; }

        public ParkerBuilder(string color)
        {
            this.color = color;
        }

        public void Reset()
        {
            pen = new Pen();
        }

        public void BuildName()
        {
            pen.Name = "Parker";
        }
        public void BuildThickness()
        {
            pen.Thickness = 0.5;
        }

        //color, price, type
        public void BuildBasicsProperties(string color)
        {
            pen.Color = color;
            pen.Price = 13.5;
            pen.Type = 'C';
        }

        public void BuildLength()
        {
            pen.Length = 12;
        }

        public Pen Build()
        {
            this.Reset();

            BuildName();
            BuildThickness();
            BuildBasicsProperties(color);
            BuildLength();

            Pen result = this.pen;
            this.Reset();
            return result;
        }

    }



    //Pilto builder 0.7 length 13
    public class PilotBuilder : IPenBuilder
    {
        private Pen pen = null;
        private string color;

        public string Color { get => color; set => color = value; }

        public PilotBuilder(string color)
        {
            this.color = color;
        }

        public void Reset()
        {
            pen = new Pen();
        }

        public void BuildName()
        {
            pen.Name = "Pilot";
        }
        public void BuildThickness()
        {
            pen.Thickness = 0.7;
        }

        //color, price, type
        public void BuildBasicsProperties(string color)
        {
            pen.Color = color;
            pen.Price = 13.5;
            pen.Type = 'C';
        }

        public void BuildLength()
        {
            pen.Length = 13;
        }

        public Pen Build()
        {
            this.Reset();

            BuildName();
            BuildThickness();
            BuildBasicsProperties(color);
            BuildLength();

            Pen result = this.pen;
            this.Reset();
            return result;
        }

    }

}

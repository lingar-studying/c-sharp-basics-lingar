using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.magen_spring_24_B
{
    public class Magen24BQ5
    {

        public static void Demo()
        {
            Shape s = new Square(new Point(50, 50), 10);
            Shape c = new Circle(new Point(50, 50), 8);
            ITurnable t;
            IFillable f;
            //***

        }
    }
    public interface IFillable
    {
        public void Fill(string color);
    }
    public interface ITurnable
    {
        public void Left(int degree);
        public void Right(int degree);
    }

    //סעיף א
    public class Shape
    {
        
    }

    public class Circle : Shape, IFillable
    {
        //סעיף ב
        public Circle(Point point, int i)
        {

        }
        public void Fill(string color) { }

    }

    public class Square: Shape, IFillable, ITurnable
    {

        //סעיף ב
        //חשוב ליצור גם אחד ריק, כדי שמלבן לא יזרוק תקלה
        //לחילופין אפשר גם ליצור אחד במלבן שמתאים לבנאי הזה. 
        public Square() { }
        public Square(Point point, int i)
        {

        }
        public void Fill(string color) { }
        public void Right(int degree) { }

        public void Left(int degree) { }
    }

    public class Rectangle: Square
    {

    }

    public class Point
    {
        public Point(int x, int y) { }
    }
}

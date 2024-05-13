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

            //1 - Will work. The compiler see each class which implements
            //the interface as the interface itself.  so Ifillable and Iturnable 
            //considered as children of shape

            //f = (IFillable)c;

            //2-compile error
            //this is downcasting so it's need explicit downcasting
            //t = s;

            //3 - as 2 - compile error
            //f = c;
            //f.Fill("Red");

            //(4)
            //Compile error - since Left(int d), doesn't exist on Circle. 
            //((Circle)s).Left (45);

            //(5) - as 4 since Fill(string) does not exist on Shape 
            //Shape d = c;
            //d.Fill("Yellow");

            //6- Compile error.
            //as long we doesn't create this constructor to 
            //Rectangle, it won't work. (and we haven't requested to do it)
            //And even if we will create it
            //method Left doesn't exist on the type Fillable
            //f = new Rectangle(new Point(10, 10), 10, 20);
            //f.Left(Math.PI);

            //7 - compile error - left not exist on Shape
            c = s;
            //c.Left(90);


            //Important to know!
            //The interface will be considered as child of the Parent and
            //we would be able to do direct casting for that. 
            //IFillable f2 = (IFillable)new Shape();


            //Check the vice versa - not working
            //Test222 t = (Test222)c;
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

    public class Square : Shape, IFillable, ITurnable
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

    public class Rectangle : Square
    {

    }

    public class Point
    {
        public Point(int x, int y) { }
    }
    public class Test222 : IFillable
    {
        public void Fill(string color)
        {
            throw new NotImplementedException();
        }
    }
}

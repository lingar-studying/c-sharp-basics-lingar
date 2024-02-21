using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.Summer_23_B
{
    public class Solution3B
    {
        public static void Demo()
        {
            Shape s1 = new Shape();
            Shape s2 = new Circle();
            Shape s3 = new Cylinder();
            Circle c = new Cylinder();

            //Circle c0 = new Shape();//compile error
            //Circle c1 = s1;//compile error
            //Circle c2 = (Circle)s2;//works
            //Circle c3 = (Circle)s3;//works
            //Circle c4 = (Circle)s1;//runtime error

            //Triangle t = new Triangle();
            //Shape s5 = t;
            //Circle c5 = (Circle)s5;//runtime error

            //Shape s = (Circle)(new Cylinder());//works
            //Circle c2 = (Shape)(new Cylinder());//compilation error
            Sqaure sqaure = new Sqaure();
            sqaure.Do1();




        }
    }

    public class Shape
    {
        public virtual void Do1()
        {
            Console.WriteLine("Do1 - Shape");
        }
        //public void Do1()
        //{

        //}
    }
    public class Sqaure : Shape {
        public override void Do1()
        {
            base.Do1();
            Console.WriteLine("Do1 - Square ");
        }
    }

    public class Triangle : Shape { }

    public class Circle : Shape { }

    public class Cylinder : Circle { }


}

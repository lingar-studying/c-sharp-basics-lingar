using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.test_solution.magen_spring_24_B
{
    public class Magen24BQ5
    {
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
        public void Fill(string color) { }

    }

    public class Square: Shape, IFillable, ITurnable
    {
        public void Fill(string color) { }
        public void Right(int degree) { }

        public void Left(int degree) { }
    }

    public class Rectangle: Square
    {

    }

    public class Point
    {

    }
}

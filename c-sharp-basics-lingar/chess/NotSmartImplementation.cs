using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.chess
{
    //each piece separately
    class NotSmartImplementation
    {
        public static void Demo()
        {
            Square sqaure = new Square();
            sqaure.Column = 10;
            Console.WriteLine(sqaure.Column);

            sqaure.Column =5;
            Console.WriteLine(sqaure.Column);
        }
    }

    //write the things
    public class Square
    {
        private int column = 1;
        private int row = 1;

        public int Column
        {
            get => column; set
            {
                if (value > 0 && value < 9)
                {
                    column = value;
                }
            }
        }
        public int Row
        {
            get => row; set
            {
                if (value > 0 && value < 9)
                {
                    row = value;
                }
            }
        }
        public override string ToString()
        {
            return "column=" + column + "row = " + row;
        }
    }
    public class Board
    {

    }


    class Queen
    {
        
        private string color;
        private Square sqaure;
        // constractor
        public Queen(string color)
        {
            this.color = color;
            this.sqaure = sqaure;
        }
        public void Move(Square sqaure)
        {
            Console.WriteLine("The queen moved to square " + sqaure);
        }
    }

    class Rook
    {

        private string color;
        private Square square;
        // constractor
        public Rook(string color, Square square)
        {
            this.color = color;
            this.square = square;
        }
        public void Move(Square sqaure)
        {
            Console.WriteLine("The Rook moved to square " + sqaure);
        }
    }
    class Bishop
    {

        private string color;
        private Square square;
        // constractor
        public Bishop(string color, Square square)
        {
            this.color = color;
            this.square = square;
        }
        public void Move(Square sqaure)
        {
            Console.WriteLine("The Bishop moved to square " + sqaure);
        }
    }

















}

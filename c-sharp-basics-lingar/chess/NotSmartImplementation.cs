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

            sqaure.Column = 5;
            Console.WriteLine(sqaure.Column);

            GameProcess game = new GameProcess();
            Console.WriteLine("Running: ");
            foreach (Object piece in game.Board.Pieces)
            {
                game.MoveSomePiece(piece, new Square(1, 2));
            }
        }

        //write the things
        public class Square
        {
            private int column = 1;
            private int row = 1;
            public Square() { }
            public Square(int column, int row)
            {
                Column = column;
                Row = row;
            }

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
            private Object[] pieces;


            public Object[] Pieces { get => pieces; set => pieces = value; }

            public Board()
            {




            }

        }


        class Queen
        {

            private string color;
            private Square square;
            // constractor
            public Queen(string color, Square square)
            {
                this.color = color;
                this.square = square;
            }
            public void Move(Square square)
            {
                Console.WriteLine("The queen moved to square " + square);
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

        public class GameProcess
        {
            private Board board;
            private Object[] pieces;

            public Board Board { get => board; set => board = value; }

            public GameProcess()
            {
                Queen queen = new Queen("black", new Square(4, 8));
                Rook rook = new Rook("black", new Square(1, 8));
                Bishop bishop = new Bishop("black", new Square(3, 8));

                pieces = new Object[] { queen, rook, bishop };

                board = new Board();
                board.Pieces = pieces;
            }

            public void MoveSomePiece(Object piece, Square destination)
            {
                if (piece is Queen)
                {
                    ((Queen)piece).Move(destination);
                }

                else if (piece is Rook)
                {
                    ((Rook)piece).Move(destination);
                }

                if (piece is Bishop)
                {
                    ((Bishop)piece).Move(destination);
                }
            }
        }

    }
}

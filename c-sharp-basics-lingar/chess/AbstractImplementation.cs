using System;
using System.Collections.Generic;
using System.Text;
using static c_sharp_basics_lingar.chess.AbstractImplementation;

namespace c_sharp_basics_lingar.chess
{
    public class AbstractImplementation
    {

        //Chess by inheritance


        public static void Demo()
        {
            Square sqaure = new Square();
            sqaure.Column = 10;
            Console.WriteLine(sqaure.Column);

            sqaure.Column = 5;
            Console.WriteLine(sqaure.Column);


            GameProcessAbstract game = new GameProcessAbstract();
            Console.WriteLine("Running Abstract: ");
            foreach (Piece piece in game.Board.Pieces)
            {
                game.MoveSomePiece(piece, new Square(1, 2));
            }
        }


        public abstract class Piece
        {
            private string color;
            private Square square;

            public Piece(string color, Square square)
            {
                this.color = color;
                this.square = square;
            }

            public abstract void Move(Square square);
        }



        class Queen : Piece
        {
            // constractor
            public Queen(string color, Square square): base(color, square)
            {
               
            }
            public override void Move(Square square)
            {
                Console.WriteLine("The queen moved to square " + square);
            }
        }

        class Rook: Piece
        {

            // constractor
            public Rook(string color, Square square): base(color, square)
            {
                
            }
            public override void Move(Square sqaure)
            {
                Console.WriteLine("The Rook moved to square " + sqaure);
            }
        }
        class Bishop: Piece
        {

            // constractor
            public Bishop(string color, Square square): base(color, square)
            {
                
            }
            public override void Move(Square sqaure)
            {
                Console.WriteLine("The Bishop moved to square " + sqaure);
            }
        }

        public class GameProcessAbstract
        {
            private BoardAbstract board;
            private Piece[] pieces;

            public BoardAbstract Board { get => board; set => board = value; }

            public GameProcessAbstract()
            {
                Queen queen = new Queen("black", new Square(4, 8));
                Rook rook = new Rook("black", new Square(1, 8));
                Bishop bishop = new Bishop("black", new Square(3, 8));

                pieces = new Piece[] { queen, rook, bishop };

                board = new BoardAbstract();
                board.Pieces = pieces;
            }

            public void MoveSomePiece(Piece piece, Square destination)
            {

                piece.Move(destination);
                //if (piece is Queen)
                //{
                //    ((Queen)piece).Move(destination);
                //}

                //else if (piece is Rook)
                //{
                //    ((Rook)piece).Move(destination);
                //}

                //if (piece is Bishop)
                //{
                //    ((Bishop)piece).Move(destination);
                //}
            }
        }

    }

    public class BoardAbstract
    {
        private Piece[] pieces;


        public Piece[] Pieces { get => pieces; set => pieces = value; }

        public BoardAbstract()
        {




        }

    }
}

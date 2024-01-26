using System;
using System.Collections.Generic;
using System.Text;
using static c_sharp_basics_lingar.chess.InheritanceImplementation;

namespace c_sharp_basics_lingar.chess
{
    public class InheritanceImplementation
    {

        //Chess by inheritance


        public static void Demo()
        {
            Square sqaure = new Square();
            sqaure.Column = 10;
            Console.WriteLine(sqaure.Column);

            sqaure.Column = 5;
            Console.WriteLine(sqaure.Column);


            GameProcessInheritance game = new GameProcessInheritance();
            Console.WriteLine("Running inheritance: ");
            foreach (Piece piece in game.BoardInheritance.Pieces)
            {
                game.MoveSomePiece(piece, new Square(1, 2));
            }
        }


        public class Piece
        {
            private string color;
            private Square square;

            public Piece(string color, Square square)
            {
                this.color = color;
                this.square = square;
            }

            public virtual void Move(Square square)
            {

                Console.WriteLine("Generic piece");
            }
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

        public class GameProcessInheritance
        {
            private BoardInheritance board;
            private Piece[] pieces;

            public BoardInheritance BoardInheritance { get => board; set => board = value; }

            public GameProcessInheritance()
            {
                Queen queen = new Queen("black", new Square(4, 8));
                Rook rook = new Rook("black", new Square(1, 8));
                Bishop bishop = new Bishop("black", new Square(3, 8));

                pieces = new Piece[] { queen, rook, bishop };

                board = new BoardInheritance();
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

    public class BoardInheritance
    {
        private Piece[] pieces;


        public Piece[] Pieces { get => pieces; set => pieces = value; }

        public BoardInheritance()
        {




        }

    }
}

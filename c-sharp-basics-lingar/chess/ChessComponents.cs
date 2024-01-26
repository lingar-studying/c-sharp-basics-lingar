using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_lingar.chess
{
    class ChessComponents
    {
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
}

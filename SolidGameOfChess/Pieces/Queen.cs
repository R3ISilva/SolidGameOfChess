﻿using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public class Queen : IPiece
    {
        public Queen(PieceColor color)
        {
            Color = color;
        }

        public PieceColor Color { get; set; }
        public HumanPlayer Owner { get; set; }

        public string GetPrintString()
        {
            string printString;

            if (Color == PieceColor.White)
            {
                printString = Sprites.WhiteQueen;
            }
            else
            {
                printString = Sprites.BlackQueen;
            }

            return printString;
        }
    }
}

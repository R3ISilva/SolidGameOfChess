using System.Drawing;
using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public class King : IPiece
    {
        public King(PieceColor color)
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
                printString = "\u2654";
            }
            else
            {
                printString = "\u265A";
            }

            return printString;
        }
    }
}

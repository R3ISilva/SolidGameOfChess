using System.Drawing;
using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public class Pawn : IPiece
    {
        public Pawn(PieceColor color)
        {
            Color = color;
        }

        public List<List<int>> Position { get; set; }
        public PieceColor Color { get; set; }
        public HumanPlayer Owner { get; set; }

        public string GetPrintString()
        {
            string printString;

            if (Color == PieceColor.White)
            {
                printString = "\u2659";
            }
            else
            {
                printString = "\u265F";
            }

            return printString;
        }
    }
}

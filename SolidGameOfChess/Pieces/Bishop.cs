using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public class Bishop : IPiece
    {
        public Bishop(PieceColor color)
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
                printString = "\u2657";
            }
            else
            {
                printString = "\u265D";
            }

            return printString;
        }
    }
}

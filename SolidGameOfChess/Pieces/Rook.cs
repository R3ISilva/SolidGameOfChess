using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public class Rook : IPiece
    {
        public Rook(PieceColor color)
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
                printString = "\u2656";
            }
            else
            {
                printString = "\u265C";
            }

            return printString;
        }
    }
}

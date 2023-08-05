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
                printString = Sprites.WhiteBishop;
            }
            else
            {
                printString = Sprites.BlackBishop;
            }

            return printString;
        }
    }
}

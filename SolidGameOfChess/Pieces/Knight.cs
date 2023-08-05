using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public class Knight : IPiece
    {
        public Knight(PieceColor color)
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
                printString = Sprites.WhiteKnight;
            }
            else
            {
                printString = Sprites.BlackKnight;
            }

            return printString;
        }
    }
}

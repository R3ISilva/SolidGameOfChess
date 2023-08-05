using SolidGameOfChess.Pieces;
using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess
{
    public class BoardSquare
    {
        public SquareColor Color;
        public IPiece Piece;

        public string GetPrint()
        {
            string squareRender;

            if (Piece != null)
            {
                squareRender = Piece.GetPrintString();
            }
            else
            {
                squareRender = GetPrintString();
            }

            return squareRender;
        }

        private string GetPrintString()
        {
            string printString;

            if (Color == SquareColor.White)
            {
                printString = Sprites.WhiteSquare;
            }
            else
            {
                printString = Sprites.BlackSquare;
            }

            return printString;
        }
    }
}

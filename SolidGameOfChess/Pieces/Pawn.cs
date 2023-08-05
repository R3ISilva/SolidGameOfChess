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
                printString = Sprites.WhitePawn;
            }
            else
            {
                printString = Sprites.BlackPawn;
            }

            return printString;
        }
    }
}

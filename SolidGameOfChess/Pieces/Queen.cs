using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public class Queen : IPiece
    {
        public List<List<int>> Position { get; set; }
        public PieceColor PieceColor { get; set; }
        public HumanPlayer Owner { get; set; }
    }
}

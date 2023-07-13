using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public class Bishop : IPiece
    {
        public List<List<int>> Position { get; set; }
        public PieceColor PieceColor { get; set; }
        public Player Owner { get; set; }
    }
}

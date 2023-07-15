using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public interface IPiece
    {
        List<List<int>> Position { get; set; }
        PieceColor PieceColor { get; set; }
        HumanPlayer Owner { get; set; }
    }
}

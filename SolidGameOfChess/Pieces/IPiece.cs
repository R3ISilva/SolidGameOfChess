using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public interface IPiece
    {
        List<List<int>> Position { get; set; }
        PieceColor PieceColor { get; set; }
        Player Owner { get; set; }
    }
}

using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess.Pieces
{
    public interface IPiece
    {
        PieceColor Color { get; set; }
        HumanPlayer Owner { get; set; }
        string GetPrintString();
    }
}

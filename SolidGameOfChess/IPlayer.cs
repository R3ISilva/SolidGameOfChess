using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess
{
    public interface IPlayer
    {
        string Name { get; set; }

        bool GetPlayer();

        Move GetMove();

        PieceColor playerColor { get; set; }
    }
}
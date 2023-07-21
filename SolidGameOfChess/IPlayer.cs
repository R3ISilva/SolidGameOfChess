namespace SolidGameOfChess
{
    public interface IPlayer
    {
        string Name { get; set; }

        bool GetPlayer();

        bool isWhite { get; set; }
    }
}
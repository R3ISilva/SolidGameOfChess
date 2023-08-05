using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess
{
    public class AIPlayer : IPlayer
    {
        //TODO DO THIS IN SOLIDGAMEOFCHESSAI
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PieceColor playerColor { get; set; }

        public Move GetMove()
        {
            throw new NotImplementedException();
        }

        public bool GetPlayer()
        {
            throw new NotImplementedException();
        }
    }
}
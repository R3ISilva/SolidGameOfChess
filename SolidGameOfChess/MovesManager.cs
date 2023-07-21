namespace SolidGameOfChess
{
    public class MovesManager //INHERIT THIS FROM LIST OF MOVES?
    {
        private Board board;

        public MovesManager(Board board, IPlayer player)
        {
            this.board = board;
        }

        internal Move GetMove()
        {
            throw new NotImplementedException();
        }

        public List<Move> GetAvailableMoves()
        {
            throw new NotImplementedException();
        }
    }
}
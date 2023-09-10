namespace SolidGameOfChess
{
    public class MovesManager //INHERIT THIS FROM LIST OF MOVES?
    {
        private Board board;
        private IPlayer player;

        public MovesManager(Board board, IPlayer player)
        {
            this.board = board;
            this.player = player;
        }

        public Move GetMove(List<Move> AvailableMoves)
        {
            Move move = new Move();

            while (!ValidateMove(move))
            {
                WriteToConsole.InvalidMove();
                move = player.GetMove();
            }

            return move;
        }

        private bool ValidateMove(Move move)
        {
            if (move == null)
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public List<Move> GetAvailableMoves()
        {
            throw new NotImplementedException();
        }
    }
}
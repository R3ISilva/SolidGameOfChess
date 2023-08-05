using SolidGameOfChess.Pieces;

namespace SolidGameOfChess
{
    public class Board : IBoardTemplate
    {
        public int ID; //TODO: IMPLEMENT BOARD IDENTIFICATION

        public IPlayer lastInteractedPlayer;

        public List<List<BoardSquare>> Squares { get; set; }

        public void SetUpBoard(IBoardTemplate boardTemplate)
        {
            Squares = boardTemplate.Squares;
        }

        public void MovePiece(Move move, IPlayer player)
        {
            lastInteractedPlayer = player;

            IPiece movingPiece = Squares[move.FromY][move.FromX].Piece;
            Squares[move.FromY][move.FromX].Piece = null;

            Squares[move.ToY][move.ToX].Piece = movingPiece;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>Returns the Winner</returns>
        /// <exception cref="NotImplementedException"></exception>
        public IPlayer GetWinner()
        {

            throw new NotImplementedException();
        }

        public bool IsThereAWinner()
        {
            //Todo: Implement this, check for valid moves on king
            throw new NotImplementedException();
        }
    }
}

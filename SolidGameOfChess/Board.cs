namespace SolidGameOfChess
{
    public class Board : IBoardTemplate
    {
        public int ID; //TODO: IMPLEMENT BOARD IDENTIFICATION

        public List<List<BoardSquare>> Squares { get; set; }

        public void SetUpBoard(IBoardTemplate boardTemplate)
        {
            Squares = boardTemplate.Squares;
        }

        public bool MovePiece(Move move)
        {
            bool isThereAWiner = false;

            return isThereAWiner;
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
    }
}

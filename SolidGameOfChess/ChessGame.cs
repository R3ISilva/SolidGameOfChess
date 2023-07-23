using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess
{
    public class ChessGame
    {
        static int totalPlayerCount = 2;
        public bool SystemMessages = false;
        Board Board;
        bool IsThereAWinner = false;
        List<Board> BoardStates = new List<Board>();
        public ChessGame(bool systemMessages)
        {
            this.SystemMessages = systemMessages;
            Board = new Board();
        }

        /// <returns>Returns the winner of the game</returns>
        public IPlayer StartGame(int humanPlayerCount)
        {
            if (SystemMessages)
            {
                WriteToConsole.Welcome();
                GameInput.PressEnterToContinue();
            }

            List<IPlayer> players = GetPlayers(humanPlayerCount);

            //TODO: Add a choose color for players
            players.FirstOrDefault().playerColor = PieceColor.White; //hammered by now

            BoardTemplate boardTemplate = BoardTemplates.GetStandardBoard(players.Count);

            Board.SetUpBoard(boardTemplate);

            while (!IsThereAWinner)
            {
                foreach (IPlayer player in players)
                {
                    if (StartTurn(player))
                    {
                        IsThereAWinner = true;
                    }
                }
            }

            return Board.GetWinner();
        }

        public Board GetBoardAtTurn(int turn)
        {
            return BoardStates[turn];
        }

        private List<IPlayer> GetPlayers(int humanPlayerCount)
        {
            List<IPlayer> players = new List<IPlayer>();

            for (int i = 0; i < totalPlayerCount; i++)
            {
                if (humanPlayerCount > players.Count)
                {
                    HumanPlayer player = new HumanPlayer();
                    player.GetPlayer();

                    players.Add(player);

                }
                else
                {
                    players.Add(new AIPlayer());
                }
            }

            return players;
        }

        private bool StartTurn(IPlayer player)
        {
            Board currentBoardState = Board;
            BoardStates.Add(currentBoardState);

            MovesManager movesManager = new MovesManager(Board, player);

            if (SystemMessages)
            {
                WriteToConsole.PrintBoard(Board);

                List<Move> availableMoves = movesManager.GetAvailableMoves();
                WriteToConsole.AvailableMoves(availableMoves);
            }

            Move move = movesManager.GetMove();
            Board.MovePiece(move, player);


            return false;
        }
    }
}
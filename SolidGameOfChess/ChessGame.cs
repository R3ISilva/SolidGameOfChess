namespace SolidGameOfChess
{
    public class ChessGame
    {
        static int totalPlayerCount = 2;

        Board Board;
        bool IsThereAWinner  = false;

        public void StartGame(int humanPlayerCount, bool systemMessages = true)
        {
            if (systemMessages)
            {
                StandardMessages.Welcome();
                GameInput.PressEnterToContinue();
            }

            List<IPlayer> players = GetPlayers(humanPlayerCount);

            Board.SetUpBoard();

            Board.PrintBoard();


            while(!IsThereAWinner)
            {

                Turn turn = new Turn(systemMessages);
                

                Board.Move();

            }
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
    }
}
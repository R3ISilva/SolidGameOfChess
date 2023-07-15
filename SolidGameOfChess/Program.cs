namespace SolidGameOfChess
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO: what game you want to play? use gpt api to get response of how many player
            ChessGame chessGame = new ChessGame();

            //TODO: Validate player count before starting game
            int playerCount = 2;
            chessGame.StartGame(playerCount);
        }
    }

}

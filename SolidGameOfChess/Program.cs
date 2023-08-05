namespace SolidGameOfChess
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO: what game you want to play? use gpt api to get response of how many player

            bool systemMessages = true; //TODO: get this from user

            ChessGame chessGame = new ChessGame(systemMessages);

            int playerCount = 2;
            IPlayer winner = chessGame.PlayGame(playerCount);
        }
    }
}


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace SolidGameOfChess
{
    public class Program
    {
        Player playerOne = new Player();
        Player playerTwo = new Player();

        ChessGame chessGame = new ChessGame(playerOne, playerTwo);
    }

}

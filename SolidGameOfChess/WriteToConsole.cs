namespace SolidGameOfChess
{
    public static class WriteToConsole
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to SolidGameOfChess!");
        }

        public static void EnterPlayerName()
        {
            Console.WriteLine("Enter your player name: ");
        }

        public static void InvalidPlayerName()
        {
            Console.WriteLine("Invalid player name, please try again: ");
        }

        public static void ThatsItThankYouPlayer(string player)
        {
            Console.WriteLine($"That's it {player}! Thank you");
        }

        public static void EnterPlayerMove(string player)
        {
            Console.WriteLine($"Enter your move {player}: ");
        }

        public static void PressEnterToContinue()
        {
            Console.WriteLine("Press Enter to continue");
        }

        public static void CleanTerminal()
        {
            Console.Clear();
        }

        public static void PrintBoard(Board board)
        {
            //TODO: ADD CAPACITY TO PRINT INVERTED
            string horizontalSquares = "";

            foreach (List<BoardSquare> HorizontalSquares in board.Squares)
            {
                foreach (BoardSquare BoardSquare in HorizontalSquares)
                {
                    horizontalSquares += BoardSquare.GetPrint();
                }

                Console.WriteLine(HorizontalSquares);
            }
        }

        public static void AvailableMoves(List<Move> moves)
        {

        }

    }
}

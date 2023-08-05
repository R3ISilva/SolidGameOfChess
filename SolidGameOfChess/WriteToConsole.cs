namespace SolidGameOfChess
{
    public static class WriteToConsole
    {
        public static bool SystemMessages = true;
        private static void WriteValid(string message)
        {
            if (SystemMessages)
            {
                Console.WriteLine(message);
            }
        }

        public static void CleanTerminal()
        {
            Console.Clear();
        }

        public static void Welcome()
        {
            WriteValid("Welcome to SolidGameOfChess!");
        }

        public static void EnterPlayerName()
        {
            WriteValid("Enter your player name: ");
        }

        public static void InvalidPlayerName()
        {
            WriteValid("Invalid player name, please try again: ");
        }

        public static void ThatsItThankYouPlayer(string player)
        {
            WriteValid($"That's it {player}! Thank you");
        }

        public static void EnterPlayerMove(string player)
        {
            WriteValid($"Enter your move {player}: ");
        }

        public static void PressEnterToContinue()
        {
            WriteValid("Press Enter to continue");
        }

        public static void PrintBoard(Board board)
        {
            if (!SystemMessages)
            {
                return;
            }

            //TODO: ADD CAPACITY TO PRINT INVERTED

            foreach (List<BoardSquare> HorizontalSquares in board.Squares)
            {
                string horizontalSquares = "";

                foreach (BoardSquare BoardSquare in HorizontalSquares)
                {
                    Console.Write(BoardSquare.GetPrint());
                }

                Console.Write('\n');
            }
        }

        public static void AvailableMoves(List<Move> moves)
        {

        }

        public static void InvalidMove()
        {
            WriteValid("Invalid Move");
        }
    }
}

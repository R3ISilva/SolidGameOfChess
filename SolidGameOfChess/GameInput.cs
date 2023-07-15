namespace SolidGameOfChess
{
    public static class GameInput
    {
        public static void PressEnterToContinue()
        {
            StandardMessages.PressEnterToContinue();
            Console.ReadLine();
            StandardMessages.CleanTerminal();
        }
    }
}

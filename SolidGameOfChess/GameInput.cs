namespace SolidGameOfChess
{
    public static class GameInput
    {
        public static void PressEnterToContinue()
        {
            WriteToConsole.PressEnterToContinue();
            Console.ReadLine();
            WriteToConsole.CleanTerminal();
        }
    }
}

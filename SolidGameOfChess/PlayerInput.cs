﻿namespace SolidGameOfChess
{
    public class PlayerInput
    {
        private bool isValidName(string name)
        {
            if (name.Length < 0)
            {
                return false;
            }

            return true;
        }
        public string GetPlayerName()
        {
            string name;
            name = Console.ReadLine();

            if (isValidName(name))
            {
                return name;
            }

            return string.Empty;
        }

        public static void PressEnterToContinue()
        {
            WriteToConsole.PressEnterToContinue();
            Console.ReadLine();
            WriteToConsole.CleanTerminal();
        }
    }
}


//Moves moves = new Moves(Board);


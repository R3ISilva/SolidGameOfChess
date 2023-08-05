using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess
{
    public class HumanPlayer : IPlayer
    {
        #region Public Members
        public string Name { get; set; }
        public PlayerInput PlayerInput { get; set; }
        public PieceColor playerColor { get; set; }

        public HumanPlayer()
        {
            PlayerInput = new PlayerInput();
        }

        public bool GetPlayer()
        {
            if (string.IsNullOrEmpty(Name))
            {
                Name = GetPlayerName();
            }

            WriteToConsole.ThatsItThankYouPlayer(Name);
            PlayerInput.PressEnterToContinue();

            return true;
        }

        #endregion

        #region Private Members
        private string GetPlayerName()
        {
            WriteToConsole.EnterPlayerName();

            string name = string.Empty;

            while (string.IsNullOrEmpty(name))
            {
                name = PlayerInput.GetPlayerName();

                if (string.IsNullOrEmpty(name))
                {
                    WriteToConsole.InvalidPlayerName();
                }
            }

            return name;
        }

        public Move GetMove()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

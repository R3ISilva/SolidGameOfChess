namespace SolidGameOfChess
{
    public class HumanPlayer : IPlayer
    {
        #region Public Members
        public string Name { get; set; }
        public PlayerInput PlayerInput { get; set; }
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

            StandardMessages.ThatsItThankYouPlayer(Name);
            GameInput.PressEnterToContinue();

            return true;
        }

        #endregion

        #region Private Members
        private string GetPlayerName()
        {
            StandardMessages.EnterPlayerName();

            string name = string.Empty;

            while (string.IsNullOrEmpty(name))
            {
                name = PlayerInput.GetPlayerName();

                if (string.IsNullOrEmpty(name))
                {
                    StandardMessages.InvalidPlayerName();
                }
            }

            return name;
        }

        #endregion
    }
}

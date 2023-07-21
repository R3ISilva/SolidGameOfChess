using System;
namespace SolidGameOfChess
{
	public class Turn
	{
		public bool SystemMessages;

        public Turn(bool systemMessages)
		{
            SystemMessages = systemMessages;
		}

        internal void StartTurn()
        {
            throw new NotImplementedException();
        }
    }
}


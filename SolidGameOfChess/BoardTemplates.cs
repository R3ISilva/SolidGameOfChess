using static SolidGameOfChess.Enumerators;

namespace SolidGameOfChess
{
    public class BoardTemplates
    {
        //TODO: Add more boards, maybe read them from xml?
        public static BoardTemplate GetStandardBoard(int playerCount)
        {
            if (playerCount < 0 || playerCount > 2)
            {
                throw new Exception("Do something when playercount becomes variable");
            }

            BoardTemplate boardTemplate = new BoardTemplate();

            List<List<BoardSquare>> boardSquares = new List<List<BoardSquare>>();

            const int verticalLines = 8;
            const int horizontalLines = 8;

            for (int i = 0; i < verticalLines; i++)
            {
                List<BoardSquare> horizontalLine = new List<BoardSquare>();
                for (int j = 0; j < horizontalLines; j++)
                {
                    BoardSquare boardSquare = new BoardSquare();
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            boardSquare.Color = SquareColor.White;
                        }
                        else
                        {
                            boardSquare.Color = SquareColor.Black;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            boardSquare.Color = SquareColor.Black;
                        }
                        else
                        {
                            boardSquare.Color = SquareColor.White;
                        }
                    }

                    horizontalLine.Add(boardSquare);
                }

                boardSquares.Add(horizontalLine);
            }


            boardTemplate.Squares = boardSquares;
            return boardTemplate;
        }
    }
}
namespace MineSweeper
{
    public class Game
    {
        public string[][] FindNeighbours(string[][] gameBoard)
        {
            int i = 0;
            int j = 0;
            var rowLimit = gameBoard.Length - 1;
            var columnLimit = gameBoard[0].Length - 1;

            for (i = 0; i < rowLimit; i++)
            {
                for (j = 0; j < columnLimit; j++)
                {
                    for (var x = Math.Max(0, i - 1); x <= Math.Min(i + 1, rowLimit); x++)
                    {
                        for (var y = Math.Max(0, j - 1); y <= Math.Min(j + 1, columnLimit); y++)
                        {
                            if (x != i || y != j)
                            {
                                if (gameBoard[x][y] == ".")
                                {
                                    gameBoard[x][y] = "1";
                                }
                            }
                        }
                    }
                }
            }
            return gameBoard;
        }
    }
}
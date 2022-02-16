namespace MineSweeper
{
    public class Game
    {
        public string[][] FindNeighbours(string[][] gameBoard)
        {
         
            var rowLimit = gameBoard.Length - 1;
            var columnLimit = gameBoard[0].Length - 1;

            for (int y_axisIndex = 0; y_axisIndex < gameBoard.Length; y_axisIndex++)
            {
                for (int x_axisIndex = 0; x_axisIndex < gameBoard.Length; x_axisIndex++)
                {
                    if (gameBoard[y_axisIndex][x_axisIndex] == "*")
                    {
                        for (int rowIndex = Math.Max(0, y_axisIndex - 1); rowIndex <= Math.Min(y_axisIndex + 1, rowLimit); rowIndex++)
                        {
                            for (int columnIndex = Math.Max(0, x_axisIndex - 1); columnIndex <= Math.Min(x_axisIndex + 1, columnLimit); columnIndex++)
                            {
                                if (y_axisIndex != rowIndex || x_axisIndex != columnIndex)
                                {
                                    if (int.TryParse(gameBoard[rowIndex][columnIndex], out int IsNumber))
                                    {
                                        gameBoard[rowIndex][columnIndex] = (IsNumber+1).ToString();
                                    }
                                    if (gameBoard[rowIndex][columnIndex] == ".")
                                    {
                                        gameBoard[rowIndex][columnIndex] = "1";
                                    }
                                }
                            }
                        }
                    }
                    if (gameBoard[y_axisIndex][x_axisIndex] == ".")
                    {
                        gameBoard[y_axisIndex][x_axisIndex] = "0";
                    }
                }
            }
            return gameBoard;
        }
    }
}
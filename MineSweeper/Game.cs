namespace MineSweeper
{
    public class Game
    {
        private string mine = "*";
        private string safeBlock = ".";
        public string[][] FindNeighbours(string[][] gameBoard)
        {
         
            var rowIndexLimit = gameBoard.Length - 1;
            var columnIndexLimit = gameBoard[0].Length - 1;

            for (int indexOfYaxis = 0; indexOfYaxis < gameBoard.Length; indexOfYaxis++)
            {
                for (int indexOfXaxis = 0; indexOfXaxis < gameBoard.Length; indexOfXaxis++)
                {
                    if (gameBoard[indexOfYaxis][indexOfXaxis] == mine)
                    {
                        for (int rowIndex = Math.Max(0, indexOfYaxis - 1); rowIndex <= Math.Min(indexOfYaxis + 1, rowIndexLimit); rowIndex++)
                        {
                            for (int columnIndex = Math.Max(0, indexOfXaxis - 1); columnIndex <= Math.Min(indexOfXaxis + 1, columnIndexLimit); columnIndex++)
                            {
                                if (indexOfYaxis != rowIndex || indexOfXaxis != columnIndex)
                                {
                                    if (int.TryParse(gameBoard[rowIndex][columnIndex], out int IsNumber))
                                    {
                                        gameBoard[rowIndex][columnIndex] = (IsNumber+1).ToString();
                                    }
                                    if (gameBoard[rowIndex][columnIndex] == safeBlock)
                                    {
                                        gameBoard[rowIndex][columnIndex] = "1";
                                    }
                                }
                            }
                        }
                    }
                    if (gameBoard[indexOfYaxis][indexOfXaxis] == safeBlock)
                    {
                        gameBoard[indexOfYaxis][indexOfXaxis] = "0";
                    }
                }
            }
            return gameBoard;
        }
    }
}
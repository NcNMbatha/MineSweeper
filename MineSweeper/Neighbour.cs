using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Neighbour
    {
        public void FindMineNeighbours(string[][] gameBoard, int y_axisIndex, int x_axisIndex)
        {
            int rowIndexLimit = gameBoard.GetLength(0)-1;
            int columnIndexLimit = gameBoard.GetLength(1)-1;

            for (int rowIndex = Math.Max(0, y_axisIndex - 1); rowIndex <= Math.Min(y_axisIndex + 1, rowIndexLimit); rowIndex++)
            {
                for (int columnIndex = Math.Max(0, x_axisIndex - 1); columnIndex <= Math.Min(x_axisIndex + 1, columnIndexLimit); columnIndex++)
                {
                    if (y_axisIndex != rowIndex || x_axisIndex != columnIndex)
                    {
                        if (int.TryParse(gameBoard[rowIndex][columnIndex], out int IsNumber))
                        {
                            gameBoard[rowIndex][columnIndex] = (IsNumber + 1).ToString();
                        }
                        if (gameBoard[rowIndex][columnIndex] == ".")
                        {
                            gameBoard[rowIndex][columnIndex] = "1";
                        }
                    }
                }
            }
        }
    }
}

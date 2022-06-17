using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Mine
    {
        private Neighbour neighbour;

        public Mine()
        {
            neighbour = new Neighbour();
        }

        public string[][] FindMine(string[][] gameBoard)
        {
            for (int y_axisIndex = 0; y_axisIndex < gameBoard.Length; y_axisIndex++)
            {
                for (int x_axisIndex = 0; x_axisIndex < gameBoard.Length; x_axisIndex++)
                {
                    if (gameBoard[y_axisIndex][x_axisIndex] == "*")
                    {
                        neighbour.FindMineNeighbours(gameBoard,y_axisIndex,x_axisIndex);
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

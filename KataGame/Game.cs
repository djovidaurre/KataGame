using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGame
{
    public class Game
    {
        #region Atributos

        public bool?[,] Dashboard { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        #endregion

        #region Constructor

        public Game(int width, int height)
        {
            this.PositionX = width;
            this.PositionY = height;
            this.Dashboard = new bool?[width, height];
        }

        #endregion


        #region Procesos

        public void Init(List<KeyValuePair<int, int>> initial)
        {
            for (var i = 0; i < PositionX; i++)
            {
                for (var j = 0; j < PositionY; j++)
                {
                    this.Dashboard[i, j] =  initial.Any(x => x.Key == i && x.Value == j);
                }
            }
        }

        public void Play()
        {
            bool?[,] tempDashboard = new bool?[PositionX, PositionY];
            for (var i = 0; i < PositionX; i++)
            {
                for (var j = 0; j < PositionY; j++)
                {
                    var CellLivesInit = 0;

                    CellLivesInit += UpdateStateCell(i - 1, j - 1);
                    CellLivesInit += UpdateStateCell(i, j - 1);
                    CellLivesInit += UpdateStateCell(i + 1, j - 1);
                    CellLivesInit += UpdateStateCell(i + 1, j);
                    CellLivesInit += UpdateStateCell(i + 1, j + 1);
                    CellLivesInit += UpdateStateCell(i, j + 1);
                    CellLivesInit += UpdateStateCell(i - 1, j + 1);
                    CellLivesInit += UpdateStateCell(i - 1, j);

                    if (Dashboard[i, j] ?? false)
                    {
                        tempDashboard[i, j] = CellLivesInit == 2 || CellLivesInit == 3;
                    }
                    else
                    {
                        tempDashboard[i, j] = CellLivesInit == 3;
                    }
                }
            }

            this.Dashboard = tempDashboard;
        }

        private int UpdateStateCell(int i, int j)
        {
            return ValidateCell(i, j) ? 1 : 0;

        }
        public bool ValidateCell(int i, int j)
        {
            if (i >= 0 && j >= 0 && i < PositionX && j < PositionY)
            {
                return this.Dashboard[i, j] ?? false;
            }
            return false;
        }

      
        #endregion
    }
}

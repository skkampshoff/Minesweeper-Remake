using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    public class LargeGrid : Grid
    {
        private const int _minMineCount = 50;
        private const int _maxMineCount = 200;

        public static int MinMineCount { get { return _minMineCount; } }
        public static int MaxMineCount { get { return _maxMineCount; } }

        public LargeGrid(int numberOfMines)
        {
            _rows = 30;
            _columns = 30;
            _numberOfMines = numberOfMines;
            IntializeGrid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    public class SmallGrid : Grid
    {
        private static int _minMineCount = 10;
        private static int _maxMineCount = 20;

        public static int MinMineCount { get { return _minMineCount; } }
        public static int MaxMineCount { get { return _maxMineCount; } }

        public SmallGrid(int numberOfMines)
        {
            _rows = 10;
            _columns = 10;
            _numberOfMines = numberOfMines;
            IntializeGrid();
        }
    }
}

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
        private static int _maxMineCount = 40;

        public int MinMineCount { get; }
        public int MaxMineCount { get; }

        public SmallGrid()
        {
            _rows = 10;
            _columns = 10;
            _numberOfMines = 10;
            IntializeGrid();
        }
    }
}

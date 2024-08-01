using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    public class LargeGrid : Grid
    {
        private const int _minMineCount = 30;
        private const int _maxMineCount = 200;

        public int MinMineCount { get; }
        public int MaxMineCount { get; }

        public LargeGrid()
        {
            _rows = 30;
            _columns = 30;
            _numberOfMines = 100;
            IntializeGrid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    public class MediumGrid : Grid
    {
        private static int _minMineCount = 20;
        private static int _maxMineCount = 100;

        public int MinMineCount { get; }
        public int MaxMineCount { get; }

        public MediumGrid()
        {
            _rows = 20;
            _columns = 20;
            _numberOfMines = 10;
            IntializeGrid();
        }

    }
}

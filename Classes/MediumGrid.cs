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
        private static int _maxMineCount = 80;

        public static int MinMineCount { get { return _minMineCount; } }
        public static int MaxMineCount { get { return _maxMineCount; } }

        public MediumGrid(int numberOfMines)
        {
            _rows = 20;
            _columns = 20;
            _numberOfMines = numberOfMines;
            IntializeGrid();
        }

    }
}

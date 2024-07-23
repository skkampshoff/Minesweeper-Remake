using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    internal class LargeGrid : Grid
    {
        private static int _minMineCount = 30;
        private static int _maxMineCount = 200;
        private static int _columns = 30;
        private static int _rows = 30;

        public int MinMineCount { get; }
        public int MaxMineCount { get; }
        public int Columns { get; }
        public int Rows { get; }

        public LargeGrid()
        {
            throw new NotImplementedException();
        }

    }
}

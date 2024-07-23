using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    internal class SmallGrid : Grid
    {
        private static int _minMineCount = 10;
        private static int _maxMineCount = 40;
        private static int _columns = 10;
        private static int _rows = 10;

        public int MinMineCount { get; }
        public int MaxMineCount { get; }
        public int Columns { get; }
        public int Rows { get; }

        public SmallGrid()
        {
            throw new NotImplementedException();
        }
    }
}

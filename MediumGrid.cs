using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    internal class MediumGrid : Grid
    {
        private static int _minMineCount = 20;
        private static int _maxMineCount = 100;
        private static int _columns = 20;
        private static int _rows = 20;

        public int MinMineCount { get; }
        public int MaxMineCount { get; }
        public int Columns { get; }
        public int Rows { get; }

        public MediumGrid()
        {
            throw new NotImplementedException();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    internal abstract class Grid
    {
        private int _numberOfMines;
        private int _totalSquares;
        private int _squaresRevealed;
        private Square[] _squares;

        public int NumberOfMines { get; }
        public int TotalSquares { get; }
        public int SquaresRevealed { get; }
        public Square[] Squares { get; }

        public void IntializeGrid(int rows, int columns, int numberOfMines)
        {
            throw new NotImplementedException();
        }

        public void RevealSquare(Square square)
        {
            throw new NotImplementedException();
        }

        public void ClearAdjacentSquares()
        {
            throw new NotImplementedException();
        }

        public void CalculateAdjacentMines()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperFinalProject
{
    public abstract class Grid
    {
        protected int _rows;
        protected int _columns;
        protected int _numberOfMines;
        protected int _totalSquares;
        protected int _squaresRevealed;
        private Square[,] _squares;

        public int Rows { get { return _rows; } }
        public int Columns { get { return _columns; } }
        public int NumberOfMines { get { return _numberOfMines; } }
        public int TotalSquares { get { return _totalSquares; } }
        public int SquaresRevealed { get { return _squaresRevealed; } }
        public Square[,] Squares { get { return _squares; } }

        public void IntializeGrid()
        {
            _totalSquares = _rows * _columns;
            _squaresRevealed = 0;

            // create 2d array of Squares and intialize all of them
            _squares = new Square[_rows, _columns];
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _columns; col++)
                {
                    _squares[row, col] = new Square();
                }
            }

            // randomly place mines throughout grid
            Random random = new Random();
            int minesPlaced = 0;

            while (minesPlaced < _numberOfMines)
            {
                int randRow = random.Next(_rows);
                int randCol = random.Next(_columns);
                if (!_squares[randRow, randCol].IsMine)
                {
                    _squares[randRow, randCol].IsMine = true;
                    minesPlaced++;
                }
            }

            // calculate adjacent mines for all squares in grid
            for (int row = 0; row < _rows; row++)
            {
                for (int column = 0; column < _columns; column++)
                {
                    CalculateAdjacentMines(row, column);
                }
            }
        }

        public bool RevealSquare(Button[,] buttons, int row, int column)
        {
            bool gameOver = false;
            Button button = buttons[row, column];
            Square square = _squares[row, column];

            if (square.IsFlaged)
            {
                square.IsFlaged = false;
                frmGameForm.AddLabel(button, "");
                return gameOver;
            }

            square.Reveal();

            if (square.IsMine)
            {
                RevealAllMines(buttons);
                gameOver = true;
                return gameOver;
            }
            else if (square.AdjacentMines == 0)
            {
                frmGameForm.AddLabel(button, "");
                ClearAdjacentSquares(buttons, row, column);
            }
            else
            {
                frmGameForm.AddLabel(button, square.AdjacentMines.ToString());
            }

            _squaresRevealed++;
            return gameOver;
        }

        public void FlagSquare(Button[,] buttons, int row, int column)
        {
            Button button = buttons[row, column];
            Square square = _squares[row, column];

            if (!square.IsFlaged)
            {
                square.IsFlaged = true;
                frmGameForm.AddLabel(button, "F");
            }
            else
            {
                square.IsFlaged = false;
                frmGameForm.AddLabel(button, "");
            }
        }

        public void ClearAdjacentSquares(Button[,] buttons, int row, int column)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int r = row + i;
                    int c = column + j;

                    if (!(i == 0 && j == 0) && r >= 0 && r < _rows && c >= 0 && c < _columns)
                    {
                        Square square = _squares[r, c];
                        if (!square.IsMine)
                        {
                            if (!square.IsRevealed)
                            {
                                square.Reveal();
                                if (square.AdjacentMines == 0)
                                {
                                    frmGameForm.AddLabel(buttons[r, c], "");
                                    ClearAdjacentSquares(buttons, r, c);
                                }
                                else
                                {
                                    frmGameForm.AddLabel(buttons[r,c], square.AdjacentMines.ToString());
                                }

                                _squaresRevealed++;
                            }
                        }
                    }
                }
            }
        }

        public void CalculateAdjacentMines(int row, int column)
        {
            if (_squares[row, column].IsMine) return;

            int mineCount = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int r = row + i;
                    int c = column + j;

                    if (!(i == 0 && j == 0) && r >= 0 && r < _rows && c >= 0 && c < _columns)
                    { 
                        if (_squares[r,c].IsMine)
                        {
                            mineCount++;
                        }
                    }
                }
            }

            _squares[row,column].AdjacentMines = mineCount;
        }

        public void RevealAllMines(Button[,] buttons)
        {
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _columns; col++)
                {
                    if (_squares[row,col].IsMine)
                    {
                        frmGameForm.AddLabel(buttons[row, col], "M");
                    }
                    else
                    {
                        frmGameForm.AddLabel(buttons[row, col], "");
                    }
                }
            }
        }

    }
}

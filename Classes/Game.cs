using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperFinalProject
{
    public class Game
    {
        public Grid _currentGrid;
        private TimeSpan _elaspedTime;
        private int _currentScore;
        private static List<int> _topScores = new List<int>();
        private bool _isGameOver;

        public Grid CurrentGrid { get { return _currentGrid; } }
        public TimeSpan ElapsedTime { get { return _elaspedTime; } set { _elaspedTime = value; } }
        public int CurrentScore { get { return _currentScore; } }
        public List<int> TopScores { get { return _topScores; } }
        public bool IsGameOver { get { return _isGameOver; } }

        public Game(string sizeOfGame, int numberOfMines)
        {
            if (sizeOfGame == "small")
            {
                _currentGrid = new SmallGrid(numberOfMines);
            }
            else if (sizeOfGame == "medium")
            {
                _currentGrid = new MediumGrid(numberOfMines);
            }
            else if (sizeOfGame == "large")
            {
                _currentGrid = new LargeGrid(numberOfMines);
            }
            _isGameOver = false;
        }

        public int CalculateScore()
        {
            _currentScore = 10 * _currentGrid.SquaresRevealed;
            if (_currentGrid.SquaresRevealed == (_currentGrid.TotalSquares - _currentGrid.NumberOfMines))
            {
                _isGameOver = true;
                _currentScore += 50 * _currentGrid.NumberOfMines;
                _topScores.Add(_currentScore);
                _topScores.Sort((a, b) => b.CompareTo(a));
            }
            return _currentScore;
        }

        public void GameOver()
        {
            _isGameOver = true;
            _topScores.Add(_currentScore);
            _topScores.Sort((a, b) => b.CompareTo(a));
            frmGameForm.GameOverScreen(_currentScore);
        }

    }
}

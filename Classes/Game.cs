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
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _elaspedTime;
        private int _currentScore;
        private static List<int> _topScores = new List<int>();

        public Grid CurrentGrid { get { return _currentGrid; } }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan ElapsedTime { get; }
        public int CurrentScore { get { return _currentScore; } }
        public List<int> TopScores { get { return _topScores; } }

        public Game(string sizeOfGame)
        {
            if (sizeOfGame == "small")
            {
                _currentGrid = new SmallGrid();
            }
            else if (sizeOfGame == "medium")
            {
                _currentGrid = new MediumGrid();
            }
            else if (sizeOfGame == "large")
            {
                _currentGrid = new LargeGrid();
            }
        }

        public int CalculateScore()
        {
            _currentScore = 10 * _currentGrid.SquaresRevealed;
            if (_currentGrid.SquaresRevealed == (_currentGrid.TotalSquares - _currentGrid.NumberOfMines))
            {
                _currentScore += 20 * _currentGrid.NumberOfMines;
                _topScores.Add(_currentScore);
                _topScores.Sort((a, b) => b.CompareTo(a));
            }
            return _currentScore;
        }

        public void GameOver()
        {
            _topScores.Add(_currentScore);
            _topScores.Sort((a, b) => b.CompareTo(a));
            frmGameForm.GameOverScreen(_currentScore);
}
    }
}

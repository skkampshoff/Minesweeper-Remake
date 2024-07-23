using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    internal class Game
    {
        private Player _currentPlayer;
        private Grid _currentGrid;
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _elaspedTime;

        public Player CurrentPlayer { get; }
        public Grid CurrentGrid { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan ElapsedTime { get; }

        public Game()
        {
            throw new NotImplementedException();
        }

        public void StartNewGame()
        {
            throw new NotImplementedException();
        }

        public int CalculateScore()
        {
            throw new NotImplementedException();
        }
    }
}

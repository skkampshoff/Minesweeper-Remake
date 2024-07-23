using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    internal class Player
    {
        private int _currentscore;
        private List<int> _topScores;

        public int CurrentScore { get; }
        public List<int> TopScores { get; }

        public Player()
        {
            _currentscore = 0;
            _topScores = new List<int>();
        }

        public void CreateNewGame()
        {
            throw new NotImplementedException();
        }

        public void ClickSquare()
        {
            throw new NotImplementedException();
        }

        public void FlagSquare()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    public class Square
    {
        private bool _isRevealed;
        private bool _isMine;
        private bool _isFlaged;
        private int _adjacentMines;

        public bool IsRevealed { get { return _isRevealed; } set { _isRevealed = value; } }
        public bool IsMine { get { return _isMine; } set { _isMine = value; } }
        public bool IsFlaged { get { return _isFlaged; } set { _isFlaged = value; } }
        public int AdjacentMines { get { return _adjacentMines; } set { _adjacentMines = value; } }

        public Square()
        {
            this.IsRevealed = false;
            this.IsMine = false;
            this.IsFlaged = false;
            this.AdjacentMines = 0;
        }

        public void Reveal()
        {
            _isRevealed = true;
        }
        public void Flag()
        {
            if(_isFlaged)
            {
                _isFlaged = false;
            }
            _isFlaged = true;
        }
    }
}

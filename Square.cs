using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperFinalProject
{
    internal class Square
    {
        private bool _isRevealed;
        private bool _isMine;
        private bool _isFlaged;
        private int _adjacentMines;

        public bool IsRevealed { get; }
        public bool IsMine { get; }
        public bool IsFlaged { get; }
        public int AdjacentMines { get; }

        public Square()
        {
            throw new NotImplementedException();
        }

        public void Reveal()
        {
            throw new NotImplementedException();
        }
        public void Flag()
        {
            throw new NotImplementedException();
        }
        public void Unflag()
        {
            throw new NotImplementedException();
        }
    }
}

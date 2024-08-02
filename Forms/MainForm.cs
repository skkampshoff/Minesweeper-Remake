using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperFinalProject
{
    public partial class frmMainForm : Form
    {
        private Game _currentGame;

        public frmMainForm()
        {
            InitializeComponent();

            if (_currentGame != null)
            {
                int num;
                if (_currentGame.TopScores.Count() < 10)
                {
                    num = _currentGame.TopScores.Count();
                }
                else
                {
                    num = 10;
                }

                for (int i = 0; i < num; i++)
                {
                    lboxTopScores.Items.Add(_currentGame.TopScores[i]);
                }
            }

        }

        public frmMainForm(Game currentGame)
        {
            InitializeComponent();

            _currentGame = currentGame;

            if (currentGame != null)
            {
                int num;
                if (_currentGame.TopScores.Count() < 10)
                {
                    num = _currentGame.TopScores.Count();
                }
                else
                {
                    num = 10;
                }

                for (int i = 0; i < num; i++)
                {
                    lboxTopScores.Items.Add(_currentGame.TopScores[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmNewGameForm newGameForm = new frmNewGameForm();

            this.Hide();

            newGameForm.ShowDialog();

            this.Close();
        }

        private void btnQuitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinueGame_Click(object sender, EventArgs e)
        {
            if (_currentGame == null || _currentGame.IsGameOver)
            {
                MessageBox.Show("No Resumable Game Available");
            }
            else
            {            
                frmGameForm gameForm = new frmGameForm(_currentGame);

                this.Hide();

                gameForm.ShowDialog();

                this.Close();
            }
        }

    }
}

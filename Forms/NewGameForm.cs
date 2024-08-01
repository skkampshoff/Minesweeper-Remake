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
    public partial class frmNewGameForm : Form
    {
        private string sizeOfGame;

        public frmNewGameForm()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (sizeOfGame == null)
            {
                MessageBox.Show("Select Size of Game");
                return;
            }

            Game game = new Game(sizeOfGame);

            frmGameForm gameForm = new frmGameForm(game);

            this.Hide();

            gameForm.ShowDialog();

            this.Close();
        }

        private void rbtnSmallGame_CheckedChanged(object sender, EventArgs e)
        {
            sizeOfGame = "small";
        }

        private void rbtnMediumGame_CheckedChanged(object sender, EventArgs e)
        {
            sizeOfGame = "medium";
        }

        private void rbtnLargeGame_CheckedChanged(object sender, EventArgs e)
        {
            sizeOfGame = "large";
        }

    }
}

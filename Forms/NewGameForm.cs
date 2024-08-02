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

            Game game = new Game(sizeOfGame, tbarDifficultySlider.Value);

            frmGameForm gameForm = new frmGameForm(game);

            this.Hide();

            gameForm.ShowDialog();

            this.Close();
        }

        private void rbtnSmallGame_CheckedChanged(object sender, EventArgs e)
        {
            sizeOfGame = "small";
            tbarDifficultySlider.Minimum = SmallGrid.MinMineCount;
            tbarDifficultySlider.Maximum = SmallGrid.MaxMineCount;
            tbarDifficultySlider.Value = (SmallGrid.MaxMineCount - SmallGrid.MinMineCount) / 2 + SmallGrid.MinMineCount;
            tbarDifficultySlider.TickFrequency = 1;
        }

        private void rbtnMediumGame_CheckedChanged(object sender, EventArgs e)
        {
            sizeOfGame = "medium";
            tbarDifficultySlider.Minimum = MediumGrid.MinMineCount;
            tbarDifficultySlider.Maximum = MediumGrid.MaxMineCount;
            tbarDifficultySlider.Value = (MediumGrid.MaxMineCount - MediumGrid.MinMineCount) / 2 + MediumGrid.MinMineCount;
            tbarDifficultySlider.TickFrequency = 5;
        }

        private void rbtnLargeGame_CheckedChanged(object sender, EventArgs e)
        {
            sizeOfGame = "large";
            tbarDifficultySlider.Minimum = LargeGrid.MinMineCount;
            tbarDifficultySlider.Maximum = LargeGrid.MaxMineCount;
            tbarDifficultySlider.Value = (LargeGrid.MaxMineCount - LargeGrid.MinMineCount) / 2 + LargeGrid.MinMineCount;
            tbarDifficultySlider.TickFrequency = 10;
        }

    }
}

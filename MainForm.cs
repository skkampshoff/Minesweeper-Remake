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
        public frmMainForm()
        {
            InitializeComponent();
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
            frmGameForm gameForm = new frmGameForm();

            this.Hide();

            gameForm.ShowDialog();

            this.Close();
        }
    }
}

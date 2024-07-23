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
        public frmNewGameForm()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            frmGameForm gameForm = new frmGameForm();

            this.Hide();

            gameForm.ShowDialog();

            this.Close();
        }
    }
}

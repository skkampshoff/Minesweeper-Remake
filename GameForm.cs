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
    public partial class frmGameForm : Form
    {
        public frmGameForm()
        {
            InitializeComponent();
        }

        private void btnPauseGame_Click(object sender, EventArgs e)
        {
            frmMainForm mainForm = new frmMainForm();

            this.Hide();

            mainForm.ShowDialog();

            this.Close();
        }
    }
}

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
        private Game _currentGame;
        private Button[,] _buttons;
        private DateTime _startTime;
        private Timer _gameTimer;

        public frmGameForm()
        {
            InitializeComponent();
        }

        public frmGameForm(Game currentGame)
        {
            InitializeComponent();

            _currentGame = currentGame;

            InitializeGrid();

            StartTimer();
        }

        private void StartTimer()
        {
            _startTime = DateTime.Now;
            _gameTimer = new Timer();
            _gameTimer.Interval = 1000;
            _gameTimer.Tick += new EventHandler(UpdateTimer);
            _gameTimer.Start();
        }

        private void UpdateTimer(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - _startTime;
            txtTime.Text = elapsed.ToString(@"mm\:ss");
        }

        private void btnPauseGame_Click(object sender, EventArgs e)
        {
            frmMainForm mainForm = new frmMainForm(_currentGame);

            this.Hide();

            mainForm.ShowDialog();

            this.Close();
        }

        private void InitializeGrid()
        {
            int rows = _currentGame.CurrentGrid.Rows;
            int columns = _currentGame.CurrentGrid.Columns;
            _buttons = new Button[rows, columns];
            Square square;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button
                    {
                        Size = new Size(20, 20),
                        Location = new Point((20 * j) + 120, (20 * i) + 20)
                    };

                    int r = i;
                    int c = j;

                    square = _currentGame.CurrentGrid.Squares[r, c];

                    if (square.IsRevealed)
                    {
                        if (square.AdjacentMines == 0)
                        {
                            AddLabel(button, "");
                        }
                        else
                        {
                            AddLabel(button, square.AdjacentMines.ToString());
                        }
                    }
                    else if (square.IsFlaged)
                    {
                        AddLabel(button, "F");
                    }

                    button.MouseUp += (sender, e) => Button_MouseUp(sender, e, r, c);
                    _buttons[r, c] = button;
                    this.Controls.Add(button);
                }
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e, int row, int column)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_currentGame.CurrentGrid.Squares[row,column].IsMine) _gameTimer.Stop();

                if (_currentGame.CurrentGrid.RevealSquare(_buttons, row, column))
                {
                    _currentGame.GameOver();
                }
                txtScore.Text = _currentGame.CalculateScore().ToString();

                if (_currentGame.CurrentGrid.SquaresRevealed == (_currentGame.CurrentGrid.TotalSquares - _currentGame.CurrentGrid.NumberOfMines))
                {
                    _gameTimer.Stop();
                    MessageBox.Show("Congratulations! You Win!" + Environment.NewLine + $"Your Score: {_currentGame.CurrentScore}");
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                _currentGame.CurrentGrid.FlagSquare(_buttons, row, column);
            }
        }

        public static void AddLabel(Button button, string label)
        {
            if (!(label == "F") && !(button.Text == "F"))
            {
                button.Enabled = false;
            }

            button.Text = label;
        }

        public static void GameOverScreen(int score)
        {
            MessageBox.Show("Game Over!" + Environment.NewLine + $"Your Score: {score}");
        }

    }
}
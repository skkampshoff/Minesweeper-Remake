namespace MinesweeperFinalProject
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnContinueGame = new System.Windows.Forms.Button();
            this.btnQuitApplication = new System.Windows.Forms.Button();
            this.lboxTopScores = new System.Windows.Forms.ListBox();
            this.lblTopScores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblMainTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMainTitle.Location = new System.Drawing.Point(317, 84);
            this.lblMainTitle.MaximumSize = new System.Drawing.Size(500, 500);
            this.lblMainTitle.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(103, 50);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Minesweeper";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(321, 166);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(99, 42);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnContinueGame
            // 
            this.btnContinueGame.Location = new System.Drawing.Point(321, 214);
            this.btnContinueGame.Name = "btnContinueGame";
            this.btnContinueGame.Size = new System.Drawing.Size(99, 40);
            this.btnContinueGame.TabIndex = 2;
            this.btnContinueGame.Text = "Continue";
            this.btnContinueGame.UseVisualStyleBackColor = true;
            this.btnContinueGame.Click += new System.EventHandler(this.btnContinueGame_Click);
            // 
            // btnQuitApplication
            // 
            this.btnQuitApplication.Location = new System.Drawing.Point(321, 260);
            this.btnQuitApplication.Name = "btnQuitApplication";
            this.btnQuitApplication.Size = new System.Drawing.Size(99, 33);
            this.btnQuitApplication.TabIndex = 3;
            this.btnQuitApplication.Text = "Quit";
            this.btnQuitApplication.UseVisualStyleBackColor = true;
            this.btnQuitApplication.Click += new System.EventHandler(this.btnQuitApplication_Click);
            // 
            // lboxTopScores
            // 
            this.lboxTopScores.FormattingEnabled = true;
            this.lboxTopScores.ItemHeight = 20;
            this.lboxTopScores.Location = new System.Drawing.Point(536, 149);
            this.lboxTopScores.Name = "lboxTopScores";
            this.lboxTopScores.Size = new System.Drawing.Size(120, 204);
            this.lboxTopScores.TabIndex = 4;
            // 
            // lblTopScores
            // 
            this.lblTopScores.AutoSize = true;
            this.lblTopScores.Location = new System.Drawing.Point(549, 114);
            this.lblTopScores.Name = "lblTopScores";
            this.lblTopScores.Size = new System.Drawing.Size(90, 20);
            this.lblTopScores.TabIndex = 5;
            this.lblTopScores.Text = "Top Scores";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 464);
            this.Controls.Add(this.lblTopScores);
            this.Controls.Add(this.lboxTopScores);
            this.Controls.Add(this.btnQuitApplication);
            this.Controls.Add(this.btnContinueGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "frmMainForm";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnContinueGame;
        private System.Windows.Forms.Button btnQuitApplication;
        private System.Windows.Forms.ListBox lboxTopScores;
        private System.Windows.Forms.Label lblTopScores;
    }
}


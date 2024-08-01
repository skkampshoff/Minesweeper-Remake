namespace MinesweeperFinalProject
{
    partial class frmNewGameForm
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
            this.lblChoice1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.rbtnMediumGame = new System.Windows.Forms.RadioButton();
            this.rbtnLargeGame = new System.Windows.Forms.RadioButton();
            this.rbtnSmallGame = new System.Windows.Forms.RadioButton();
            this.gboxSizeChoices = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gboxSizeChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoice1
            // 
            this.lblChoice1.AutoSize = true;
            this.lblChoice1.Location = new System.Drawing.Point(330, 76);
            this.lblChoice1.Name = "lblChoice1";
            this.lblChoice1.Size = new System.Drawing.Size(165, 20);
            this.lblChoice1.TabIndex = 0;
            this.lblChoice1.Text = "Choose Size of Game";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(348, 276);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(127, 57);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // rbtnMediumGame
            // 
            this.rbtnMediumGame.AutoSize = true;
            this.rbtnMediumGame.Location = new System.Drawing.Point(17, 55);
            this.rbtnMediumGame.Name = "rbtnMediumGame";
            this.rbtnMediumGame.Size = new System.Drawing.Size(90, 24);
            this.rbtnMediumGame.TabIndex = 4;
            this.rbtnMediumGame.TabStop = true;
            this.rbtnMediumGame.Text = "Medium";
            this.rbtnMediumGame.UseVisualStyleBackColor = true;
            this.rbtnMediumGame.CheckedChanged += new System.EventHandler(this.rbtnMediumGame_CheckedChanged);
            // 
            // rbtnLargeGame
            // 
            this.rbtnLargeGame.AutoSize = true;
            this.rbtnLargeGame.Location = new System.Drawing.Point(17, 85);
            this.rbtnLargeGame.Name = "rbtnLargeGame";
            this.rbtnLargeGame.Size = new System.Drawing.Size(75, 24);
            this.rbtnLargeGame.TabIndex = 5;
            this.rbtnLargeGame.TabStop = true;
            this.rbtnLargeGame.Text = "Large";
            this.rbtnLargeGame.UseVisualStyleBackColor = true;
            this.rbtnLargeGame.CheckedChanged += new System.EventHandler(this.rbtnLargeGame_CheckedChanged);
            // 
            // rbtnSmallGame
            // 
            this.rbtnSmallGame.AutoSize = true;
            this.rbtnSmallGame.Location = new System.Drawing.Point(17, 25);
            this.rbtnSmallGame.Name = "rbtnSmallGame";
            this.rbtnSmallGame.Size = new System.Drawing.Size(73, 24);
            this.rbtnSmallGame.TabIndex = 6;
            this.rbtnSmallGame.TabStop = true;
            this.rbtnSmallGame.Text = "Small";
            this.rbtnSmallGame.UseVisualStyleBackColor = true;
            this.rbtnSmallGame.CheckedChanged += new System.EventHandler(this.rbtnSmallGame_CheckedChanged);
            // 
            // gboxSizeChoices
            // 
            this.gboxSizeChoices.Controls.Add(this.rbtnSmallGame);
            this.gboxSizeChoices.Controls.Add(this.rbtnLargeGame);
            this.gboxSizeChoices.Controls.Add(this.rbtnMediumGame);
            this.gboxSizeChoices.Location = new System.Drawing.Point(348, 121);
            this.gboxSizeChoices.Name = "gboxSizeChoices";
            this.gboxSizeChoices.Size = new System.Drawing.Size(127, 136);
            this.gboxSizeChoices.TabIndex = 7;
            this.gboxSizeChoices.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(361, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Minesweeper";
            // 
            // frmNewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gboxSizeChoices);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblChoice1);
            this.Name = "frmNewGameForm";
            this.Text = "NewGameForm";
            this.gboxSizeChoices.ResumeLayout(false);
            this.gboxSizeChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoice1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.RadioButton rbtnMediumGame;
        private System.Windows.Forms.RadioButton rbtnLargeGame;
        private System.Windows.Forms.RadioButton rbtnSmallGame;
        private System.Windows.Forms.GroupBox gboxSizeChoices;
        private System.Windows.Forms.Label lblTitle;
    }
}
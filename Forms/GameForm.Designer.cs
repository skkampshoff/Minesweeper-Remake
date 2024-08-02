namespace MinesweeperFinalProject
{
    partial class frmGameForm
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
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnPauseGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(30, 56);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 20);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score";
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Location = new System.Drawing.Point(88, 56);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(52, 26);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(34, 99);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(88, 99);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(52, 26);
            this.txtTime.TabIndex = 4;
            this.txtTime.Text = "0";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPauseGame
            // 
            this.btnPauseGame.AutoSize = true;
            this.btnPauseGame.Location = new System.Drawing.Point(38, 316);
            this.btnPauseGame.Name = "btnPauseGame";
            this.btnPauseGame.Size = new System.Drawing.Size(127, 51);
            this.btnPauseGame.TabIndex = 5;
            this.btnPauseGame.Text = "Leave Game";
            this.btnPauseGame.UseVisualStyleBackColor = true;
            this.btnPauseGame.Click += new System.EventHandler(this.btnPauseGame_Click);
            // 
            // frmGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(636, 473);
            this.Controls.Add(this.btnPauseGame);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Name = "frmGameForm";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnPauseGame;
    }
}
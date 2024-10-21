using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGuesses = new Label();
            lblStatus = new Label();
            lblRounds = new Label();
            btnSubmit = new Button();
            btnNewGame = new Button();
            txtGuess = new TextBox();
            SuspendLayout();
            // 
            // lblGuesses
            // 
            lblGuesses.AutoSize = true;
            lblGuesses.Location = new Point(227, 150);
            lblGuesses.Name = "lblGuesses";
            lblGuesses.Size = new Size(143, 20);
            lblGuesses.TabIndex = 0;
            lblGuesses.Text = "6 guesses remaining";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(253, 130);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 1;
            // 
            // lblRounds
            // 
            lblRounds.AutoSize = true;
            lblRounds.Location = new Point(52, 150);
            lblRounds.Name = "lblRounds";
            lblRounds.Size = new Size(107, 20);
            lblRounds.TabIndex = 2;
            lblRounds.Text = "Rounds Won: 0";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(227, 26);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(429, 26);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(94, 29);
            btnNewGame.TabIndex = 5;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(52, 26);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(125, 27);
            txtGuess.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGuess);
            Controls.Add(btnNewGame);
            Controls.Add(btnSubmit);
            Controls.Add(lblRounds);
            Controls.Add(lblStatus);
            Controls.Add(lblGuesses);
            Name = "Form1";
            Text = "Hangman Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGuesses;
        private Label lblStatus;
        private Label lblRounds;
        private Button btnSubmit;
        private Button btnNewGame;
        private TextBox txtGuess;
    }
}

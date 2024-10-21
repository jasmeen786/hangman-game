using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private string secretWord;        
        private int remainingGuesses;     
        private int roundsWon;
        private List<char> guessedLetters; 

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewGame(); 
        }

        private void StartNewGame()
        {
            secretWord = GetRandomWord(); 
            remainingGuesses = 6; 
            guessedLetters = new List<char>(); 
            lblGuesses.Text = $"{remainingGuesses} guesses remaining"; 
            lblStatus.Text = ""; 
            txtGuess.Clear(); 
        }

        private string GetRandomWord()
        {
            
            string[] words = { "hangman", "programming", "computer", "game", "development" };
            Random random = new Random();
            return words[random.Next(words.Length)]; 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtGuess.Text) || txtGuess.Text.Length > 1)
            {
                MessageBox.Show("Please enter a single letter.");
                return;
            }

            char guessedLetter = char.ToLower(txtGuess.Text[0]); 
            txtGuess.Clear(); 

            
            if (guessedLetters.Contains(guessedLetter))
            {
                MessageBox.Show("You've already guessed that letter.");
                return;
            }

           
            guessedLetters.Add(guessedLetter);

            
            if (secretWord.Contains(guessedLetter))
            {
                
                if (secretWord.All(c => guessedLetters.Contains(c)))
                {
                    roundsWon++;
                    lblRounds.Text = $"Rounds Won: {roundsWon}"; 
                    lblStatus.Text = "Congratulations! You've won!";
                }
                else
                {
                    lblStatus.Text = "Good guess! Keep trying.";
                }
            }
            else
            {
                remainingGuesses--; 
                lblGuesses.Text = $"{remainingGuesses} guesses remaining"; 
                lblStatus.Text = "Wrong guess! Try again.";

                
                if (remainingGuesses == 0)
                {
                    lblStatus.Text = $"You lost! The word was '{secretWord}'.";
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame(); 
        }
    }
}

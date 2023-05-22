using RockPaperScissors.Properties;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        string playerChoice = string.Empty;
        string computerChoice = string.Empty;
        string draw = string.Empty;
        readonly string[] Options = { "R", "P", "S", "P", "S", "R" };
        string winner = string.Empty;
        Random random = new();
        int computerScore;
        int playerScore;
        int round = 0;
        int totalRounds = 7;

        public Form1()
        {
            InitializeComponent();
            lblCPUWinner.Visible = false;
            lblPlayerWinner.Visible = false;
            lblPlayerChoice.Visible = false;
            lblCPUChoice.Visible = false;
            lblBestOfWins.Visible = true;
            lblBestOfWins.Text = "Let's Play Rock," + Environment.NewLine + "Paper, Scissors." + Environment.NewLine + "Best of 7 Wins!";
            lblRoundPlayed.Visible = false;
        }

        /// <summary>
        /// Determine the winner of the game, display the winner and reset the application to the original state.
        /// </summary>
        /// <param name="sender">The button that was pressed</param>
        /// <param name="e">The event</param>
        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            lblCPU.Text = "Computer Score";
            lblPlayer.Text = "Player Score";
            lblCPUDraw.Text = "";
            lblPlayerDraw.Text = "";
            lblCPUWinner.Visible = false;
            lblPlayerWinner.Visible = false;
            lblBestOfWins.Visible = false;
            lblPlayerChoice.Visible = true;
            lblCPUChoice.Visible = true;

            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;
            int i = random.Next(0, Options.Length);
            computerChoice = Options[i];
            lblPlayerChoice.Text = "Player is: " + UpdateTextandImage(playerChoice, PLAYER_PIC);
            lblCPUChoice.Text = "Computer is: " + UpdateTextandImage(computerChoice, CPU_PIC);

            CheckGame();

            lblRoundPlayed.Visible = true;
            if (round >= totalRounds)
            {
                lblRoundPlayed.Text = "Round " + totalRounds.ToString() + " of " + totalRounds.ToString();
            }
            else
            {
                lblRoundPlayed.Text = "Round " + round.ToString() + " of " + totalRounds.ToString();
            }

            if (round >= totalRounds && playerScore != computerScore)
            {
                lblRoundPlayed.Visible = true;
                lblRoundPlayed.Text = "Round " + round.ToString() + " of " + totalRounds.ToString();

                lblCPUresult.Refresh();
                lblPlayerresult.Refresh();

                if (playerScore > computerScore)
                {
                    winner = "Player 1 Wins!";
                }
                else
                {
                    winner = "Computer Wins!";
                }
                ShowWinner(winner);
                ResetApplication();
            }
        }

        /// <summary>
        /// Reset the application to the original state.
        /// </summary>
        private void ResetApplication()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            lblCPUWinner.Visible = false;
            lblPlayerWinner.Visible = false;
            lblBestOfWins.Visible = true;
            lblBestOfWins.Text = "Let's Play Rock," + Environment.NewLine + "Paper, Scissors." + Environment.NewLine + "Best of 7 Wins!";
            lblRoundPlayed.Visible = false;
            lblPlayerChoice.Visible = false;
            lblCPUChoice.Visible = false;
            playerChoice = string.Empty;
            computerChoice = string.Empty;
            draw = string.Empty;
            winner = string.Empty;
            computerScore = 0;
            playerScore = 0;
            round = 0;
            totalRounds = 7;
        }

        /// <summary>
        /// Set the text and image for the player and computer.
        /// </summary>
        /// <param name="text">The Tag letter of the button selected</param>
        /// <param name="pic">The image selected</param>
        /// <returns>The name of the image selected</returns>
        private string UpdateTextandImage(string text, PictureBox pic)
        {
            string word = string.Empty;
            switch (text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.SCISSORS;
                    break;
            }
            return word;
        }

        /// <summary>
        /// Check the game to see who won and determine the round.
        /// </summary>
        private void CheckGame()
        {
            if (computerChoice == playerChoice)
            {
                lblCPUDraw.Text = "Draw!";
                lblPlayerDraw.Text = "Draw!";
            }
            else if (playerChoice == "R" && computerChoice == "P" || playerChoice == "S" && computerChoice == "R" || playerChoice == "P" && computerChoice == "S")
            {
                computerScore++;
                lblCPUWinner.Visible = true;
                round++;
            }
            else
            {
                playerScore++;
                lblPlayerWinner.Visible = true;
                round++;
            }
            lblCPUresult.Text = computerScore.ToString();
            lblPlayerresult.Text = playerScore.ToString();
        }

        /// <summary>
        /// Display the winner of the game.
        /// </summary>
        /// <param name="winner">A message containing the winner of the game</param>
        private void ShowWinner(string winner)
        {
            using Form form = new();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(500, 500);

            PictureBox pb = new()
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            Label label = new()
            {
                Font = new Font("Segoe UI", 18, FontStyle.Bold)
            };

            if (winner == "Player 1 Wins!")
            {
                pb.Image = Resources.Winner2;
                form.Text = "Player 1 Wins " + playerScore + " to " + computerScore + "!";
            }
            else
            {
                pb.Image = Resources.robot;
                form.Text = "Computer Wins " + computerScore + " to " + playerScore + "!";
            }
            label.Text = form.Text;

            form.Controls.Add(pb);
            form.ShowDialog();
        }

    }

}

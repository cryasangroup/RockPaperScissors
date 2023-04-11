using RockPaperScissors.Properties;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        string playerChoice = string.Empty;
        string computerChoice = string.Empty;
        string draw = string.Empty;
        string[] Options = { "R", "P", "S", "P", "S", "R" };
        string winner = string.Empty;
        Random random = new Random();
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

        private void ShowWinner(string winner)
        {
            using (Form form = new Form())
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = new Size(500, 500);

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                //pb.Location = new Point(100, 0);

                Label label = new Label();
                label.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                //label.MinimumSize = new Size(500,18);



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

                //form.Controls.Add(label);
                form.Controls.Add(pb);

                //GroupBox groupBox1 = new GroupBox();
                //groupBox1.Controls.Add(pb);
                //groupBox1.Controls.Add(label);


                //form.Controls.Add(groupBox1);
                form.ShowDialog();
            }
        }
    }

}

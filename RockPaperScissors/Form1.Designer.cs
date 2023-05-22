namespace RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            CPU_PIC = new PictureBox();
            PLAYER_PIC = new PictureBox();
            lblCPUChoice = new Label();
            lblPlayerChoice = new Label();
            lblPlayerresult = new Label();
            lblCPUresult = new Label();
            lblPlayer = new Label();
            lblCPU = new Label();
            lblPlayerDraw = new Label();
            lblCPUDraw = new Label();
            lblPlayerWinner = new Label();
            lblCPUWinner = new Label();
            lblBestOfWins = new Label();
            lblRoundPlayed = new Label();
            ((System.ComponentModel.ISupportInitialize)CPU_PIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).BeginInit();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.FlatStyle = FlatStyle.System;
            btnRock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRock.Location = new Point(128, 482);
            btnRock.Margin = new Padding(4);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(158, 65);
            btnRock.TabIndex = 0;
            btnRock.Tag = "ROCK";
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += MakeChoiceEvent;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPaper.Location = new Point(422, 482);
            btnPaper.Margin = new Padding(4);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(158, 65);
            btnPaper.TabIndex = 1;
            btnPaper.Tag = "PAPER";
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += MakeChoiceEvent;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnScissors.Location = new Point(706, 482);
            btnScissors.Margin = new Padding(4);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(158, 65);
            btnScissors.TabIndex = 2;
            btnScissors.Tag = "SCISSORS";
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += MakeChoiceEvent;
            // 
            // CPU_PIC
            // 
            CPU_PIC.Location = new Point(442, 86);
            CPU_PIC.Margin = new Padding(4);
            CPU_PIC.Name = "CPU_PIC";
            CPU_PIC.Size = new Size(125, 125);
            CPU_PIC.SizeMode = PictureBoxSizeMode.Zoom;
            CPU_PIC.TabIndex = 3;
            CPU_PIC.TabStop = false;
            // 
            // PLAYER_PIC
            // 
            PLAYER_PIC.Location = new Point(442, 269);
            PLAYER_PIC.Margin = new Padding(4);
            PLAYER_PIC.Name = "PLAYER_PIC";
            PLAYER_PIC.Size = new Size(125, 125);
            PLAYER_PIC.SizeMode = PictureBoxSizeMode.Zoom;
            PLAYER_PIC.TabIndex = 4;
            PLAYER_PIC.TabStop = false;
            // 
            // lblCPUChoice
            // 
            lblCPUChoice.AutoSize = true;
            lblCPUChoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPUChoice.ForeColor = Color.White;
            lblCPUChoice.Location = new Point(401, 34);
            lblCPUChoice.Margin = new Padding(4, 0, 4, 0);
            lblCPUChoice.Name = "lblCPUChoice";
            lblCPUChoice.Size = new Size(211, 32);
            lblCPUChoice.TabIndex = 5;
            lblCPUChoice.Text = "Computer Choice";
            // 
            // lblPlayerChoice
            // 
            lblPlayerChoice.AutoSize = true;
            lblPlayerChoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerChoice.ForeColor = Color.White;
            lblPlayerChoice.Location = new Point(419, 405);
            lblPlayerChoice.Margin = new Padding(4, 0, 4, 0);
            lblPlayerChoice.Name = "lblPlayerChoice";
            lblPlayerChoice.Size = new Size(168, 32);
            lblPlayerChoice.TabIndex = 6;
            lblPlayerChoice.Text = "Player Choice";
            // 
            // lblPlayerresult
            // 
            lblPlayerresult.AutoSize = true;
            lblPlayerresult.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerresult.ForeColor = Color.White;
            lblPlayerresult.Location = new Point(128, 159);
            lblPlayerresult.Margin = new Padding(4, 0, 4, 0);
            lblPlayerresult.Name = "lblPlayerresult";
            lblPlayerresult.Size = new Size(163, 191);
            lblPlayerresult.TabIndex = 7;
            lblPlayerresult.Text = "0";
            // 
            // lblCPUresult
            // 
            lblCPUresult.AutoSize = true;
            lblCPUresult.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPUresult.ForeColor = Color.White;
            lblCPUresult.Location = new Point(740, 159);
            lblCPUresult.Margin = new Padding(4, 0, 4, 0);
            lblCPUresult.Name = "lblCPUresult";
            lblCPUresult.Size = new Size(163, 191);
            lblCPUresult.TabIndex = 8;
            lblCPUresult.Text = "0";
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(128, 86);
            lblPlayer.Margin = new Padding(4, 0, 4, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(155, 32);
            lblPlayer.TabIndex = 9;
            lblPlayer.Text = "Player Score";
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPU.ForeColor = Color.White;
            lblCPU.Location = new Point(706, 86);
            lblCPU.Margin = new Padding(4, 0, 4, 0);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(198, 32);
            lblCPU.TabIndex = 10;
            lblCPU.Text = "Computer Score";
            // 
            // lblPlayerDraw
            // 
            lblPlayerDraw.AutoSize = true;
            lblPlayerDraw.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerDraw.ForeColor = Color.White;
            lblPlayerDraw.Location = new Point(62, 352);
            lblPlayerDraw.Margin = new Padding(4, 0, 4, 0);
            lblPlayerDraw.Name = "lblPlayerDraw";
            lblPlayerDraw.Size = new Size(0, 96);
            lblPlayerDraw.TabIndex = 11;
            // 
            // lblCPUDraw
            // 
            lblCPUDraw.AutoSize = true;
            lblCPUDraw.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPUDraw.ForeColor = Color.White;
            lblCPUDraw.Location = new Point(646, 352);
            lblCPUDraw.Margin = new Padding(4, 0, 4, 0);
            lblCPUDraw.Name = "lblCPUDraw";
            lblCPUDraw.Size = new Size(0, 96);
            lblCPUDraw.TabIndex = 12;
            // 
            // lblPlayerWinner
            // 
            lblPlayerWinner.AutoSize = true;
            lblPlayerWinner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerWinner.ForeColor = Color.Gold;
            lblPlayerWinner.Location = new Point(334, 322);
            lblPlayerWinner.Margin = new Padding(4, 0, 4, 0);
            lblPlayerWinner.Name = "lblPlayerWinner";
            lblPlayerWinner.Size = new Size(98, 32);
            lblPlayerWinner.TabIndex = 13;
            lblPlayerWinner.Text = "Winner";
            // 
            // lblCPUWinner
            // 
            lblCPUWinner.AutoSize = true;
            lblCPUWinner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPUWinner.ForeColor = Color.Gold;
            lblCPUWinner.Location = new Point(575, 145);
            lblCPUWinner.Margin = new Padding(4, 0, 4, 0);
            lblCPUWinner.Name = "lblCPUWinner";
            lblCPUWinner.Size = new Size(98, 32);
            lblCPUWinner.TabIndex = 14;
            lblCPUWinner.Text = "Winner";
            // 
            // lblBestOfWins
            // 
            lblBestOfWins.AutoSize = true;
            lblBestOfWins.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblBestOfWins.ForeColor = Color.White;
            lblBestOfWins.Location = new Point(318, 159);
            lblBestOfWins.Margin = new Padding(4, 0, 4, 0);
            lblBestOfWins.Name = "lblBestOfWins";
            lblBestOfWins.Size = new Size(350, 65);
            lblBestOfWins.TabIndex = 15;
            lblBestOfWins.Text = "Best of 7 Wins";
            lblBestOfWins.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRoundPlayed
            // 
            lblRoundPlayed.AutoSize = true;
            lblRoundPlayed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoundPlayed.ForeColor = Color.White;
            lblRoundPlayed.Location = new Point(422, 215);
            lblRoundPlayed.Margin = new Padding(4, 0, 4, 0);
            lblRoundPlayed.Name = "lblRoundPlayed";
            lblRoundPlayed.Size = new Size(162, 32);
            lblRoundPlayed.TabIndex = 16;
            lblRoundPlayed.Text = "Round 1 of 7";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1000, 562);
            Controls.Add(lblRoundPlayed);
            Controls.Add(lblBestOfWins);
            Controls.Add(lblCPUWinner);
            Controls.Add(lblPlayerWinner);
            Controls.Add(lblCPUDraw);
            Controls.Add(lblPlayerDraw);
            Controls.Add(lblCPU);
            Controls.Add(lblPlayer);
            Controls.Add(lblCPUresult);
            Controls.Add(lblPlayerresult);
            Controls.Add(lblPlayerChoice);
            Controls.Add(lblCPUChoice);
            Controls.Add(PLAYER_PIC);
            Controls.Add(CPU_PIC);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)CPU_PIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private PictureBox CPU_PIC;
        private PictureBox PLAYER_PIC;
        private Label lblCPUChoice;
        private Label lblPlayerChoice;
        private Label lblPlayerresult;
        private Label lblCPUresult;
        private Label lblPlayer;
        private Label lblCPU;
        private Label lblPlayerDraw;
        private Label lblCPUDraw;
        private Label lblPlayerWinner;
        private Label lblCPUWinner;
        private Label lblBestOfWins;
        private Label lblRoundPlayed;
    }
}
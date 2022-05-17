using Tournament.Data;

namespace Tournament
{
    public partial class Form1 : Form
    {
        Player p1 = new Player("Novak Djokovic", 8660);
        Player p2 = new Player("Danil Medvedev", 7987);
        Player p3 = new Player("Alexandar Zverev", 7200);
        Player p4 = new Player("Stefanos Tsitsipas", 6170);
        Player p5 = new Player("Rafael Nadal", 5525);
        Player p6 = new Player("Carlos Alcaraz", 4770);
        Player p7 = new Player("Andrey Rublev", 3945);
        Player p8 = new Player("Casper Ruud", 3940);

        PlayerScore playerScore1 = new PlayerScore(0, 0, 0, 0);
        PlayerScore playerScore2 = new PlayerScore(0, 0, 0, 0);
        PlayerScore playerScore3 = new PlayerScore(0, 0, 0, 0);
        PlayerScore playerScore4 = new PlayerScore(0, 0, 0, 0);
        PlayerScore playerScore5 = new PlayerScore(0, 0, 0, 0);
        PlayerScore playerScore6 = new PlayerScore(0, 0, 0, 0);
        PlayerScore playerScore7 = new PlayerScore(0, 0, 0, 0);
        PlayerScore playerScore8 = new PlayerScore(0, 0, 0, 0);
        public Form1()
        {
            InitializeComponent();

            txtFirstPair.Text = (p1.Name + " vs " + p2.Name);
            txtSecondPair.Text = (p3.Name + " vs " + p4.Name);
            txtThirdPair.Text = (p5.Name + " vs " + p6.Name);
            txtFourthPair.Text = (p7.Name + " vs " + p8.Name);
        }

        private void btnStartQuarterFinal_Click(object sender, EventArgs e)
        {
            Player firstWinner = PlayGame(p1, p2, playerScore1, playerScore2);
            Player secondWinner = PlayGame(p3, p4, playerScore3, playerScore4);
            txtSecondRoundFirstPair.Text = (firstWinner.Name + " vs " + secondWinner.Name);
            Player thirdWinner = PlayGame(p5, p6, playerScore5, playerScore6);
            Player fourthWinner = PlayGame(p7, p8, playerScore7, playerScore8);
            txtSecondRoundSecondPair.Text = (thirdWinner.Name + " vs " + fourthWinner.Name);
        }

        public Player WeightProbabilityAlgorithm(Player p1, Player p2)
        {
            Random random = new Random();
            int n = random.Next(1000);
            if (n < 650)
                return p1;
            else
                return p2;
        }
        public Player PlayGame(Player player1, Player player2, PlayerScore playerScore1, PlayerScore playerScore2)
        {
            bool haveWinner = false;
            bool wonSet = false;
            bool won = false;
            do
            {
                Player winner = player1.Points > player2.Points ? WeightProbabilityAlgorithm(player1, player2) : WeightProbabilityAlgorithm(player2, player1);
                if (player1 == winner)
                {
                    if (playerScore1.Set == 0 && playerScore2.Set == 0)
                    {
                        playerScore1.GameFirstSet++;
                        wonSet = CheckIfPlayerWonFirstSet(playerScore1, playerScore2);
                        if (wonSet)
                            playerScore1.Set++;
                        PrintResult(player1, player2, playerScore1, playerScore2);
                    }
                    else if (playerScore1.Set == 1 && playerScore2.Set == 1)
                    {
                        playerScore1.GameThirdSet++;
                        wonSet = CheckIfPlayerWonThirdSet(playerScore1, playerScore2);
                        if (wonSet)
                        {
                            haveWinner = true;
                            playerScore1.Set++;
                            PrintResult(player1, player2, playerScore1, playerScore2);
                            Console.WriteLine("Winner is " + player1.Name);
                            return player1;
                        }
                        PrintResult(player1, player2, playerScore1, playerScore2);
                    }
                    else if (playerScore1.Set == 1 || playerScore2.Set == 1)
                    {
                        playerScore1.GameSecondSet++;
                        wonSet = CheckIfPlayerWonSecondSet(playerScore1, playerScore2);
                        if (wonSet)
                        {
                            playerScore1.Set++;
                            won = CheckIfPlayerWon(playerScore1);
                        }

                        if (won)
                        {
                            haveWinner = true;
                            PrintResult(player1, player2, playerScore1, playerScore2);
                            Console.WriteLine("Winner is " + player1.Name);
                            return player1;
                        }
                        PrintResult(player1, player2, playerScore1, playerScore2);
                    }
                }
                else
                {
                    if (playerScore2.Set == 0 && playerScore1.Set == 0)
                    {
                        playerScore2.GameFirstSet++;
                        wonSet = CheckIfPlayerWonFirstSet(playerScore2, playerScore1);
                        if (wonSet)
                            playerScore2.Set++;
                        PrintResult(player1, player2, playerScore1, playerScore2);
                    }
                    else if (playerScore1.Set == 1 && playerScore2.Set == 1)
                    {
                        playerScore2.GameThirdSet++;
                        wonSet = CheckIfPlayerWonThirdSet(playerScore2, playerScore1);
                        if (wonSet)
                        {
                            haveWinner = true;
                            playerScore2.Set++;
                            PrintResult(player1, player2, playerScore1, playerScore2);
                            Console.WriteLine("Winner is " + player2.Name);
                            return player2;
                        }
                        PrintResult(player1, player2, playerScore1, playerScore2);
                    }
                    else if (playerScore1.Set == 1 || playerScore2.Set == 1)
                    {
                        playerScore2.GameSecondSet++;
                        wonSet = CheckIfPlayerWonSecondSet(playerScore2, playerScore1);
                        if (wonSet)
                        {
                            playerScore2.Set++;
                            won = CheckIfPlayerWon(playerScore2);
                        }

                        if (won)
                        {
                            haveWinner = true;
                            PrintResult(player1, player2, playerScore1, playerScore2);
                            Console.WriteLine("Winner is " + player2.Name);
                            return player2;
                        }
                        PrintResult(player1, player2, playerScore1, playerScore2);
                    }
                }
            } while (!haveWinner);

            return null;

        }

        public bool CheckIfPlayerWonFirstSet(PlayerScore playerScore1, PlayerScore playerScore2)
        {
            if ((playerScore1.GameFirstSet == 6 && playerScore2.GameFirstSet <= 4) ||
                (playerScore1.GameFirstSet > 6 && playerScore1.GameFirstSet == (playerScore2.GameFirstSet + 2)))
                return true;
            else return false;
        }
        public bool CheckIfPlayerWonSecondSet(PlayerScore playerScore1, PlayerScore playerScore2)
        {
            if ((playerScore1.GameSecondSet == 6 && playerScore2.GameSecondSet <= 4) ||
                (playerScore1.GameSecondSet > 6 && playerScore1.GameSecondSet == (playerScore2.GameSecondSet + 2)))
                return true;
            else return false;
        }
        public bool CheckIfPlayerWonThirdSet(PlayerScore playerScore1, PlayerScore playerScore2)
        {
            if ((playerScore1.GameThirdSet == 6 && playerScore2.GameThirdSet <= 4) ||
                (playerScore1.GameThirdSet > 6 && playerScore1.GameThirdSet == (playerScore2.GameThirdSet + 2)))
                return true;
            else return false;
        }

        public bool CheckIfPlayerWon(PlayerScore playerScore)
        {
            if (playerScore.Set == 2)
                return true;
            else return false;
        }

        public void PrintResult(Player player1, Player player2, PlayerScore playerScore1, PlayerScore playerScore2)
        {
            Console.WriteLine(player1.Name + " vs " + player2.Name);
            if (playerScore1.Set == 0 && playerScore2.Set == 0)
                Console.WriteLine("Set 1 : " + playerScore1.GameFirstSet + " : " + playerScore2.GameFirstSet);
            else if ((playerScore1.Set == 1 && playerScore2.Set == 1) || (playerScore1.Set == 2 || playerScore2.Set == 2))
            {
                Console.WriteLine("Set 1 : " + playerScore1.GameFirstSet + " : " + playerScore2.GameFirstSet);
                Console.WriteLine("Set 2 : " + playerScore1.GameSecondSet + " : " + playerScore2.GameSecondSet);
                Console.WriteLine("Set 3 : " + playerScore1.GameThirdSet + " : " + playerScore2.GameThirdSet);
            }
            else if (playerScore1.Set == 1 || playerScore2.Set == 1)
            {
                Console.WriteLine("Set 1 : " + playerScore1.GameFirstSet + " : " + playerScore2.GameFirstSet);
                Console.WriteLine("Set 2 : " + playerScore1.GameSecondSet + " : " + playerScore2.GameSecondSet);
            }

            Console.WriteLine("Score : " + playerScore1.Set + " : " + playerScore2.Set);
        }

        private void btnStartSemifinal_Click(object sender, EventArgs e)
        {
            if (txtSecondRoundFirstPair.Text == "" || txtSecondRoundSecondPair.Text == "")
            {
                MessageBox.Show("Start quarter final first!");
                return;
            }

        }

        private void btnStartTournament_Click(object sender, EventArgs e)
        {
            Player firstSemifinalist = PlayGame(p1, p2, playerScore1, playerScore2);
            Player secondSemifinalist = PlayGame(p3, p4, playerScore3, playerScore4);
            txtSecondRoundFirstPair.Text = (firstSemifinalist.Name + " vs " + secondSemifinalist.Name);
            Player thirdSemifinalist = PlayGame(p5, p6, playerScore5, playerScore6);
            Player fourthSemifinalist = PlayGame(p7, p8, playerScore7, playerScore8);
            txtSecondRoundSecondPair.Text = (thirdSemifinalist.Name + " vs " + fourthSemifinalist.Name);

            PlayerScore scoreSemifinalist1 = new PlayerScore(0, 0, 0, 0);
            PlayerScore scoreSemifinalist2 = new PlayerScore(0, 0, 0, 0);
            PlayerScore scoreSemifinalist3 = new PlayerScore(0, 0, 0, 0);
            PlayerScore scoreSemifinalist4 = new PlayerScore(0, 0, 0, 0);


            Player firstFinalist = PlayGame(firstSemifinalist, secondSemifinalist, scoreSemifinalist1, scoreSemifinalist2);
            Player secondFinalist = PlayGame(thirdSemifinalist, fourthSemifinalist, scoreSemifinalist3, scoreSemifinalist4);
            txtFinalists.Text = (firstFinalist.Name + " vs " + secondFinalist.Name);

            PlayerScore scoreFinalist1 = new PlayerScore(0, 0, 0, 0);
            PlayerScore scoreFinalist2 = new PlayerScore(0, 0, 0, 0);

            Player winner = PlayGame(firstFinalist, secondFinalist, scoreFinalist1, scoreFinalist2);

            txtWinnerOfTournament.Text = winner.Name;
        }
    }
}
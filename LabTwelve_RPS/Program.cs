using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve_RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors. Play if you dare!");
            string contGame = "";

            Player player = new Player3();
            player.Name = "We'rePlayingAnyway";

            Console.Write("Enter your name: ");
            string currentUserName = Console.ReadLine();

            Console.Write("Would you like to play against TheJets or TheSharks? (j/s): ");
            string playAgainst = Console.ReadLine();
            while (playAgainst != "j" && playAgainst != "s")
            {
                Console.Write("Please enter j or s: ");
                playAgainst = Console.ReadLine();
            }

            int userWinCount = 0;
            int playerWinCount = 0;
            int drawCount = 0;
            do
            {

                if (playAgainst == "j")
                {
                    player = new Player1();
                    player.Name = "TheJets";
                }
                else if (playAgainst == "s")
                {
                    player = new Player2();
                    player.Name = "TheSharks";
                }

                Console.Write("Rock, Paper or Scissors? (r/p/s): ");
                string userChoice = Console.ReadLine();
                //while loop here too 

                RoshamboEnum userRoshambo = RoshamboEnum.NONE;
                if (userChoice == "r")
                {
                    userRoshambo = RoshamboEnum.ROCK;
                }
                else if (userChoice == "p")
                {
                    userRoshambo = RoshamboEnum.PAPER;
                }
                else if (userChoice == "s")
                {
                    userRoshambo = RoshamboEnum.SCISSORS;
                }
                RoshamboEnum playerRoshambo;
                playerRoshambo = player.generateRoshambo();

                string userRoshamboName = Enum.GetName(typeof(RoshamboEnum), userRoshambo);
                string playerRoshamboName = Enum.GetName(typeof(RoshamboEnum), playerRoshambo);
                Console.WriteLine(currentUserName + ": " + userRoshamboName);
                Console.WriteLine(player.Name + ": " + playerRoshamboName);

                if (userRoshambo == RoshamboEnum.PAPER)
                {
                    switch (playerRoshambo)
                    {
                        case RoshamboEnum.PAPER:
                            Console.WriteLine("Draw!");
                            drawCount++;
                            break;
                        case RoshamboEnum.ROCK:
                            Console.WriteLine(currentUserName + " Wins!");
                            userWinCount++;
                            break;
                        case RoshamboEnum.SCISSORS:
                            Console.WriteLine(player.Name + " Wins!");
                            playerWinCount++;
                            break;
                    }
                }
                else if (userRoshambo == RoshamboEnum.ROCK)
                {
                    switch (playerRoshambo)
                    {
                        case RoshamboEnum.PAPER:
                            Console.WriteLine(player.Name + " Wins!");
                            playerWinCount++;
                            break;
                        case RoshamboEnum.ROCK:
                            Console.WriteLine("Draw!");
                            drawCount++;
                            break;
                        case RoshamboEnum.SCISSORS:
                            Console.WriteLine(currentUserName + " Wins!");
                            userWinCount++;
                            break;
                    }
                }
                else if (userRoshambo == RoshamboEnum.SCISSORS)
                {
                    switch (playerRoshambo)
                    {
                        case RoshamboEnum.PAPER:
                            Console.WriteLine(currentUserName + " Wins!");
                            userWinCount++;
                            break;
                        case RoshamboEnum.ROCK:
                            Console.WriteLine(player.Name + " Wins!");
                            playerWinCount++;
                            break;
                        case RoshamboEnum.SCISSORS:
                            Console.WriteLine("Draw!");
                            drawCount++;
                            break;
                    }
                }
                Console.Write("Do you want to play again? (y/n): ");
                contGame = Console.ReadLine();
            } while (contGame.ToLower() == "y");
            Console.WriteLine();
            Console.WriteLine(currentUserName + " won " + userWinCount + " game(s)");
            Console.WriteLine(player.Name + " won " + playerWinCount + " game(s)");
            Console.WriteLine("There number of draws were " + drawCount);
            Console.WriteLine("Thank you for playing!  Press [ENTER] to exit.");
            Console.ReadLine();
        }
    }
    public enum RoshamboEnum
    {
        ROCK, PAPER, SCISSORS, NONE
    }
}

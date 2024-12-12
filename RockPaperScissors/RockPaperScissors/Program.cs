using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool letsplayagain = true;
            string player;
            string computer;
            string answer;
            int computerscore;
            int playerscore;

            playerscore = 0;
            computerscore = 0;

            while (letsplayagain)
            {
                

                player = "";
                computer = "";
                answer = "";

                while (player != "rock" && player != "paper" && player != "scissors")
                {
                    Console.WriteLine("Welcome to Rock, Paper, Scissors! Please choose one option.");
                    player = Console.ReadLine();
                    player = player.ToLower();
                }

                int randomNumber = rand.Next(1, 4);

                switch (randomNumber)
                {
                    case 1:
                        computer = "rock";
                        break;

                    case 2:
                        computer = "paper";
                        break;

                    case 3:
                        computer = "scissors";
                        break;
                }

                Console.WriteLine("Your choice: " + player);
                Console.WriteLine("Computer's choice: " + computer);

                switch (player)
                {
                    case "rock":
                        if (computer == "rock")
                        {
                            Console.WriteLine("It is a draw.");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("You lose.");
                            computerscore++;
                        }
                        else
                        {
                            Console.WriteLine("You win.");
                            playerscore++;
                        }
                        break;

                    case "paper":
                        if (computer == "rock")
                        {
                            Console.WriteLine("You win.");
                            playerscore++;
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("It is a draw.");
                        }
                        else
                        {
                            Console.WriteLine("You lose.");
                            computerscore++;
                        }
                        break;

                    case "scissors":
                        if (computer == "rock")
                        {
                            Console.WriteLine("You lose.");
                            computerscore++;
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("You win.");
                            playerscore++;
                        }
                        else
                        {
                            Console.WriteLine("It is a draw.");
                        }
                        break;
                }

                Console.WriteLine("Your score: " + playerscore);
                Console.WriteLine("Computer score: " + computerscore);

                Console.WriteLine("Would you like to play again? y/n:");
                answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "y")
                {
                    letsplayagain = true;
                }
                else if (answer == "n")
                {
                    letsplayagain = false;
                    Console.WriteLine("Thanks for playing!");
                }

                
            }
        }
    }
}

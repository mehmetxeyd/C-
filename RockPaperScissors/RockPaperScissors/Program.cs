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
                        }
                        else
                        {
                            Console.WriteLine("You win.");
                        }
                        break;

                    case "paper":
                        if (computer == "rock")
                        {
                            Console.WriteLine("You win.");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("It is a draw.");
                        }
                        else
                        {
                            Console.WriteLine("You lose.");
                        }
                        break;

                    case "scissors":
                        if (computer == "rock")
                        {
                            Console.WriteLine("You lose.");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("You win.");
                        }
                        else
                        {
                            Console.WriteLine("It is a draw.");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again? y/n:");
                answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "y")
                {
                    letsplayagain = true;
                }
                else
                {
                    letsplayagain = false;
                }

                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}

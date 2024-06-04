using System;
using System.Runtime.InteropServices;

namespace RockPaperScissors
{
    internal class Program
    {
        private static void Main()
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";
            int drawCounter = 0;
            int winCounter = 0;
            int loseCounter = 0;

            System.Console.WriteLine($"Current score: Wins: {winCounter} Loses: {loseCounter} Draws: {drawCounter}");
            System.Console.Write("Chose [r]ock, [p]aper or [s]cissors: ");
            string choice = Console.ReadLine();

            while (choice != "exit" ||
                   choice != "quit" )
            {

                if (choice == "r" ||
                    choice == "R" ||
                    choice == "rock" ||
                    choice == "Rock"
                    )
                {
                    choice = rock;
                }
                else if (choice == "p" ||
                    choice == "P" ||
                    choice == "paper" ||
                    choice == "Paper"
                    )
                {
                    choice = paper;
                }
                else if (choice == "s" ||
                    choice == "S" ||
                    choice == "scissors" ||
                    choice == "Scissors"
                    )
                {
                    choice = scissors;
                }
                else if (choice == "exit" ||
                         choice == "quit"
                         )
                {
                    System.Console.WriteLine("Good bye...");
                    return;
                }
                else
                {
                    System.Console.WriteLine("Invaild Input. Try Again");
                    return;
                }

                Random random = new Random();
                int computerRandomNum = random.Next(1, 4);
                string computerChoice = "";

                switch (computerRandomNum)
                {
                    case 1:
                        computerChoice = rock;
                        break;

                    case 2:
                        computerChoice = paper;
                        break;

                    case 3:
                        computerChoice = scissors;
                        break;
                }

                if (choice == computerChoice)
                {
                    drawCounter++;
                    Console.Clear();

                    System.Console.WriteLine($"Computer chose: {computerChoice}!");
                    System.Console.WriteLine("Draw");
                    
                }
                else if ((choice == rock && computerChoice == scissors) ||
                        (choice == paper && computerChoice == rock ) ||
                        (choice == scissors && computerChoice == paper))
                {
                    winCounter++;
                    Console.Clear();

                    System.Console.WriteLine($"Computer chose: {computerChoice}!");
                    System.Console.WriteLine("You Win.");
                }
                else
                {
                    loseCounter++;
                    Console.Clear();
                    
                    System.Console.WriteLine($"Computer chose: {computerChoice}!");
                    System.Console.WriteLine("You lose!");
                }

                System.Console.WriteLine();
                System.Console.WriteLine($"Current score: Wins: {winCounter} Loses: {loseCounter} Draws: {drawCounter}");
                System.Console.Write("Chose [r]ock, [p]aper or [s]cissors: ");
                choice = Console.ReadLine();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create subclass Human player that allows the suser to select and throw a value
//and allows user to input their name

namespace RoshamboLab
{
    public class HumanPlayer : Player
    {
        public override string Name { get; }

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            while (true)
            {
                Console.WriteLine("Enter your selection (1. Rock, 2. Paper, 3. Scissors):");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "1" || input == "rock" || input == "r")
                    return Roshambo.rock;
                else if (input == "2" || input == "paper" || input == "p")
                    return Roshambo.paper;
                else if (input == "3" || input == "scissors" || input == "s")
                    return Roshambo.scissors;

                Console.WriteLine("Invalid input. Please enter 1, 2, or 3, or rock/paper/scissors.");
            }
        }
    }
}
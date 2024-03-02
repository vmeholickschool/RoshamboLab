//Create a main where you create a HumanPlayer
//and then allow them to chose their opponent
//either RockPlayer or RandomPlayer
//Validate your user inputs throughout your app. 
//Try catch blocks, if statments , or any other method of validation

namespace RoshamboLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors!");

            // Keep track of wins and losses
            int humanWins = 0;
            int humanLosses = 0;
            string playerName = "";

            // Prompt user for name until a valid name is provided with a loop
            while (string.IsNullOrEmpty(playerName))
            {
                Console.Write("Enter your name: ");
                playerName = Console.ReadLine();
                if (string.IsNullOrEmpty(playerName))
                    Console.WriteLine("Name cannot be empty. Please enter your name.");
            }

            // Create a human player
            Player humanPlayer = new HumanPlayer(playerName);

            // Choose opponent
            Player opponent = null;
            string opponentName = "";
            while (opponent == null)
            {
                Console.WriteLine("Choose your opponent:");
                Console.WriteLine("1. RockPlayer");
                Console.WriteLine("2. RandomPlayer");
                Console.Write("Enter your choice (1 or 2): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        opponent = new RockPlayer();
                        opponentName = "RockPlayer";
                        break;
                    case "2":
                        opponent = new RandomPlayer();
                        opponentName = "RandomPlayer";
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            }

            Console.WriteLine($"You chose {opponentName} as your opponent. ");
            //loop to check if user wants to continue to play
            bool playAgain = true;
            while (playAgain)
            {
                Roshambo humanMove = humanPlayer.GenerateRoshambo();
                Roshambo opponentMove = opponent.GenerateRoshambo();

                Console.WriteLine($"{humanPlayer.Name} chose {humanMove}");
                Console.WriteLine($"{opponentName} chose {opponentMove}");

                // Determine the winner
                if ((humanMove == Roshambo.rock && opponentMove == Roshambo.scissors) ||
                    (humanMove == Roshambo.paper && opponentMove == Roshambo.rock) ||
                    (humanMove == Roshambo.scissors && opponentMove == Roshambo.paper))
                {
                    Console.WriteLine($"{humanPlayer.Name} wins!");
                    humanWins++;
                }
                else if (humanMove == opponentMove)
                {
                    Console.WriteLine("It's a tie!");
                }
                else
                {
                    Console.WriteLine($"{opponentName} wins!");
                    humanLosses++;
                }
                //display wins and losses after each session
                Console.WriteLine($"Wins: {humanWins}, Losses: {humanLosses}");

                Console.Write("Do you want to play again? (yes/no): ");
                string playAgainInput = Console.ReadLine().Trim().ToLower();
                playAgain = playAgainInput == "yes" || playAgainInput == "y";
            }
        }
    }
}
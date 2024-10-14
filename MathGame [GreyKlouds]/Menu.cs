using MathGame;

namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}! It is {date.Date}. \n This is the math game. That's great that you're working on imporving  your math solving skills!\n");
            Console.WriteLine("Press [ENTER] to continue");
            Console.ReadLine();
            Console.WriteLine("\n");
            bool gameRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@"What game would you like to play today? Choose from the options below:
                           A - Addition
                           S - Subtraction
                           M - Multiplication
                           D - Division
                           V - View Previous Games
                           Q - Quit
                        ");
                Console.WriteLine("------------------------------");

                var gameSelection = Console.ReadLine();

                switch (gameSelection.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game!");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game!");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game!");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Divison game!");
                        break;
                    case "q":
                        gameRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            } while (gameRunning);
        }

    }
}

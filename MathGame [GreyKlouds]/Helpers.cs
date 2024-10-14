using MathGame.Model;
using System.Linq;
namespace MathGame
{
    class Helpers
    {

        internal static List<Game> games = new List<Game>();

        internal static void PrintGames()
        {
           // var gamesToPrince = games.Where(x => x.type == GameType.Division); // linq example

            Console.Clear();
            Console.WriteLine("Game history: ");
            Console.WriteLine("--------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.type}: {game.score} {game.DifficultyLevel}");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();

        }
        internal static void AddToHistory(int gamesScore, GameType gameType, string levelOfDifficulty)
        {
           
            games.Add(new Game
            {
                DifficultyLevel = levelOfDifficulty,
                Date = DateTime.Now,
                score = gamesScore,
                type = gameType
            });
        }
        internal static int[] GetDivisonNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);

            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Please try again.");
                result = Console.ReadLine();
            }
          return result;    
        }
      internal static  string GetName()
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty. Please try again.");
                name = Console.ReadLine();
            }
            return name;
        }
      

    }
}

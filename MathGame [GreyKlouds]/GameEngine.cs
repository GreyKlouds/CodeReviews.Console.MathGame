using MathGame;
using MathGame.Model;

namespace MathGame
{
    internal class GameEngine
    {
        internal string DifficultyLevel(string levelOfDifficulty)
        {
            switch (levelOfDifficulty)
            {
                case "1":
                    levelOfDifficulty = "Easy";
                    break;
                case "2":
                    levelOfDifficulty = "Medium";
                    break;
                case "3":
                    levelOfDifficulty = "Hard";
                    break;
                case "4":
                    levelOfDifficulty = "Expert";
                    break;
                default:
                    levelOfDifficulty = "Easy";
                    break;
            }
            return levelOfDifficulty;
        }
        internal void AdditionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            Console.WriteLine(@"Please select a difficulty level:        
                                    1. Easy
                                    2. Medium
                                    3. Hard
                                    4. Expert");
            var choice = DifficultyLevel(Console.ReadLine());

            while (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("You must choice a difficulty level between 1 & 5 Please try again.");
                choice = Console.ReadLine();
            }
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Addition, choice);
            choice = string.Empty;

        }
        internal void SubtractionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            Console.WriteLine(@"Please select a difficulty level:        
                                    1. Easy
                                    2. Medium
                                    3. Hard
                                    4. Expert");
            var choice = DifficultyLevel(Console.ReadLine());

            while (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("You must choice a difficulty level between 1 & 5 Please try again.");
                choice = Console.ReadLine();
            }

            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);


                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect.");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Subtraction, choice);
            choice = string.Empty;
        }
        internal void MultiplicationGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;
            Console.WriteLine(@"Please select a difficulty level:        
                                    1. Easy
                                    2. Medium
                                    3. Hard
                                    4. Expert");
            var choice = DifficultyLevel(Console.ReadLine());

            while (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("You must choice a difficulty level between 1 & 5 Please try again.");
                choice = Console.ReadLine();
            }

            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Multiplication, choice);
            choice = string.Empty;
        }
        internal void DivisionGame(string message)
        {
            var score = 0;

            Console.WriteLine(@"Please select a difficulty level:        
                                    1. Easy
                                    2. Medium
                                    3. Hard
                                    4. Expert");
            var choice = DifficultyLevel(Console.ReadLine());
            
            while (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("You must choice a difficulty level between 1 & 5 Please try again.");
                choice = Console.ReadLine();
            }

            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
              
                var divisionNumbers = Helpers.GetDivisonNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect.");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Division, choice);
            choice = string.Empty;
        }
      
    }
}
namespace MathGame.Model;
internal class Game
{
    public DateTime Date { get; set; }
    public int score { get; set; }
    public GameType type {  get; set; }
    public  string DifficultyLevel { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

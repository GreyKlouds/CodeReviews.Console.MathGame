using MathGame;

var date = DateTime.UtcNow;

var games = new List<string>();

var menu = new Menu();

string name = Helpers.GetName();

menu.ShowMenu(name, date);


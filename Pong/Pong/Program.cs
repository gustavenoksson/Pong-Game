using Pong;

//Console.WriteLine(Console.WindowWidth);
//Console.WriteLine(Console.WindowHeight);

while (true) {
var PlayingField = new PlayingField();

PlayingField.DrawField();

var Padel = new Padel();

//Padel.DrawPadel();

var key = Console.ReadKey(true).Key;

if (key == ConsoleKey.W)
{
    Padel.MoveUp();
}
}
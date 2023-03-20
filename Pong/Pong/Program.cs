using Pong;

//Console.WriteLine(Console.WindowWidth);
//Console.WriteLine(Console.WindowHeight);

var PlayingField = new PlayingField();

PlayingField.DrawField();

var padel1StartPoint = new Point(7, 6);
var padel2StartPoint = new Point(83, 6);

var Padel1 = new Padel(padel1StartPoint);
var Padel2 = new Padel(padel2StartPoint);

Padel1.DrawPadel();
Padel2.DrawPadel();

while (true)
{
    var playerOneUpKey = Console.ReadKey(true).Key;
    if (playerOneUpKey == ConsoleKey.W)
    {
       Padel1.MoveUp();
    }

    var playerOneDownKey = Console.ReadKey(true).Key;
    if (playerOneDownKey == ConsoleKey.S)
    {
        Padel1.MoveDown();
    }
}
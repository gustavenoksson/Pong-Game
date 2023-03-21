using Pong;
using System.Timers;

var PlayingField = new PlayingField();

PlayingField.DrawField();

var padel1StartPoint = new Point(7, 6);
var padel2StartPoint = new Point(PlayingField.width-2, 6);
var ballStartingPoint = new Point(PlayingField.width/2, PlayingField.height/2);

var Padel1 = new Padel(padel1StartPoint);
var Padel2 = new Padel(padel2StartPoint);
var Ball = new Ball(ballStartingPoint);

Padel1.DrawPadel();
Padel2.DrawPadel();
Ball.DrawBall();



while (true)
{
    Ball.Move(Padel1, Padel2);
    var key = Console.ReadKey(true).Key;
    switch (key) { 
        case ConsoleKey.W:
            Padel1.MoveUp();
            break;
        case ConsoleKey.S:
            Padel1.MoveDown();
            break;
        case ConsoleKey.UpArrow:
            Padel2.MoveUp();
            break;
        case ConsoleKey.DownArrow:
            Padel2.MoveDown();
            break;
    }
}
﻿using Pong;
using System.Timers;

var PlayingField = new PlayingField();

PlayingField.DrawField();

var padel1StartPoint = new Point(8, 6);
var padel2StartPoint = new Point(PlayingField.width-3, 6);
var ballStartingPoint = new Point(PlayingField.width/2, PlayingField.height/2);
var left = new Side(-1);
var right = new Side(1);

var Padel1 = new Padel(padel1StartPoint, left);
var Padel2 = new Padel(padel2StartPoint, right);
var Ball = new Ball(ballStartingPoint);

Padel1.DrawPadel();
Padel2.DrawPadel();
Ball.DrawBall();

Task.Run(() =>
{
    while (true)
    {
        Ball.Move(Padel1, Padel2);
        Thread.Sleep(100);
        if(Ball.checkForGoal())
        {
            if (Ball.CheckIfGG())
            {
                for(var i = 9; i < PlayingField.width -9; i++)
                {
                    Console.SetCursorPosition(i, 7);
                    Console.WriteLine(" ");
                }
                Console.SetCursorPosition(42, 7);
                
                Console.WriteLine("GAME OVER");
                break;
            }


            else if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Ball.ResetBall();

                PlayingField.ClearText();

                continue;
            }
        }
    }
});

while (true)
{
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
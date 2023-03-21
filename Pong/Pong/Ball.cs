using System;
namespace Pong
{
	public class Ball
	{
        Point Point;
        string Direction;

        public Ball(Point point)
		{
            Point = point;
            Direction = "left";
        }

        public void DrawBall()
        {            Console.SetCursorPosition(Point.X, Point.Y);
            Console.WriteLine('◉');
        }

        private void ClearBall()
        {
            Console.SetCursorPosition(Point.X, Point.Y);
            Console.WriteLine(' ');
        }

        public void Move(Padel padel1, Padel padel2)
        {
            ClearBall();
            if (Direction == "left")
            {
                Point.Y++;
                Point.X--;
                CheckPadelCollision(padel1);
            } else if (Direction == "right")
            {
                Point.Y++;
                Point.X++;
                CheckPadelCollision(padel2);
            }
            DrawBall();
        }

        private void CheckPadelCollision(Padel padel)
        {
            if (Point.X == padel.Point.X && Point.Y == padel.Point.Y || Point.X == padel.Point.X && Point.Y == padel.Point.Y+1)
            {
                if (Direction == "left")
                {
                    Direction = "right";
                } else
                {
                    Direction = "left";
                }
            }
        }
	}
}
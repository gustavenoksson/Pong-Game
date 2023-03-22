using System;
namespace Pong
{
	public class Ball
	{
        Point Point;
        string Direction;
        Koef K;

        public Ball(Point point, Koef k)
		{
            Point = point;
            Direction = "left";
            K = k;


        }

        public void DrawBall()
        {
                Console.SetCursorPosition(Point.X, Point.Y);
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
                if (Point.Y == 1 || Point.Y == 12)
                {
                    K.K *= -1;

                    Point.Y = Point.Y + K.K;
                    Point.X--;
                    CheckPadelCollision(padel1);
                }
                Point.Y = Point.Y + K.K;
                Point.X--;
                CheckPadelCollision(padel1);


            } else if (Direction == "right")
            {
                if (Point.Y == 1 || Point.Y == 12)
                {
                    K.K *= -1;

                    Point.Y = Point.Y + K.K;
                    Point.X++;
                    CheckPadelCollision(padel2);
                }

                Point.Y = Point.Y + K.K;
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
using System;
namespace Pong
{
	public class Ball
	{
        Point Point;
        string Direction;
        int Angle; 

        public Ball(Point point)
		{
            var random = new Random();
            Point = point;
            Direction = "left";
            Angle = (int)((0.5 - random.Next(0, 2)) * 2);
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
                Bounce();
                Point.X--;
                CheckPadelCollision(padel1);


            } else if (Direction == "right")
            {

                Bounce();
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

        private void Bounce()
        {
            if (Point.Y == 1 || Point.Y == 12)
            {
                Angle *= -1;

            }
            Point.Y = Point.Y + Angle;
        }
	}
}
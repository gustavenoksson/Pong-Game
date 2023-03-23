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

        public void ClearBall()
        {
            Console.SetCursorPosition(Point.X, Point.Y);
            Console.WriteLine(' ');
        }

        public void Move(Padel padel1, Padel padel2)
        {
            ClearBall();
            Bounce();

            if (Direction == "left")
            {  
                Point.X--;
                CheckPadelCollision(padel1);
            } else if (Direction == "right")
            {
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

        public bool checkForGoal()
        {
            if (Point.X < 7)
            {


                Console.SetCursorPosition(39, 6);
                Console.Write("player 2 score");
                Console.SetCursorPosition(34, 7);
                Console.Write("Press enter to play again");
                return true;
            }
            else if (Point.X > 83)
            {
                Console.SetCursorPosition(39, 6);
                Console.Write("player 1 score");
                Console.SetCursorPosition(34, 7);
                Console.Write("Press enter to play again");
                return true;

            }
            else {
                return false;
            }

        }

        public void ResetBall()
        {
            ClearBall();
            Point.X = 39;
            Point.Y = 6;
            Console.SetCursorPosition(Point.X, Point.Y);
        }
	}
}
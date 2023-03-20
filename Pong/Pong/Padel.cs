using System;
namespace Pong
{
	public class Padel
	{
        Point Point;

		public Padel(Point point)
		{
            Point = point;
		}

		public void DrawPadel()
		{
            

            for (int i = Point.Y; i < Point.Y + 2; i++)
            {
                Console.SetCursorPosition(Point.X, i);
                Console.WriteLine('|');
            }
        }

        public void MoveUp()
        {
            if (Point.Y > 1)
            {
                for (int i = 1; i < 13; i++)
                {
                    Console.SetCursorPosition(Point.X, i);
                    Console.WriteLine(" ");
                }
                Point.Y--;
                for (int i = Point.Y; i < Point.Y + 2; i++)
                {
                    Console.SetCursorPosition(Point.X, i);
                    Console.WriteLine('|');
                }

            }

        }

        public void MoveDown()
        {
            if (Point.Y < 11)
            {
                for (int i = 1; i < 13; i++)
                {
                    Console.SetCursorPosition(Point.X, i);
                    Console.WriteLine(" ");
                }
                Point.Y++;
                for (int i = Point.Y; i < Point.Y + 2; i++)
                {
                    Console.SetCursorPosition(Point.X, i);
                    Console.WriteLine('|');
                }
            }
            
        }
    }
}


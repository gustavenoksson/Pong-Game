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
            Point.Y--;
            Console.Write(Point.Y);
            Console.SetCursorPosition(Point.X, Point.Y);
            Console.WriteLine('|');

        }
	}
}


using System;
namespace Pong
{
	public class Padel
	{
        public Point Point;

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
                Point.Y--;
                ClearBoard();
                DrawPadel();
            }
        }

        public void MoveDown()
        {
            if (Point.Y < 11)
            {
                Point.Y++;
                ClearBoard();
                DrawPadel();
            }
        }

        private void ClearBoard()
        {
            for (int i = 1; i < 13; i++)
            {
                Console.SetCursorPosition(Point.X, i);
                Console.WriteLine(" ");
            }
        }
    }
}


using System;
namespace Pong
{
	public class Padel
	{
        public int point = 6;

		public Padel()
		{
		}

		public void DrawPadel(int point)
		{
            for (int i = point; i < point + 2; i++)
            {
                Console.SetCursorPosition(7, i);
                Console.WriteLine('|');
            }

            for (int i = point; i < point + 2; i++)
            {
                Console.SetCursorPosition(83, i);
                Console.WriteLine('|');
            }
        }

        public void MoveUp()
        {
            point++;
            DrawPadel(point);
        }
	}
}


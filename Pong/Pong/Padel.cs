using System;
namespace Pong
{
	public class Padel
	{
        public int point = 10;

		public Padel()
		{
		}

		public void DrawPadel()
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
	}
}


using System;
namespace Pong
{
	public class PlayingField
	{
		public int width = 80;
		public int height = 14;

		public PlayingField()
		{
		}

		public void DrawField()
		{
			for (int i = 1; i < width; i++)
			{
                Console.SetCursorPosition(i, 0);
                Console.WriteLine('*');
            }
            for (int i = 1; i < width; i++)
            {
                Console.SetCursorPosition(i, 13);
                Console.WriteLine('*');
            }
            for (int i = 0; i < height; i++)
			{
                Console.SetCursorPosition(0, i);
                Console.WriteLine('*');
            }
			for (int i = 0; i < height; i++)
			{
                Console.SetCursorPosition(80, i);
                Console.WriteLine('*');
            }
		}
	}
}
using System;
namespace Pong
{
	public class PlayingField
	{
		public int width = 80;
		public int height = 20;

		public PlayingField()
		{
		}

		public void DrawField()
		{
			for (int i = 1; i < width; i++)
			{
                Console.SetCursorPosition(i, 0);
                Console.WriteLine('I');
            }
			for (int i = 0; i < height; i++)
			{
                Console.SetCursorPosition(0, i);
                Console.WriteLine("II");
            }
			for (int i = 0; i < height; i++)
			{
                Console.SetCursorPosition(i, 80);
                Console.WriteLine("II");
            }
		}
	}
}
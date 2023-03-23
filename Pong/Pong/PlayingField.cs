using System;
namespace Pong
{
	public class PlayingField
	{
		public int width = 85;
		public int height = 14;

		public PlayingField()
		{
		}

		public void DrawField()
		{
			for (int i = 6; i < width; i++)
			{
                Console.SetCursorPosition(i, 0);
                Console.WriteLine('*');
            }
            for (int i = 6; i < width; i++)
            {
                Console.SetCursorPosition(i, 13);
                Console.WriteLine('*');
            }
            for (int i = 0; i < height; i++)
			{
                Console.SetCursorPosition(5, i);
                Console.WriteLine('*');
            }
			for (int i = 0; i < height; i++)
			{
                Console.SetCursorPosition(width, i);
                Console.WriteLine('*');
            }
		}

		public void ClearText()
		{
            for (var i = 9; i < width - 9; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.WriteLine(" ");
                Console.SetCursorPosition(i, 6);
                Console.WriteLine(" ");
                Console.SetCursorPosition(i, 7);
                Console.WriteLine(" ");
            }
        }
	}
}
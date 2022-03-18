using System;

namespace LearnProgramming
{
    internal class Surface
    {

        private int left;
        private int top;

        public void BeginDraw()
        {
            Console.Clear();
            left = Console.CursorLeft;
            top = Console.CursorTop;
        }

        public void DrawAt(char c, Position position)
        {
            try
            {
                Console.SetCursorPosition(left + position.X, top + position.Y);
                Console.Write(c);
            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
    }
}
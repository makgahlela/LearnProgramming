namespace LearnProgramming
{
    internal class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Position(int x=0,int y = 0)
        {
            X = x;
            Y = y;
        }
    }
}
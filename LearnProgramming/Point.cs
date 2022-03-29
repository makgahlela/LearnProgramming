using System;

namespace LearnProgramming
{
    public struct Point<T> where T : struct,IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public T X { get; }

        public T Y { get; }

        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }
}

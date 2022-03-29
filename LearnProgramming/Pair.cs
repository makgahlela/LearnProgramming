using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProgramming
{
    internal class Pair<T,U>
    {
        public T Item1 { get; private set; }
        public U Item2 { get; private set; }
        public Pair(T item1,U item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override string ToString() => $"{Item1} {Item2}";
    }
}

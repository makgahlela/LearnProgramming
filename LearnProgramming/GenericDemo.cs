using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProgramming
{
    internal class GenericDemo<T>
    {
        public T Value { get; private set; }
        public GenericDemo(T value)
        {
            Value = value;
        }
        public override string ToString() => $"{typeof(T)}: {Value}";
        //public override string ToString()
        //{
        //    return $"{typeof(T)}: {Value}";
        //}
    }
}

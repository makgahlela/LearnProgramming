using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProgramming
{
    public class CompareObjects<T>
    {
        /// <summary>
        /// 'Generic Method' Compares 2 types of Generic inputs
        /// </summary>
        /// <typeparam name="T">Generic T</typeparam>
        /// <param name="input1">Comparer</param>
        /// <param name="input2">Comparer</param>
        /// <returns>returns true or false based on the Equality of both the inputs</returns>
        public bool Compare<T>(T input1,T input2)
        {
            return input1.Equals(input2);
        }
    }
}

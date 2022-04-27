using System;
using System.IO;
using System.Collections.Concurrent;

namespace LearnProgramming
{

    internal class Program
    {
        static void Main(string[] args)
        {//follower
            string path = @"C:\Temp\Dir";
            var files = Directory.GetFiles(path, "Gra*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadLine();
        }

    }//class

}



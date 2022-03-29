
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace LearnProgramming
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Point<int> p1 = new Point<int>(3, 4);
            Point<double> p2 = new Point<double>(3.12,4.55);
            //Point<bool> p3 = new Point<bool>(true,false);
            //Point<string> p4 = new Point<string>("Alpha", "Beta");
            Console.WriteLine(p2);

            Console.ReadLine();
        }

    }//class

}




using System;

namespace LearnProgramming
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Git Testing", 2500);
             employee.GiveRaise(5);
            Console.WriteLine("R"+employee.Salary);
            Console.WriteLine("Second try");
            Console.Read();
        }

    }//class
}




using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace LearnProgramming
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"StudentData.txt";
            //string path = @"C:\Users\kgets\Desktop\Builds\StudentData.txt";
            Student student = new Student()
            {
                Id = 1,
                Name = "Melvin",
                Qualification = "BCS",
                Hobies = new List<string>()
                {
                "Reading",
                "Playing Games",
                "Walking",
                "Cooking",
                "Fishing",
                }
            };

            string resultjson = JsonConvert.SerializeObject(student);
            File.WriteAllText(path, resultjson);
            Console.WriteLine(resultjson);

            resultjson = String.Empty;
            resultjson = File.ReadAllText(path);
            var resultStudent = JsonConvert.DeserializeObject<Student>(resultjson);
            Console.WriteLine("Student");
            Console.WriteLine();
            Console.WriteLine(resultStudent.ToString());
            Console.ReadLine();

            //    Employee employee = new Employee("Git Testing", 2500);
            //     employee.GiveRaise(5);
            //    Console.Read();
        }

    }//class
}



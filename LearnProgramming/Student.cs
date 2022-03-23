using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProgramming
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public List<string> Hobies { get; set; }

        public override string ToString()
        {
            return String.Format("Student Information:\n\tID {0},\n\tName {1},\n\tQualification {2}\n,\n\tHobbies: {3}", Id,Name,Qualification,string.Join(",\n\t", Hobies.ToArray()));
        }
    }
}

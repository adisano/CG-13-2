using System;
using System.Collections.Generic;

namespace HighSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("A", "b", 1, 1);
            student.GetStudents();
            List<Student> list = new List<Student>(); 
            list = student.PrintStudents(student.Students);
            foreach (var _student in list)
            {
                Console.Write(_student.FirstName + " ");
                Console.Write(_student.LastName + " ");
                Console.Write(_student.Grade + " ");
                Console.WriteLine(_student.Gpa);
            }
            Console.ReadLine();
        }
    }
}

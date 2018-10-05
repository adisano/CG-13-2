using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HighSchool
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int Gpa { get; set; }

        public Student(string firstName, string lastName, int grade, int gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
            Gpa = gpa;
        }

        public List<Student> Students = new List<Student>();        

        public void GetStudents()
        {

            Students.Add(new Student("Bob", "Smith", 10, 4));
            Students.Add(new Student("Bill", "Jones", 11, 4));
            Students.Add(new Student("Amy", "Jones", 6, 2));
            Students.Add(new Student("Omar", "Bird", 4, 1));
            Students.Add(new Student("Gregory", "Reed", 8, 3));
            Students.Add(new Student("Quenton", "Bartle", 12, 4));
            Students.Add(new Student("Priscilla", "White", 1, 1));
            Students.Add(new Student("Frank", "Lemons", 4, 2));
            Students.Add(new Student("Bianca", "Marie", 9, 3));
            Students.Add(new Student("Lulu", "Park", 3, 3));
        }

        public List<Student> PrintStudents(List<Student> students)
        {
            //using LINQ, create a list of students whose GPA is 3 or greater and are in the 9th-12th grade
            var list = students.Where(s => s.Gpa >= 3 && s.Grade >= 9)
                .OrderByDescending(s => s.Grade)
                .ThenByDescending(s => s.Gpa)
                .ThenBy(s => s.LastName)
                .ThenBy(s => s.FirstName)
                .ToList();

            //return the list
            return list;
        }

    }
}

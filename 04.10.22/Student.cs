using System;
using System.Collections.Generic;
using System.Text;

namespace _04._10._22
{
    class Student : Person
    {
        private static int id;
        public int Id;
        public string[] lessons = new string[0];

        public Student() : base()
        {
            id++;
            id = id;

        }
        public void stutentinfo()
        {
            Console.WriteLine($"name:{Name},surname{Surname},age{Age},id:{id}");
        }
        public Student[] Students = new Student[0];

        public string Addstudent1(string Homework)
        {
            Array.Resize(ref lessons, lessons.Length + 1);
            lessons[lessons.Length - 1] = Homework;
            return Homework;

        }
        //public void AddStudent(Student student)
        //{
        //    Array.Resize(ref Students, Students.Length + 1);
        //    Students[Students.Length - 1] = student;

          
          

        //}
    }
}

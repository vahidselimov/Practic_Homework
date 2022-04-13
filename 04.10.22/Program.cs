using System;

namespace _04._10._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // butun tasklar bir yerdedir,Task 1 ve Task2


            #region Task1
            //int age;
            //int experience;


            //do
            //{
            //    Console.WriteLine("Age enter");
            //     age = Convert.ToInt32(Console.ReadLine());

            //} while (age<0);

            //{
            //    Console.WriteLine("Experience enter");
            //    experience = Convert.ToInt32(Console.ReadLine());

            //} while (experience<0||experience>80);
            //Teacher teacher = new Teacher("Vahid","Selimov",experience,age);
            //Teacher teacher1 = new Teacher("Vahid", "Selimov",  experience, age);
            //teacher.Theacherinfo();
            //teacher1.Theacherinfo();
            //Student student = new Student();
            //student.Stutentinfo();
            //Student student1 = new Student();
            //student1.Stutentinfo();
            #endregion
            Group group = new Group();
            group.AddStudent("Selimov Vahid");

            group.AddStudent(Console.ReadLine());
            Console.WriteLine("\n ---- \n");
            foreach (string item in group.Fullname)
            {
                Console.WriteLine(item);
            }
            Student student = new Student();
            //student.Addstudent1("Task");
            foreach (string item in student.lessons)
            {
                Console.WriteLine(item);

            }
            Group student1 = new Group();
            student1.Name = "Vahid";
            student1.Surname = "Selimov";
            student1.AddStudent2(student1);
            /*Console.WriteLine(student)*/;
            foreach (var item in group.Students)
            {
                Console.WriteLine(student1.Name+" "+student1.Surname);
            }
            

            
        }
    }
}

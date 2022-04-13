using System;
using System.Collections.Generic;
using System.Text;

namespace _04._10._22
{
    class Teacher : Person
    {
        private static int id;
        public int Id { get; }
        private int _experience { get; set; }
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value > 0 && value < 81)
                {
                    _experience = value;
                }

            }
        }
        public Teacher(string name, string surname,  int experience,int age):base(name,surname,experience,age)
        {
            Age = age;
            Name = name;
            Surname = surname;

            id++;
            Id = id;
            
            
            Experience = experience;
        }
        public void Theacherinfo()
        {
            Console.WriteLine($"Name:{Name},Surname{Surname},Age{Age},ID:{Id}");
        }

    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace _04._10._22
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _age { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value>0)
                {
                    _age = value;
                }
            }
           
        }
        public Person()
        {

        }
        public Person(string name, string surname, int experience, int age)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }
    }
}

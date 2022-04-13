using System;
using System.Collections.Generic;
using System.Text;

namespace _04._10._22
{
    class Group:Person
    {
        public string[] Fullname = new string[0];
        public int GroupNo;
        public Group[] Students = new Group[0];
        public string AddStudent(string fullname)
        {
            Array.Resize(ref Fullname, Fullname.Length + 1);
            Fullname[Fullname.Length - 1] = fullname;
            return fullname;
        }

        public  void AddStudent2(Group student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
    }
    
}

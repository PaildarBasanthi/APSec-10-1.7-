using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Phase1Section5._6
{
    public class CClass
    {
        public string ClassName { get; set; }
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public CClass(string className, Subject subject, Teacher teacher, List<Student> students)
        {
            ClassName = className;
            Subject = subject;
            Teacher = teacher;
            Students = students;
        }
    }

}


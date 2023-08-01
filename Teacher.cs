using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Section5._6
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Teacher(string name, string department)
        {
            Name = name;
            Department = department;
        }
    }
}

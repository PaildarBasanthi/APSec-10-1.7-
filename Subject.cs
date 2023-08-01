using System;
using System.Collections.Generic;
using System.Text;
public class Subject
{
    public string Name { get; set; }
    public int Credits { get; set; }

    public Subject(string name, int credits)
    {
        Name = name;
        Credits = credits;
    }
}




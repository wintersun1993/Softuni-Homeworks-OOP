using System;

class Teacher : People
{
    public Disciplines[] discipline;
    
    public Teacher(string name, string details,Disciplines[] discipline)
        : base(name, details)
    {
        this.discipline = discipline;
    }
}


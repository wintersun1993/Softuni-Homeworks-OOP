using System;

class SchoolClass
{
    public string Ident { get; set; }
    private Teacher[] setTeachers;

    public SchoolClass(string ident, Teacher[] setTeachers)
    {
        this.Ident = ident;
        this.setTeachers = setTeachers;
    }
}


using System;

class Student : Human
{
    public string facn;

    public Student(string firstname,string lastname,string facn) :
        base(firstname, lastname)
    {
        this.facN = facn;
    }

    public string facN
    {
        get
        {
            return this.facn;
        }
        set
        {
            this.facn = value;
        }
    }

}


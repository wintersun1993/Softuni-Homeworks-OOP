using System;


class Students : People
{
    
    public Students(string name, string uniquenumber, string details = null) 
        : base(name,details)
    {
        this.Unique = Unique;
    }

    public string Unique 
    {
        get;
        set;
    }
}


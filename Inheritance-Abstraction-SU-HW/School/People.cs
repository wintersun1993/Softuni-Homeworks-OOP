using System;

abstract class People
{
    public People(string name, string details)
    {
        this.Name = name;
        this.Details = details;
    }

    public string Name 
    {
        get { return this.Name; }
        set { this.Name=value;}
    }
    public string Details
    {
        get { return this.Details; }
        set { this.Details = value; }
    }

}


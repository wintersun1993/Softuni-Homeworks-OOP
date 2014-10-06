using System;

class Disciplines
{
    private string name;
    private int numberLect;
    private int numberStud;

    public Disciplines(string name,int numberLect,int numberStud,string details)
    {
        this.Name = name;
        this.NumL = numberLect;
        this.NumS = numberStud;
        this.Details = details;
    }

    public string Name { get; set; }
    public int NumL { get; set; }
    public int NumS { get; set; }
    public string Details { get; set; }
}


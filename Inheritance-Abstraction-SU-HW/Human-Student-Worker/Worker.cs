using System;

class Worker : Human
{
    public double weekSalary;
    public double workHours;

    public Worker(string firstname,string lastname,double weeksalary,double workhours)
        : base(firstname, lastname)
    {
        this.WeekSalary = weeksalary;
        this.WorkHours = workhours;
    }

    public double MoneyPerHour()
    {
        return (this.WeekSalary / 5) / this.WorkHours;
    }


    public double WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            this.weekSalary = value;
        }
    }

    public double WorkHours
    {
        get
        {
            return this.workHours;
        }
        set
        {
            this.workHours = value;
        }
    }
}

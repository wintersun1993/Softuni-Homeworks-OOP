﻿using System;

abstract class Human
{
    public string firstName;
    public string lastName;

    public Human(string firstname, string lastname)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            this.firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            this.lastName = value;
        }
    }

}

// Goal.cs
using System;

public abstract class Goal
{
    // attributes
    private string _shortname;
    private string _description;
    private string _points; 


    // Methods and constructors

    public Goal(string name, string description, string points) //constructor
    {}
    public abstract void RecordEvent();
   

    public abstract bool IsComplete();

    public virtual  string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();





}
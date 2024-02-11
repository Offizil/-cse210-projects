// EternalGoal.cs
using System;

public class EternalGoal : Goal
{
    // attributes

    // methods
    public EternalGoal(string name, string description, string points) : base(name, description, points) // constructor
    {}

    public override void RecordEvent()
    {}
   

    public override bool IsComplete()
    {
        return false;
    }

     public override string GetStringRepresentation()
    {
        return "";
    }



    
}
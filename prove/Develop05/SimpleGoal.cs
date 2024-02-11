// SimpleGoal.cs
using System;

public class SimpleGoal : Goal
{
    

    // attributes
    private bool _isComplete = false;

    
    
    SimpleGoal(string name, string description, string points) : base(name,description, points) // constructor
    {}
    // methods/responsibilities
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

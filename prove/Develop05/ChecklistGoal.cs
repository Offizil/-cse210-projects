// ChecklistGoal.cs
using System;

public class ChecklistGoal : Goal
{
    // attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // methods/constructors
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {_target = target;
    _bonus = bonus;
    } // constructor

    public override string GetDetailsString()
    {
        return "";
    }

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
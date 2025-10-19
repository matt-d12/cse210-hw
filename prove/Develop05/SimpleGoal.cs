using System;

//Sub Class of Goal
public class SimpleGoal : Goal
{
    //Establish atributes
    private bool _isComplete;

    //Constructor method
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    //Method when event is recordded
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    //Method to return if goal is completed
    public override bool IsComplete()
    {
        return _isComplete;
    }

    //Method to put string together
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()}, {GetDescription()}, {GetPoints()}, {_isComplete}";
    }        
}

using System;

//Sub class of Goal
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        //Nothing here as this never gets marked as "completed" 
    }

    //Method for recording an event
    public override void RecordEvent()
    {
        //COME BACK
    }

    //Method for making sure this doesn't get marked as complete
    public override bool IsComplete()
    {
        return false;
    }

    //Method to put string together
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()}, {GetDescription()}, {GetPoints()}";
    }   
        
}
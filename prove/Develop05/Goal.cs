using System;

public abstract class Goal
{
    //Establish attributes
    private string _name = "";
    private string _description = "";
    private int _points = 0;

    //Constructor method
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    //Getter for name
    protected string GetName()
    {
        return _name;
    }

    //Getter for description
    public string GetDescription()
    {
        return _description;
    }

    //Getter for points
    protected int GetPoints()
    {
        return _points;
    }

    //Setter for name
    protected void SetName(string name)
    {
        _name = name;
    }

    //Setter for description
    protected void SetDescription(string description)
    {
        _description = description;
    }

    //Setter for points
    protected void SetPoints(int points)
    {
        _points = points;
    }

    //Abstract methods to be overriden
    public abstract void RecordEvent();
    public abstract string GetStringRepresentation();
    public abstract bool IsComplete();
}
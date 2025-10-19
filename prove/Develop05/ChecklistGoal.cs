using System;

//Sub class of Goal
public class ChecklistGoal : Goal
{
    //Establish attributes
    private int _bonusPoints;
    private int _completedCount;
    private int _totalCount;

    //Constructor method
    public ChecklistGoal(string name, string description, int points, int bonusPoints,
                        int totalCount, int completedCount = 0)
        : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _totalCount = totalCount;
        _completedCount = completedCount;
    }

    //Method for recording event 
    public override void RecordEvent()
    {
        //Check completed vs total and add 1 if list not fully completed
        if (_completedCount < _totalCount)
        {
            _completedCount++;
        }
    }

    //Method for marking complete once completed count = total count
    public override bool IsComplete()
    {
        return _completedCount >= _totalCount;
    }

    //Method to put string together
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonusPoints}|{_totalCount}|{_completedCount}";
    }

    //Getter for bonus points
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    //Getter for completed count
    public int GetCompletedCount()
    {
        return _completedCount;
    }

    //Getter for total count
    public int GetTotalCount()
    {
        return _totalCount;
    }

    //Method for displayed info when listing
    public override string GetInfo()
    {
        return $"{GetName()} ({GetDescription()}) -- Currently completed: {_completedCount}/{_totalCount}";
    }

}

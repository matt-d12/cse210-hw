using System;

public class Assignment
{
    //Establish attributes
    protected string _studentName;
    private string _topic;

    //Constructor method
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Method for creating and getting the summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
using System;
using System.Reflection;

public class WritingAssignment : Assignment
{
    //Establish attributes
    private string _title;

    //Constructor method
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    //Method to get writing info
    public string GetWritingInfo()
    {
        return $"{_title} by {_studentName}";
    }
}